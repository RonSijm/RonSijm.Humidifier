namespace Humidifier.S3
{
    using global::System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveRoleArn, IHavePriority
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string GeneratedManifestDescriptor =  "GeneratedManifestDescriptor" ;
            public static string TerminationDate =  "TerminationDate" ;
            public static string ProgressSummary =  "ProgressSummary" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
            public static string JobId =  "JobId" ;
        }

        public override string AWSTypeName { get => AWS.S3.Job; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ManifestGenerator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-manifestgenerator
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobManifestGenerator
        /// </summary>
        public Humidifier.S3.JobTypes.JobManifestGenerator ManifestGenerator { get; set; }

        /// <summary>
        /// Report
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-report
        /// Required: True
        /// UpdateType: Immutable
        /// Type: JobReport
        /// </summary>
        [Required]
        public Humidifier.S3.JobTypes.JobReport Report { get; set; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-priority
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic Priority { get; set; }
        /// <summary>
        /// ConfirmationRequired
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-confirmationrequired
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ConfirmationRequired { get; set; }

        /// <summary>
        /// Operation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-operation
        /// Required: True
        /// UpdateType: Immutable
        /// Type: JobOperation
        /// </summary>
        [Required]
        public Humidifier.S3.JobTypes.JobOperation Operation { get; set; }
        /// <summary>
        /// Manifest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-manifest
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobManifest
        /// </summary>
        public Humidifier.S3.JobTypes.JobManifest Manifest { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace JobTypes
    {
        public class DSSEKMSFilter : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-dssekmsfilter.html#cfn-s3-job-dssekmsfilter-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
        }

        public class GeneratedManifestEncryption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SSEKMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-generatedmanifestencryption.html#cfn-s3-job-generatedmanifestencryption-ssekms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SSEKMSEncryption
            /// </summary>
            public Humidifier.S3.JobTypes.SSEKMSEncryption SSEKMS { get; set; }
            /// <summary>
            /// SSES3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-generatedmanifestencryption.html#cfn-s3-job-generatedmanifestencryption-sses3
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic SSES3 { get; set; }
        }

        public class JobManifest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Spec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifest.html#cfn-s3-job-jobmanifest-spec
            /// Required: True
            /// UpdateType: Immutable
            /// Type: JobManifestSpec
            /// </summary>
            public Humidifier.S3.JobTypes.JobManifestSpec Spec { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifest.html#cfn-s3-job-jobmanifest-location
            /// Required: True
            /// UpdateType: Immutable
            /// Type: JobManifestLocation
            /// </summary>
            public Humidifier.S3.JobTypes.JobManifestLocation Location { get; set; }
        }

        public class JobManifestGenerator : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3JobManifestGenerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgenerator.html#cfn-s3-job-jobmanifestgenerator-s3jobmanifestgenerator
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3JobManifestGenerator
            /// </summary>
            public Humidifier.S3.JobTypes.S3JobManifestGenerator S3JobManifestGenerator { get; set; }
        }

        public class JobManifestGeneratorFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ObjectReplicationStatuses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-objectreplicationstatuses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ObjectReplicationStatuses { get; set; }
            /// <summary>
            /// MatchAnyStorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-matchanystorageclass
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchAnyStorageClass { get; set; }
            /// <summary>
            /// KeyNameConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-keynameconstraint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KeyNameConstraint
            /// </summary>
            public Humidifier.S3.JobTypes.KeyNameConstraint KeyNameConstraint { get; set; }
            /// <summary>
            /// EligibleForReplication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-eligibleforreplication
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EligibleForReplication { get; set; }
            /// <summary>
            /// CreatedAfter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-createdafter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedAfter { get; set; }
            /// <summary>
            /// ObjectSizeLessThanBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-objectsizelessthanbytes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ObjectSizeLessThanBytes { get; set; }
            /// <summary>
            /// ObjectSizeGreaterThanBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-objectsizegreaterthanbytes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ObjectSizeGreaterThanBytes { get; set; }
            /// <summary>
            /// MatchAnyObjectEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-matchanyobjectencryption
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ObjectEncryptionFilter
            /// </summary>
            public List<Humidifier.S3.JobTypes.ObjectEncryptionFilter> MatchAnyObjectEncryption { get; set; }
            /// <summary>
            /// CreatedBefore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-createdbefore
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedBefore { get; set; }
        }

        public class JobManifestLocation : Humidifier.Base.BaseSubResource, IHaveETag
        {
            /// <summary>
            /// ETag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestlocation.html#cfn-s3-job-jobmanifestlocation-etag
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic ETag { get; set; }
            /// <summary>
            /// ObjectArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestlocation.html#cfn-s3-job-jobmanifestlocation-objectarn
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectArn { get; set; }
            /// <summary>
            /// ObjectVersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestlocation.html#cfn-s3-job-jobmanifestlocation-objectversionid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectVersionId { get; set; }
        }

        public class JobManifestSpec : Humidifier.Base.BaseSubResource, IHaveFormat
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestspec.html#cfn-s3-job-jobmanifestspec-format
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestspec.html#cfn-s3-job-jobmanifestspec-fields
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Fields { get; set; }
        }

        public class JobOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3ComputeObjectChecksum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3computeobjectchecksum
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3ComputeObjectChecksumOperation
            /// </summary>
            public Humidifier.S3.JobTypes.S3ComputeObjectChecksumOperation S3ComputeObjectChecksum { get; set; }
            /// <summary>
            /// S3PutObjectLegalHold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3putobjectlegalhold
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3SetObjectLegalHoldOperation
            /// </summary>
            public Humidifier.S3.JobTypes.S3SetObjectLegalHoldOperation S3PutObjectLegalHold { get; set; }
            /// <summary>
            /// S3PutObjectCopy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3putobjectcopy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3CopyObjectOperation
            /// </summary>
            public Humidifier.S3.JobTypes.S3CopyObjectOperation S3PutObjectCopy { get; set; }
            /// <summary>
            /// S3PutObjectAcl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3putobjectacl
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3SetObjectAclOperation
            /// </summary>
            public Humidifier.S3.JobTypes.S3SetObjectAclOperation S3PutObjectAcl { get; set; }
            /// <summary>
            /// LambdaInvoke
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-lambdainvoke
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LambdaInvokeOperation
            /// </summary>
            public Humidifier.S3.JobTypes.LambdaInvokeOperation LambdaInvoke { get; set; }
            /// <summary>
            /// S3PutObjectRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3putobjectretention
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3SetObjectRetentionOperation
            /// </summary>
            public Humidifier.S3.JobTypes.S3SetObjectRetentionOperation S3PutObjectRetention { get; set; }
            /// <summary>
            /// S3UpdateObjectEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3updateobjectencryption
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3UpdateObjectEncryptionOperation
            /// </summary>
            public Humidifier.S3.JobTypes.S3UpdateObjectEncryptionOperation S3UpdateObjectEncryption { get; set; }
            /// <summary>
            /// S3DeleteObjectTagging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3deleteobjecttagging
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic S3DeleteObjectTagging { get; set; }
            /// <summary>
            /// S3ReplicateObject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3replicateobject
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic S3ReplicateObject { get; set; }
            /// <summary>
            /// S3InitiateRestoreObject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3initiaterestoreobject
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3InitiateRestoreObjectOperation
            /// </summary>
            public Humidifier.S3.JobTypes.S3InitiateRestoreObjectOperation S3InitiateRestoreObject { get; set; }
            /// <summary>
            /// S3PutObjectTagging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3putobjecttagging
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3SetObjectTaggingOperation
            /// </summary>
            public Humidifier.S3.JobTypes.S3SetObjectTaggingOperation S3PutObjectTagging { get; set; }
        }

        public class JobProgressSummary : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TotalNumberOfTasks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobprogresssummary.html#cfn-s3-job-jobprogresssummary-totalnumberoftasks
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TotalNumberOfTasks { get; set; }
            /// <summary>
            /// NumberOfTasksFailed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobprogresssummary.html#cfn-s3-job-jobprogresssummary-numberoftasksfailed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfTasksFailed { get; set; }
            /// <summary>
            /// NumberOfTasksSucceeded
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobprogresssummary.html#cfn-s3-job-jobprogresssummary-numberoftaskssucceeded
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfTasksSucceeded { get; set; }
            /// <summary>
            /// Timers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobprogresssummary.html#cfn-s3-job-jobprogresssummary-timers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JobTimers
            /// </summary>
            public Humidifier.S3.JobTypes.JobTimers Timers { get; set; }
        }

        public class JobReport : Humidifier.Base.BaseSubResource, IHaveEnabled, IHavePrefix, IHaveBucket, IHaveFormat, IHaveExpectedBucketOwner
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-format
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// ReportScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-reportscope
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReportScope { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-prefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-expectedbucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExpectedBucketOwner { get; set; }
        }

        public class JobTimers : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ElapsedTimeInActiveSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobtimers.html#cfn-s3-job-jobtimers-elapsedtimeinactiveseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ElapsedTimeInActiveSeconds { get; set; }
        }

        public class KeyNameConstraint : Humidifier.Base.BaseSubResource, IHaveMatchAnyPrefix, IHaveMatchAnySuffix
        {
            /// <summary>
            /// MatchAnyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-keynameconstraint.html#cfn-s3-job-keynameconstraint-matchanyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchAnyPrefix { get; set; }
            /// <summary>
            /// MatchAnySubstring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-keynameconstraint.html#cfn-s3-job-keynameconstraint-matchanysubstring
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchAnySubstring { get; set; }
            /// <summary>
            /// MatchAnySuffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-keynameconstraint.html#cfn-s3-job-keynameconstraint-matchanysuffix
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchAnySuffix { get; set; }
        }

        public class LambdaInvokeOperation : Humidifier.Base.BaseSubResource, IHaveFunctionArn
        {
            /// <summary>
            /// UserArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-lambdainvokeoperation.html#cfn-s3-job-lambdainvokeoperation-userarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> UserArguments { get; set; }
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-lambdainvokeoperation.html#cfn-s3-job-lambdainvokeoperation-functionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionArn { get; set; }
            /// <summary>
            /// InvocationSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-lambdainvokeoperation.html#cfn-s3-job-lambdainvokeoperation-invocationschemaversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationSchemaVersion { get; set; }
        }

        public class ObjectEncryption : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SSEKMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryption.html#cfn-s3-job-objectencryption-ssekms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3UpdateObjectEncryptionSSEKMS
            /// </summary>
            public Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS SSEKMS { get; set; }
        }

        public class ObjectEncryptionFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SSEKMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryptionfilter.html#cfn-s3-job-objectencryptionfilter-ssekms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SSEKMSFilter
            /// </summary>
            public Humidifier.S3.JobTypes.SSEKMSFilter SSEKMS { get; set; }
            /// <summary>
            /// SSEC
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryptionfilter.html#cfn-s3-job-objectencryptionfilter-ssec
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic SSEC { get; set; }
            /// <summary>
            /// NOTSSE
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryptionfilter.html#cfn-s3-job-objectencryptionfilter-notsse
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic NOTSSE { get; set; }
            /// <summary>
            /// DSSEKMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryptionfilter.html#cfn-s3-job-objectencryptionfilter-dssekms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DSSEKMSFilter
            /// </summary>
            public Humidifier.S3.JobTypes.DSSEKMSFilter DSSEKMS { get; set; }
            /// <summary>
            /// SSES3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryptionfilter.html#cfn-s3-job-objectencryptionfilter-sses3
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic SSES3 { get; set; }
        }

        public class S3AccessControlList : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3accesscontrollist.html#cfn-s3-job-s3accesscontrollist-owner
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3ObjectOwner
            /// </summary>
            public Humidifier.S3.JobTypes.S3ObjectOwner Owner { get; set; }
            /// <summary>
            /// Grants
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3accesscontrollist.html#cfn-s3-job-s3accesscontrollist-grants
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: S3Grant
            /// </summary>
            public List<Humidifier.S3.JobTypes.S3Grant> Grants { get; set; }
        }

        public class S3AccessControlPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AccessControlList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3accesscontrolpolicy.html#cfn-s3-job-s3accesscontrolpolicy-accesscontrollist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3AccessControlList
            /// </summary>
            public Humidifier.S3.JobTypes.S3AccessControlList AccessControlList { get; set; }
            /// <summary>
            /// CannedAccessControlList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3accesscontrolpolicy.html#cfn-s3-job-s3accesscontrolpolicy-cannedaccesscontrollist
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CannedAccessControlList { get; set; }
        }

        public class S3ComputeObjectChecksumOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChecksumAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3computeobjectchecksumoperation.html#cfn-s3-job-s3computeobjectchecksumoperation-checksumalgorithm
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChecksumAlgorithm { get; set; }
            /// <summary>
            /// ChecksumType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3computeobjectchecksumoperation.html#cfn-s3-job-s3computeobjectchecksumoperation-checksumtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChecksumType { get; set; }
        }

        public class S3CopyObjectOperation : Humidifier.Base.BaseSubResource, IHaveStorageClass, IHaveBucketKeyEnabled
        {
            /// <summary>
            /// ModifiedSinceConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-modifiedsinceconstraint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModifiedSinceConstraint { get; set; }
            /// <summary>
            /// RedirectLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-redirectlocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedirectLocation { get; set; }
            /// <summary>
            /// ObjectLockLegalHoldStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-objectlocklegalholdstatus
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectLockLegalHoldStatus { get; set; }
            /// <summary>
            /// AccessControlGrants
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-accesscontrolgrants
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: S3Grant
            /// </summary>
            public List<Humidifier.S3.JobTypes.S3Grant> AccessControlGrants { get; set; }
            /// <summary>
            /// SSEAwsKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-sseawskmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SSEAwsKmsKeyId { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-storageclass
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageClass { get; set; }
            /// <summary>
            /// ChecksumAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-checksumalgorithm
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChecksumAlgorithm { get; set; }
            /// <summary>
            /// TargetKeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-targetkeyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetKeyPrefix { get; set; }
            /// <summary>
            /// CannedAccessControlList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-cannedaccesscontrollist
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CannedAccessControlList { get; set; }
            /// <summary>
            /// NewObjectMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-newobjectmetadata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3ObjectMetadata
            /// </summary>
            public Humidifier.S3.JobTypes.S3ObjectMetadata NewObjectMetadata { get; set; }
            /// <summary>
            /// BucketKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-bucketkeyenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BucketKeyEnabled { get; set; }
            /// <summary>
            /// TargetResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-targetresource
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetResource { get; set; }
            /// <summary>
            /// NewObjectTagging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-newobjecttagging
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Humidifier.Tag> NewObjectTagging { get; set; }
            /// <summary>
            /// RequesterPays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-requesterpays
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequesterPays { get; set; }
            /// <summary>
            /// UnModifiedSinceConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-unmodifiedsinceconstraint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnModifiedSinceConstraint { get; set; }
            /// <summary>
            /// ObjectLockRetainUntilDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-objectlockretainuntildate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectLockRetainUntilDate { get; set; }
            /// <summary>
            /// ObjectLockMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-objectlockmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectLockMode { get; set; }
            /// <summary>
            /// MetadataDirective
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-metadatadirective
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetadataDirective { get; set; }
        }

        public class S3GeneratedManifestDescriptor : Humidifier.Base.BaseSubResource, IHaveFormat
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3generatedmanifestdescriptor.html#cfn-s3-job-s3generatedmanifestdescriptor-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3generatedmanifestdescriptor.html#cfn-s3-job-s3generatedmanifestdescriptor-location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JobManifestLocation
            /// </summary>
            public Humidifier.S3.JobTypes.JobManifestLocation Location { get; set; }
        }

        public class S3Grant : Humidifier.Base.BaseSubResource, IHavePermission
        {
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3grant.html#cfn-s3-job-s3grant-permission
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Permission { get; set; }
            /// <summary>
            /// Grantee
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3grant.html#cfn-s3-job-s3grant-grantee
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Grantee
            /// </summary>
            public Humidifier.S3.JobTypes.S3Grantee Grantee { get; set; }
        }

        public class S3Grantee : Humidifier.Base.BaseSubResource, IHaveDisplayName, IHaveIdentifier
        {
            /// <summary>
            /// TypeIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3grantee.html#cfn-s3-job-s3grantee-typeidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TypeIdentifier { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3grantee.html#cfn-s3-job-s3grantee-identifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3grantee.html#cfn-s3-job-s3grantee-displayname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayName { get; set; }
        }

        public class S3InitiateRestoreObjectOperation : Humidifier.Base.BaseSubResource, IHaveExpirationInDays
        {
            /// <summary>
            /// GlacierJobTier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3initiaterestoreobjectoperation.html#cfn-s3-job-s3initiaterestoreobjectoperation-glacierjobtier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GlacierJobTier { get; set; }
            /// <summary>
            /// ExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3initiaterestoreobjectoperation.html#cfn-s3-job-s3initiaterestoreobjectoperation-expirationindays
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ExpirationInDays { get; set; }
        }

        public class S3JobManifestGenerator : Humidifier.Base.BaseSubResource, IHaveExpectedBucketOwner
        {
            /// <summary>
            /// SourceBucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3jobmanifestgenerator.html#cfn-s3-job-s3jobmanifestgenerator-sourcebucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceBucket { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3jobmanifestgenerator.html#cfn-s3-job-s3jobmanifestgenerator-filter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: JobManifestGeneratorFilter
            /// </summary>
            public Humidifier.S3.JobTypes.JobManifestGeneratorFilter Filter { get; set; }
            /// <summary>
            /// ManifestOutputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3jobmanifestgenerator.html#cfn-s3-job-s3jobmanifestgenerator-manifestoutputlocation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3ManifestOutputLocation
            /// </summary>
            public Humidifier.S3.JobTypes.S3ManifestOutputLocation ManifestOutputLocation { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3jobmanifestgenerator.html#cfn-s3-job-s3jobmanifestgenerator-expectedbucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExpectedBucketOwner { get; set; }
            /// <summary>
            /// EnableManifestOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3jobmanifestgenerator.html#cfn-s3-job-s3jobmanifestgenerator-enablemanifestoutput
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableManifestOutput { get; set; }
        }

        public class S3ManifestOutputLocation : Humidifier.Base.BaseSubResource, IHaveBucket
        {
            /// <summary>
            /// ExpectedManifestBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3manifestoutputlocation.html#cfn-s3-job-s3manifestoutputlocation-expectedmanifestbucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExpectedManifestBucketOwner { get; set; }
            /// <summary>
            /// ManifestPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3manifestoutputlocation.html#cfn-s3-job-s3manifestoutputlocation-manifestprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestPrefix { get; set; }
            /// <summary>
            /// ManifestEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3manifestoutputlocation.html#cfn-s3-job-s3manifestoutputlocation-manifestencryption
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GeneratedManifestEncryption
            /// </summary>
            public Humidifier.S3.JobTypes.GeneratedManifestEncryption ManifestEncryption { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3manifestoutputlocation.html#cfn-s3-job-s3manifestoutputlocation-bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// ManifestFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3manifestoutputlocation.html#cfn-s3-job-s3manifestoutputlocation-manifestformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestFormat { get; set; }
        }

        public class S3ObjectLockLegalHold : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectlocklegalhold.html#cfn-s3-job-s3objectlocklegalhold-status
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
        }

        public class S3ObjectMetadata : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveSSEAlgorithm
        {
            /// <summary>
            /// ContentMD5
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contentmd5
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentMD5 { get; set; }
            /// <summary>
            /// RequesterCharged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-requestercharged
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequesterCharged { get; set; }
            /// <summary>
            /// ContentDisposition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contentdisposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentDisposition { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// HttpExpiresDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-httpexpiresdate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpExpiresDate { get; set; }
            /// <summary>
            /// SSEAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-ssealgorithm
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SSEAlgorithm { get; set; }
            /// <summary>
            /// UserMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-usermetadata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> UserMetadata { get; set; }
            /// <summary>
            /// ContentLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contentlanguage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentLanguage { get; set; }
            /// <summary>
            /// CacheControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-cachecontrol
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CacheControl { get; set; }
            /// <summary>
            /// ContentEncoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contentencoding
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentEncoding { get; set; }
            /// <summary>
            /// ContentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contentlength
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ContentLength { get; set; }
        }

        public class S3ObjectOwner : Humidifier.Base.BaseSubResource, IHaveDisplayName
        {
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectowner.html#cfn-s3-job-s3objectowner-displayname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayName { get; set; }
            /// <summary>
            /// ID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectowner.html#cfn-s3-job-s3objectowner-id
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ID { get; set; }
        }

        public class S3Retention : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3retention.html#cfn-s3-job-s3retention-mode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// RetainUntilDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3retention.html#cfn-s3-job-s3retention-retainuntildate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RetainUntilDate { get; set; }
        }

        public class S3SetObjectAclOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AccessControlPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3setobjectacloperation.html#cfn-s3-job-s3setobjectacloperation-accesscontrolpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3AccessControlPolicy
            /// </summary>
            public Humidifier.S3.JobTypes.S3AccessControlPolicy AccessControlPolicy { get; set; }
        }

        public class S3SetObjectLegalHoldOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LegalHold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3setobjectlegalholdoperation.html#cfn-s3-job-s3setobjectlegalholdoperation-legalhold
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3ObjectLockLegalHold
            /// </summary>
            public Humidifier.S3.JobTypes.S3ObjectLockLegalHold LegalHold { get; set; }
        }

        public class S3SetObjectRetentionOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BypassGovernanceRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3setobjectretentionoperation.html#cfn-s3-job-s3setobjectretentionoperation-bypassgovernanceretention
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BypassGovernanceRetention { get; set; }
            /// <summary>
            /// Retention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3setobjectretentionoperation.html#cfn-s3-job-s3setobjectretentionoperation-retention
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Retention
            /// </summary>
            public Humidifier.S3.JobTypes.S3Retention Retention { get; set; }
        }

        public class S3SetObjectTaggingOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TagSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3setobjecttaggingoperation.html#cfn-s3-job-s3setobjecttaggingoperation-tagset
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Humidifier.Tag> TagSet { get; set; }
        }

        public class S3UpdateObjectEncryptionOperation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ObjectEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3updateobjectencryptionoperation.html#cfn-s3-job-s3updateobjectencryptionoperation-objectencryption
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ObjectEncryption
            /// </summary>
            public Humidifier.S3.JobTypes.ObjectEncryption ObjectEncryption { get; set; }
        }

        public class S3UpdateObjectEncryptionSSEKMS : Humidifier.Base.BaseSubResource, IHaveKMSKeyArn, IHaveBucketKeyEnabled
        {
            /// <summary>
            /// BucketKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3updateobjectencryptionssekms.html#cfn-s3-job-s3updateobjectencryptionssekms-bucketkeyenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BucketKeyEnabled { get; set; }
            /// <summary>
            /// KMSKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3updateobjectencryptionssekms.html#cfn-s3-job-s3updateobjectencryptionssekms-kmskeyarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KMSKeyArn { get; set; }
        }

        public class SSEKMSEncryption : Humidifier.Base.BaseSubResource, IHaveKeyId
        {
            /// <summary>
            /// KeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-ssekmsencryption.html#cfn-s3-job-ssekmsencryption-keyid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyId { get; set; }
        }

        public class SSEKMSFilter : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveBucketKeyEnabled
        {
            /// <summary>
            /// BucketKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-ssekmsfilter.html#cfn-s3-job-ssekmsfilter-bucketkeyenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BucketKeyEnabled { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-ssekmsfilter.html#cfn-s3-job-ssekmsfilter-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
        }
    }
}