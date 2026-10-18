namespace Humidifier.S3
{
    using global::System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveS3JobTypesJobManifestGeneratorManifestGenerator, IHaveS3JobTypesJobReportReport, IHavePriority_Integer, IHaveConfirmationRequired_Boolean, IHaveS3JobTypesJobOperationOperation, IHaveS3JobTypesJobManifestManifest, IHaveRoleArn
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
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ManifestGenerator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-manifestgenerator
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobManifestGenerator
        /// </summary>
        public Union<Humidifier.S3.JobTypes.JobManifestGenerator, BaseFunction>? ManifestGenerator { get; set; }

        /// <summary>
        /// Report
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-report
        /// Required: True
        /// UpdateType: Immutable
        /// Type: JobReport
        /// </summary>
        [Required]
        public Union<Humidifier.S3.JobTypes.JobReport, BaseFunction>? Report { get; set; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-priority
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// ConfirmationRequired
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-confirmationrequired
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ConfirmationRequired { get; set; }

        /// <summary>
        /// Operation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-operation
        /// Required: True
        /// UpdateType: Immutable
        /// Type: JobOperation
        /// </summary>
        [Required]
        public Union<Humidifier.S3.JobTypes.JobOperation, BaseFunction>? Operation { get; set; }
        /// <summary>
        /// Manifest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-manifest
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobManifest
        /// </summary>
        public Union<Humidifier.S3.JobTypes.JobManifest, BaseFunction>? Manifest { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-job.html#cfn-s3-job-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
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
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }

        public class GeneratedManifestEncryption : Humidifier.Base.BaseSubResource, IHaveS3JobTypesSSEKMSEncryptionSSEKMS, IHaveSSES3_Json
        {
            /// <summary>
            /// SSEKMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-generatedmanifestencryption.html#cfn-s3-job-generatedmanifestencryption-ssekms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SSEKMSEncryption
            /// </summary>
            public Union<Humidifier.S3.JobTypes.SSEKMSEncryption, BaseFunction>? SSEKMS { get; set; }
            /// <summary>
            /// SSES3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-generatedmanifestencryption.html#cfn-s3-job-generatedmanifestencryption-sses3
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? SSES3 { get; set; }
        }

        public class JobManifest : Humidifier.Base.BaseSubResource, IHaveS3JobTypesJobManifestSpecSpec, IHaveS3JobTypesJobManifestLocationLocation
        {
            /// <summary>
            /// Spec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifest.html#cfn-s3-job-jobmanifest-spec
            /// Required: True
            /// UpdateType: Immutable
            /// Type: JobManifestSpec
            /// </summary>
            public Union<Humidifier.S3.JobTypes.JobManifestSpec, BaseFunction>? Spec { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifest.html#cfn-s3-job-jobmanifest-location
            /// Required: True
            /// UpdateType: Immutable
            /// Type: JobManifestLocation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.JobManifestLocation, BaseFunction>? Location { get; set; }
        }

        public class JobManifestGenerator : Humidifier.Base.BaseSubResource, IHaveS3JobTypesS3JobManifestGeneratorS3JobManifestGenerator
        {
            /// <summary>
            /// S3JobManifestGenerator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgenerator.html#cfn-s3-job-jobmanifestgenerator-s3jobmanifestgenerator
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3JobManifestGenerator
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3JobManifestGenerator, BaseFunction>? S3JobManifestGenerator { get; set; }
        }

        public class JobManifestGeneratorFilter : Humidifier.Base.BaseSubResource, IHaveStringListOfObjectReplicationStatuses, IHaveStringListOfMatchAnyStorageClass, IHaveS3JobTypesKeyNameConstraintKeyNameConstraint, IHaveEligibleForReplication_Boolean, IHaveCreatedAfter, IHaveObjectSizeLessThanBytes_Integer, IHaveObjectSizeGreaterThanBytes_Integer, IHaveListOfS3JobTypesObjectEncryptionFilterMatchAnyObjectEncryption, IHaveCreatedBefore
        {
            /// <summary>
            /// ObjectReplicationStatuses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-objectreplicationstatuses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ObjectReplicationStatuses { get; set; }
            /// <summary>
            /// MatchAnyStorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-matchanystorageclass
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchAnyStorageClass { get; set; }
            /// <summary>
            /// KeyNameConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-keynameconstraint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KeyNameConstraint
            /// </summary>
            public Union<Humidifier.S3.JobTypes.KeyNameConstraint, BaseFunction>? KeyNameConstraint { get; set; }
            /// <summary>
            /// EligibleForReplication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-eligibleforreplication
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EligibleForReplication { get; set; }
            /// <summary>
            /// CreatedAfter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-createdafter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedAfter { get; set; }
            /// <summary>
            /// ObjectSizeLessThanBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-objectsizelessthanbytes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ObjectSizeLessThanBytes { get; set; }
            /// <summary>
            /// ObjectSizeGreaterThanBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-objectsizegreaterthanbytes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ObjectSizeGreaterThanBytes { get; set; }
            /// <summary>
            /// MatchAnyObjectEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-matchanyobjectencryption
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ObjectEncryptionFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.JobTypes.ObjectEncryptionFilter>, IReadOnlyList<Union<Humidifier.S3.JobTypes.ObjectEncryptionFilter, BaseFunction>>, BaseFunction>? MatchAnyObjectEncryption { get; set; }
            /// <summary>
            /// CreatedBefore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestgeneratorfilter.html#cfn-s3-job-jobmanifestgeneratorfilter-createdbefore
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedBefore { get; set; }
        }

        public class JobManifestLocation : Humidifier.Base.BaseSubResource, IHaveETag, IHaveObjectArn, IHaveObjectVersionId
        {
            /// <summary>
            /// ETag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestlocation.html#cfn-s3-job-jobmanifestlocation-etag
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ETag { get; set; }
            /// <summary>
            /// ObjectArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestlocation.html#cfn-s3-job-jobmanifestlocation-objectarn
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectArn { get; set; }
            /// <summary>
            /// ObjectVersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestlocation.html#cfn-s3-job-jobmanifestlocation-objectversionid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectVersionId { get; set; }
        }

        public class JobManifestSpec : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveStringListOfFields
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestspec.html#cfn-s3-job-jobmanifestspec-format
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobmanifestspec.html#cfn-s3-job-jobmanifestspec-fields
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Fields { get; set; }
        }

        public class JobOperation : Humidifier.Base.BaseSubResource, IHaveS3JobTypesS3ComputeObjectChecksumOperationS3ComputeObjectChecksum, IHaveS3JobTypesS3SetObjectLegalHoldOperationS3PutObjectLegalHold, IHaveS3JobTypesS3CopyObjectOperationS3PutObjectCopy, IHaveS3JobTypesS3SetObjectAclOperationS3PutObjectAcl, IHaveS3JobTypesLambdaInvokeOperationLambdaInvoke, IHaveS3JobTypesS3SetObjectRetentionOperationS3PutObjectRetention, IHaveS3JobTypesS3UpdateObjectEncryptionOperationS3UpdateObjectEncryption, IHaveS3DeleteObjectTagging_Json, IHaveS3ReplicateObject_Json, IHaveS3JobTypesS3InitiateRestoreObjectOperationS3InitiateRestoreObject, IHaveS3JobTypesS3SetObjectTaggingOperationS3PutObjectTagging
        {
            /// <summary>
            /// S3ComputeObjectChecksum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3computeobjectchecksum
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3ComputeObjectChecksumOperation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3ComputeObjectChecksumOperation, BaseFunction>? S3ComputeObjectChecksum { get; set; }
            /// <summary>
            /// S3PutObjectLegalHold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3putobjectlegalhold
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3SetObjectLegalHoldOperation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3SetObjectLegalHoldOperation, BaseFunction>? S3PutObjectLegalHold { get; set; }
            /// <summary>
            /// S3PutObjectCopy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3putobjectcopy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3CopyObjectOperation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3CopyObjectOperation, BaseFunction>? S3PutObjectCopy { get; set; }
            /// <summary>
            /// S3PutObjectAcl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3putobjectacl
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3SetObjectAclOperation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3SetObjectAclOperation, BaseFunction>? S3PutObjectAcl { get; set; }
            /// <summary>
            /// LambdaInvoke
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-lambdainvoke
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LambdaInvokeOperation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.LambdaInvokeOperation, BaseFunction>? LambdaInvoke { get; set; }
            /// <summary>
            /// S3PutObjectRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3putobjectretention
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3SetObjectRetentionOperation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3SetObjectRetentionOperation, BaseFunction>? S3PutObjectRetention { get; set; }
            /// <summary>
            /// S3UpdateObjectEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3updateobjectencryption
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3UpdateObjectEncryptionOperation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionOperation, BaseFunction>? S3UpdateObjectEncryption { get; set; }
            /// <summary>
            /// S3DeleteObjectTagging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3deleteobjecttagging
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? S3DeleteObjectTagging { get; set; }
            /// <summary>
            /// S3ReplicateObject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3replicateobject
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? S3ReplicateObject { get; set; }
            /// <summary>
            /// S3InitiateRestoreObject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3initiaterestoreobject
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3InitiateRestoreObjectOperation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3InitiateRestoreObjectOperation, BaseFunction>? S3InitiateRestoreObject { get; set; }
            /// <summary>
            /// S3PutObjectTagging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-joboperation.html#cfn-s3-job-joboperation-s3putobjecttagging
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3SetObjectTaggingOperation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3SetObjectTaggingOperation, BaseFunction>? S3PutObjectTagging { get; set; }
        }

        public class JobProgressSummary : Humidifier.Base.BaseSubResource, IHaveTotalNumberOfTasks_Integer, IHaveNumberOfTasksFailed_Integer, IHaveNumberOfTasksSucceeded_Integer, IHaveS3JobTypesJobTimersTimers
        {
            /// <summary>
            /// TotalNumberOfTasks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobprogresssummary.html#cfn-s3-job-jobprogresssummary-totalnumberoftasks
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TotalNumberOfTasks { get; set; }
            /// <summary>
            /// NumberOfTasksFailed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobprogresssummary.html#cfn-s3-job-jobprogresssummary-numberoftasksfailed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfTasksFailed { get; set; }
            /// <summary>
            /// NumberOfTasksSucceeded
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobprogresssummary.html#cfn-s3-job-jobprogresssummary-numberoftaskssucceeded
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfTasksSucceeded { get; set; }
            /// <summary>
            /// Timers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobprogresssummary.html#cfn-s3-job-jobprogresssummary-timers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JobTimers
            /// </summary>
            public Union<Humidifier.S3.JobTypes.JobTimers, BaseFunction>? Timers { get; set; }
        }

        public class JobReport : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveBucket, IHaveReportScope, IHaveEnabled_Boolean, IHavePrefix, IHaveExpectedBucketOwner
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-format
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// ReportScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-reportscope
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReportScope { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-prefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobreport.html#cfn-s3-job-jobreport-expectedbucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpectedBucketOwner { get; set; }
        }

        public class JobTimers : Humidifier.Base.BaseSubResource, IHaveElapsedTimeInActiveSeconds_Integer
        {
            /// <summary>
            /// ElapsedTimeInActiveSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-jobtimers.html#cfn-s3-job-jobtimers-elapsedtimeinactiveseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ElapsedTimeInActiveSeconds { get; set; }
        }

        public class KeyNameConstraint : Humidifier.Base.BaseSubResource, IHaveStringListOfMatchAnyPrefix, IHaveStringListOfMatchAnySubstring, IHaveStringListOfMatchAnySuffix
        {
            /// <summary>
            /// MatchAnyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-keynameconstraint.html#cfn-s3-job-keynameconstraint-matchanyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchAnyPrefix { get; set; }
            /// <summary>
            /// MatchAnySubstring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-keynameconstraint.html#cfn-s3-job-keynameconstraint-matchanysubstring
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchAnySubstring { get; set; }
            /// <summary>
            /// MatchAnySuffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-keynameconstraint.html#cfn-s3-job-keynameconstraint-matchanysuffix
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchAnySuffix { get; set; }
        }

        public class LambdaInvokeOperation : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfUserArguments, IHaveFunctionArn, IHaveInvocationSchemaVersion
        {
            /// <summary>
            /// UserArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-lambdainvokeoperation.html#cfn-s3-job-lambdainvokeoperation-userarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? UserArguments { get; set; }
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-lambdainvokeoperation.html#cfn-s3-job-lambdainvokeoperation-functionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionArn { get; set; }
            /// <summary>
            /// InvocationSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-lambdainvokeoperation.html#cfn-s3-job-lambdainvokeoperation-invocationschemaversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationSchemaVersion { get; set; }
        }

        public class ObjectEncryption : Humidifier.Base.BaseSubResource, IHaveS3JobTypesS3UpdateObjectEncryptionSSEKMSSSEKMS
        {
            /// <summary>
            /// SSEKMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryption.html#cfn-s3-job-objectencryption-ssekms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3UpdateObjectEncryptionSSEKMS
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS, BaseFunction>? SSEKMS { get; set; }
        }

        public class ObjectEncryptionFilter : Humidifier.Base.BaseSubResource, IHaveS3JobTypesSSEKMSFilterSSEKMS, IHaveSSEC_Json, IHaveNOTSSE_Json, IHaveS3JobTypesDSSEKMSFilterDSSEKMS, IHaveSSES3_Json
        {
            /// <summary>
            /// SSEKMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryptionfilter.html#cfn-s3-job-objectencryptionfilter-ssekms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SSEKMSFilter
            /// </summary>
            public Union<Humidifier.S3.JobTypes.SSEKMSFilter, BaseFunction>? SSEKMS { get; set; }
            /// <summary>
            /// SSEC
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryptionfilter.html#cfn-s3-job-objectencryptionfilter-ssec
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? SSEC { get; set; }
            /// <summary>
            /// NOTSSE
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryptionfilter.html#cfn-s3-job-objectencryptionfilter-notsse
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? NOTSSE { get; set; }
            /// <summary>
            /// DSSEKMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryptionfilter.html#cfn-s3-job-objectencryptionfilter-dssekms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DSSEKMSFilter
            /// </summary>
            public Union<Humidifier.S3.JobTypes.DSSEKMSFilter, BaseFunction>? DSSEKMS { get; set; }
            /// <summary>
            /// SSES3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-objectencryptionfilter.html#cfn-s3-job-objectencryptionfilter-sses3
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? SSES3 { get; set; }
        }

        public class S3AccessControlList : Humidifier.Base.BaseSubResource, IHaveS3JobTypesS3ObjectOwnerOwner, IHaveListOfS3JobTypesS3GrantGrants
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3accesscontrollist.html#cfn-s3-job-s3accesscontrollist-owner
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3ObjectOwner
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3ObjectOwner, BaseFunction>? Owner { get; set; }
            /// <summary>
            /// Grants
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3accesscontrollist.html#cfn-s3-job-s3accesscontrollist-grants
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: S3Grant
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.JobTypes.S3Grant>, IReadOnlyList<Union<Humidifier.S3.JobTypes.S3Grant, BaseFunction>>, BaseFunction>? Grants { get; set; }
        }

        public class S3AccessControlPolicy : Humidifier.Base.BaseSubResource, IHaveS3JobTypesS3AccessControlListAccessControlList, IHaveCannedAccessControlList
        {
            /// <summary>
            /// AccessControlList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3accesscontrolpolicy.html#cfn-s3-job-s3accesscontrolpolicy-accesscontrollist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3AccessControlList
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3AccessControlList, BaseFunction>? AccessControlList { get; set; }
            /// <summary>
            /// CannedAccessControlList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3accesscontrolpolicy.html#cfn-s3-job-s3accesscontrolpolicy-cannedaccesscontrollist
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CannedAccessControlList { get; set; }
        }

        public class S3ComputeObjectChecksumOperation : Humidifier.Base.BaseSubResource, IHaveChecksumAlgorithm, IHaveChecksumType
        {
            /// <summary>
            /// ChecksumAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3computeobjectchecksumoperation.html#cfn-s3-job-s3computeobjectchecksumoperation-checksumalgorithm
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChecksumAlgorithm { get; set; }
            /// <summary>
            /// ChecksumType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3computeobjectchecksumoperation.html#cfn-s3-job-s3computeobjectchecksumoperation-checksumtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChecksumType { get; set; }
        }

        public class S3CopyObjectOperation : Humidifier.Base.BaseSubResource, IHaveModifiedSinceConstraint, IHaveRedirectLocation, IHaveObjectLockLegalHoldStatus, IHaveListOfS3JobTypesS3GrantAccessControlGrants, IHaveSSEAwsKmsKeyId, IHaveStorageClass, IHaveChecksumAlgorithm, IHaveTargetKeyPrefix, IHaveCannedAccessControlList, IHaveS3JobTypesS3ObjectMetadataNewObjectMetadata, IHaveBucketKeyEnabled_Boolean, IHaveTargetResource, IHaveTagListOfNewObjectTagging, IHaveRequesterPays_Boolean, IHaveUnModifiedSinceConstraint, IHaveObjectLockRetainUntilDate, IHaveObjectLockMode, IHaveMetadataDirective
        {
            /// <summary>
            /// ModifiedSinceConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-modifiedsinceconstraint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModifiedSinceConstraint { get; set; }
            /// <summary>
            /// RedirectLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-redirectlocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedirectLocation { get; set; }
            /// <summary>
            /// ObjectLockLegalHoldStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-objectlocklegalholdstatus
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectLockLegalHoldStatus { get; set; }
            /// <summary>
            /// AccessControlGrants
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-accesscontrolgrants
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: S3Grant
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3.JobTypes.S3Grant>, IReadOnlyList<Union<Humidifier.S3.JobTypes.S3Grant, BaseFunction>>, BaseFunction>? AccessControlGrants { get; set; }
            /// <summary>
            /// SSEAwsKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-sseawskmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SSEAwsKmsKeyId { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-storageclass
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageClass { get; set; }
            /// <summary>
            /// ChecksumAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-checksumalgorithm
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChecksumAlgorithm { get; set; }
            /// <summary>
            /// TargetKeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-targetkeyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetKeyPrefix { get; set; }
            /// <summary>
            /// CannedAccessControlList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-cannedaccesscontrollist
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CannedAccessControlList { get; set; }
            /// <summary>
            /// NewObjectMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-newobjectmetadata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3ObjectMetadata
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3ObjectMetadata, BaseFunction>? NewObjectMetadata { get; set; }
            /// <summary>
            /// BucketKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-bucketkeyenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BucketKeyEnabled { get; set; }
            /// <summary>
            /// TargetResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-targetresource
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetResource { get; set; }
            /// <summary>
            /// NewObjectTagging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-newobjecttagging
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? NewObjectTagging { get; set; }
            /// <summary>
            /// RequesterPays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-requesterpays
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequesterPays { get; set; }
            /// <summary>
            /// UnModifiedSinceConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-unmodifiedsinceconstraint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnModifiedSinceConstraint { get; set; }
            /// <summary>
            /// ObjectLockRetainUntilDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-objectlockretainuntildate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectLockRetainUntilDate { get; set; }
            /// <summary>
            /// ObjectLockMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-objectlockmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectLockMode { get; set; }
            /// <summary>
            /// MetadataDirective
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3copyobjectoperation.html#cfn-s3-job-s3copyobjectoperation-metadatadirective
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetadataDirective { get; set; }
        }

        public class S3GeneratedManifestDescriptor : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveS3JobTypesJobManifestLocationLocation
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3generatedmanifestdescriptor.html#cfn-s3-job-s3generatedmanifestdescriptor-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3generatedmanifestdescriptor.html#cfn-s3-job-s3generatedmanifestdescriptor-location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JobManifestLocation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.JobManifestLocation, BaseFunction>? Location { get; set; }
        }

        public class S3Grant : Humidifier.Base.BaseSubResource, IHavePermission, IHaveS3JobTypesS3GranteeGrantee
        {
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3grant.html#cfn-s3-job-s3grant-permission
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Permission { get; set; }
            /// <summary>
            /// Grantee
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3grant.html#cfn-s3-job-s3grant-grantee
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Grantee
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3Grantee, BaseFunction>? Grantee { get; set; }
        }

        public class S3Grantee : Humidifier.Base.BaseSubResource, IHaveTypeIdentifier, IHaveIdentifier, IHaveDisplayName
        {
            /// <summary>
            /// TypeIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3grantee.html#cfn-s3-job-s3grantee-typeidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TypeIdentifier { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3grantee.html#cfn-s3-job-s3grantee-identifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3grantee.html#cfn-s3-job-s3grantee-displayname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisplayName { get; set; }
        }

        public class S3InitiateRestoreObjectOperation : Humidifier.Base.BaseSubResource, IHaveGlacierJobTier, IHaveExpirationInDays_Integer
        {
            /// <summary>
            /// GlacierJobTier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3initiaterestoreobjectoperation.html#cfn-s3-job-s3initiaterestoreobjectoperation-glacierjobtier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GlacierJobTier { get; set; }
            /// <summary>
            /// ExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3initiaterestoreobjectoperation.html#cfn-s3-job-s3initiaterestoreobjectoperation-expirationindays
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExpirationInDays { get; set; }
        }

        public class S3JobManifestGenerator : Humidifier.Base.BaseSubResource, IHaveSourceBucket, IHaveS3JobTypesJobManifestGeneratorFilterFilter, IHaveS3JobTypesS3ManifestOutputLocationManifestOutputLocation, IHaveExpectedBucketOwner, IHaveEnableManifestOutput_Boolean
        {
            /// <summary>
            /// SourceBucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3jobmanifestgenerator.html#cfn-s3-job-s3jobmanifestgenerator-sourcebucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceBucket { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3jobmanifestgenerator.html#cfn-s3-job-s3jobmanifestgenerator-filter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: JobManifestGeneratorFilter
            /// </summary>
            public Union<Humidifier.S3.JobTypes.JobManifestGeneratorFilter, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// ManifestOutputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3jobmanifestgenerator.html#cfn-s3-job-s3jobmanifestgenerator-manifestoutputlocation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3ManifestOutputLocation
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3ManifestOutputLocation, BaseFunction>? ManifestOutputLocation { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3jobmanifestgenerator.html#cfn-s3-job-s3jobmanifestgenerator-expectedbucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpectedBucketOwner { get; set; }
            /// <summary>
            /// EnableManifestOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3jobmanifestgenerator.html#cfn-s3-job-s3jobmanifestgenerator-enablemanifestoutput
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableManifestOutput { get; set; }
        }

        public class S3ManifestOutputLocation : Humidifier.Base.BaseSubResource, IHaveExpectedManifestBucketOwner, IHaveManifestPrefix, IHaveS3JobTypesGeneratedManifestEncryptionManifestEncryption, IHaveBucket, IHaveManifestFormat
        {
            /// <summary>
            /// ExpectedManifestBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3manifestoutputlocation.html#cfn-s3-job-s3manifestoutputlocation-expectedmanifestbucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpectedManifestBucketOwner { get; set; }
            /// <summary>
            /// ManifestPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3manifestoutputlocation.html#cfn-s3-job-s3manifestoutputlocation-manifestprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestPrefix { get; set; }
            /// <summary>
            /// ManifestEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3manifestoutputlocation.html#cfn-s3-job-s3manifestoutputlocation-manifestencryption
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GeneratedManifestEncryption
            /// </summary>
            public Union<Humidifier.S3.JobTypes.GeneratedManifestEncryption, BaseFunction>? ManifestEncryption { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3manifestoutputlocation.html#cfn-s3-job-s3manifestoutputlocation-bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// ManifestFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3manifestoutputlocation.html#cfn-s3-job-s3manifestoutputlocation-manifestformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestFormat { get; set; }
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
            public Union<string, BaseFunction>? Status { get; set; }
        }

        public class S3ObjectMetadata : Humidifier.Base.BaseSubResource, IHaveContentMD5, IHaveRequesterCharged_Boolean, IHaveContentDisposition, IHaveContentType, IHaveHttpExpiresDate, IHaveSSEAlgorithm, IHaveStringDictionaryOfUserMetadata, IHaveContentLanguage, IHaveCacheControl, IHaveContentEncoding, IHaveContentLength_Integer
        {
            /// <summary>
            /// ContentMD5
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contentmd5
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentMD5 { get; set; }
            /// <summary>
            /// RequesterCharged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-requestercharged
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequesterCharged { get; set; }
            /// <summary>
            /// ContentDisposition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contentdisposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentDisposition { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// HttpExpiresDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-httpexpiresdate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpExpiresDate { get; set; }
            /// <summary>
            /// SSEAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-ssealgorithm
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SSEAlgorithm { get; set; }
            /// <summary>
            /// UserMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-usermetadata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? UserMetadata { get; set; }
            /// <summary>
            /// ContentLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contentlanguage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentLanguage { get; set; }
            /// <summary>
            /// CacheControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-cachecontrol
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CacheControl { get; set; }
            /// <summary>
            /// ContentEncoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contentencoding
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentEncoding { get; set; }
            /// <summary>
            /// ContentLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectmetadata.html#cfn-s3-job-s3objectmetadata-contentlength
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ContentLength { get; set; }
        }

        public class S3ObjectOwner : Humidifier.Base.BaseSubResource, IHaveDisplayName, IHaveID
        {
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectowner.html#cfn-s3-job-s3objectowner-displayname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisplayName { get; set; }
            /// <summary>
            /// ID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3objectowner.html#cfn-s3-job-s3objectowner-id
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ID { get; set; }
        }

        public class S3Retention : Humidifier.Base.BaseSubResource, IHaveMode, IHaveRetainUntilDate
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3retention.html#cfn-s3-job-s3retention-mode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// RetainUntilDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3retention.html#cfn-s3-job-s3retention-retainuntildate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RetainUntilDate { get; set; }
        }

        public class S3SetObjectAclOperation : Humidifier.Base.BaseSubResource, IHaveS3JobTypesS3AccessControlPolicyAccessControlPolicy
        {
            /// <summary>
            /// AccessControlPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3setobjectacloperation.html#cfn-s3-job-s3setobjectacloperation-accesscontrolpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3AccessControlPolicy
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3AccessControlPolicy, BaseFunction>? AccessControlPolicy { get; set; }
        }

        public class S3SetObjectLegalHoldOperation : Humidifier.Base.BaseSubResource, IHaveS3JobTypesS3ObjectLockLegalHoldLegalHold
        {
            /// <summary>
            /// LegalHold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3setobjectlegalholdoperation.html#cfn-s3-job-s3setobjectlegalholdoperation-legalhold
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3ObjectLockLegalHold
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3ObjectLockLegalHold, BaseFunction>? LegalHold { get; set; }
        }

        public class S3SetObjectRetentionOperation : Humidifier.Base.BaseSubResource, IHaveBypassGovernanceRetention_Boolean, IHaveS3JobTypesS3RetentionRetention
        {
            /// <summary>
            /// BypassGovernanceRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3setobjectretentionoperation.html#cfn-s3-job-s3setobjectretentionoperation-bypassgovernanceretention
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BypassGovernanceRetention { get; set; }
            /// <summary>
            /// Retention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3setobjectretentionoperation.html#cfn-s3-job-s3setobjectretentionoperation-retention
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Retention
            /// </summary>
            public Union<Humidifier.S3.JobTypes.S3Retention, BaseFunction>? Retention { get; set; }
        }

        public class S3SetObjectTaggingOperation : Humidifier.Base.BaseSubResource, IHaveTagListOfTagSet
        {
            /// <summary>
            /// TagSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3setobjecttaggingoperation.html#cfn-s3-job-s3setobjecttaggingoperation-tagset
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? TagSet { get; set; }
        }

        public class S3UpdateObjectEncryptionOperation : Humidifier.Base.BaseSubResource, IHaveS3JobTypesObjectEncryptionObjectEncryption
        {
            /// <summary>
            /// ObjectEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3updateobjectencryptionoperation.html#cfn-s3-job-s3updateobjectencryptionoperation-objectencryption
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ObjectEncryption
            /// </summary>
            public Union<Humidifier.S3.JobTypes.ObjectEncryption, BaseFunction>? ObjectEncryption { get; set; }
        }

        public class S3UpdateObjectEncryptionSSEKMS : Humidifier.Base.BaseSubResource, IHaveBucketKeyEnabled_Boolean, IHaveKMSKeyArn
        {
            /// <summary>
            /// BucketKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3updateobjectencryptionssekms.html#cfn-s3-job-s3updateobjectencryptionssekms-bucketkeyenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BucketKeyEnabled { get; set; }
            /// <summary>
            /// KMSKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-s3updateobjectencryptionssekms.html#cfn-s3-job-s3updateobjectencryptionssekms-kmskeyarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KMSKeyArn { get; set; }
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
            public Union<string, BaseFunction>? KeyId { get; set; }
        }

        public class SSEKMSFilter : Humidifier.Base.BaseSubResource, IHaveBucketKeyEnabled_Boolean, IHaveKmsKeyArn
        {
            /// <summary>
            /// BucketKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-ssekmsfilter.html#cfn-s3-job-ssekmsfilter-bucketkeyenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BucketKeyEnabled { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-job-ssekmsfilter.html#cfn-s3-job-ssekmsfilter-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }
    }
}