namespace Humidifier.Synthetics
{
    using global::System.Collections.Generic;
    using CanaryTypes;

    public class Canary : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfSyntheticsCanaryTypesBrowserConfigBrowserConfigs, IHaveListOfSyntheticsCanaryTypesVisualReferenceVisualReferences, IHaveSyntheticsCanaryTypesArtifactConfigArtifactConfig, IHaveSuccessRetentionPeriod_Integer, IHaveRuntimeVersion, IHaveSyntheticsCanaryTypesVPCConfigVPCConfig, IHaveSyntheticsCanaryTypesRunConfigRunConfig, IHaveDryRunAndUpdate_Boolean, IHaveFailureRetentionPeriod_Integer, IHaveListOfSyntheticsCanaryTypesReplicaReplicas, IHaveSyntheticsCanaryTypesCodeCode, IHaveStringListOfResourcesToReplicateTags, IHaveName, IHaveProvisionedResourceCleanup, IHaveExecutionRoleArn, IHaveKmsKeyArn, IHaveSyntheticsCanaryTypesScheduleSchedule, IHaveArtifactS3Location, IHaveStartCanaryAfterCreation_Boolean
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.Synthetics.Canary; }
        /// <summary>
        /// BrowserConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-browserconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BrowserConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Synthetics.CanaryTypes.BrowserConfig>, IReadOnlyList<Union<Humidifier.Synthetics.CanaryTypes.BrowserConfig, BaseFunction>>, BaseFunction>? BrowserConfigs { get; set; }
        /// <summary>
        /// VisualReferences
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-visualreferences
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VisualReference
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Synthetics.CanaryTypes.VisualReference>, IReadOnlyList<Union<Humidifier.Synthetics.CanaryTypes.VisualReference, BaseFunction>>, BaseFunction>? VisualReferences { get; set; }
        /// <summary>
        /// ArtifactConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-artifactconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ArtifactConfig
        /// </summary>
        public Union<Humidifier.Synthetics.CanaryTypes.ArtifactConfig, BaseFunction>? ArtifactConfig { get; set; }
        /// <summary>
        /// SuccessRetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-successretentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SuccessRetentionPeriod { get; set; }

        /// <summary>
        /// RuntimeVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-runtimeversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuntimeVersion { get; set; }
        /// <summary>
        /// VPCConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-vpcconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VPCConfig
        /// </summary>
        public Union<Humidifier.Synthetics.CanaryTypes.VPCConfig, BaseFunction>? VPCConfig { get; set; }
        /// <summary>
        /// RunConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-runconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RunConfig
        /// </summary>
        public Union<Humidifier.Synthetics.CanaryTypes.RunConfig, BaseFunction>? RunConfig { get; set; }
        /// <summary>
        /// DryRunAndUpdate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-dryrunandupdate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DryRunAndUpdate { get; set; }
        /// <summary>
        /// FailureRetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-failureretentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? FailureRetentionPeriod { get; set; }
        /// <summary>
        /// Replicas
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-replicas
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Replica
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Synthetics.CanaryTypes.Replica>, IReadOnlyList<Union<Humidifier.Synthetics.CanaryTypes.Replica, BaseFunction>>, BaseFunction>? Replicas { get; set; }

        /// <summary>
        /// Code
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-code
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Code
        /// </summary>
        [Required]
        public Union<Humidifier.Synthetics.CanaryTypes.Code, BaseFunction>? Code { get; set; }
        /// <summary>
        /// ResourcesToReplicateTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-resourcestoreplicatetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourcesToReplicateTags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ProvisionedResourceCleanup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-provisionedresourcecleanup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProvisionedResourceCleanup { get; set; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-executionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }

        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-schedule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        [Required]
        public Union<Humidifier.Synthetics.CanaryTypes.Schedule, BaseFunction>? Schedule { get; set; }

        /// <summary>
        /// ArtifactS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-artifacts3location
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ArtifactS3Location { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// StartCanaryAfterCreation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-synthetics-canary.html#cfn-synthetics-canary-startcanaryaftercreation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? StartCanaryAfterCreation { get; set; }
    }

    namespace CanaryTypes
    {
        public class ArtifactConfig : Humidifier.Base.BaseSubResource, IHaveSyntheticsCanaryTypesS3EncryptionS3Encryption
        {
            /// <summary>
            /// S3Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-artifactconfig.html#cfn-synthetics-canary-artifactconfig-s3encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Encryption
            /// </summary>
            public Union<Humidifier.Synthetics.CanaryTypes.S3Encryption, BaseFunction>? S3Encryption { get; set; }
        }

        public class BaseScreenshot : Humidifier.Base.BaseSubResource, IHaveStringListOfIgnoreCoordinates, IHaveScreenshotName
        {
            /// <summary>
            /// IgnoreCoordinates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-basescreenshot.html#cfn-synthetics-canary-basescreenshot-ignorecoordinates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IgnoreCoordinates { get; set; }
            /// <summary>
            /// ScreenshotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-basescreenshot.html#cfn-synthetics-canary-basescreenshot-screenshotname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScreenshotName { get; set; }
        }

        public class BrowserConfig : Humidifier.Base.BaseSubResource, IHaveBrowserType
        {
            /// <summary>
            /// BrowserType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-browserconfig.html#cfn-synthetics-canary-browserconfig-browsertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BrowserType { get; set; }
        }

        public class Code : Humidifier.Base.BaseSubResource, IHaveScript, IHaveS3ObjectVersion, IHaveS3Bucket, IHaveS3Key, IHaveStringListOfBlueprintTypes, IHaveHandler, IHaveSourceLocationArn, IHaveListOfSyntheticsCanaryTypesDependencyDependencies
        {
            /// <summary>
            /// Script
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-code.html#cfn-synthetics-canary-code-script
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Script { get; set; }
            /// <summary>
            /// S3ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-code.html#cfn-synthetics-canary-code-s3objectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ObjectVersion { get; set; }
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-code.html#cfn-synthetics-canary-code-s3bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-code.html#cfn-synthetics-canary-code-s3key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
            /// <summary>
            /// BlueprintTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-code.html#cfn-synthetics-canary-code-blueprinttypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? BlueprintTypes { get; set; }
            /// <summary>
            /// Handler
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-code.html#cfn-synthetics-canary-code-handler
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Handler { get; set; }
            /// <summary>
            /// SourceLocationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-code.html#cfn-synthetics-canary-code-sourcelocationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceLocationArn { get; set; }
            /// <summary>
            /// Dependencies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-code.html#cfn-synthetics-canary-code-dependencies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Dependency
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Synthetics.CanaryTypes.Dependency>, IReadOnlyList<Union<Humidifier.Synthetics.CanaryTypes.Dependency, BaseFunction>>, BaseFunction>? Dependencies { get; set; }
        }

        public class Dependency : Humidifier.Base.BaseSubResource, IHaveType, IHaveReference
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-dependency.html#cfn-synthetics-canary-dependency-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Reference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-dependency.html#cfn-synthetics-canary-dependency-reference
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Reference { get; set; }
        }

        public class Replica : Humidifier.Base.BaseSubResource, IHaveTags, IHaveLastModified_Double, IHaveKmsKeyArn, IHaveSyntheticsCanaryTypesVPCConfigVpcConfig, IHaveSyntheticsCanaryTypesReplicaReplicationStatusReplicationStatus, IHaveCanaryState, IHaveStringListOfResourcesToReplicateTags, IHaveLocation
        {
            /// <summary>
            /// LastModified
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-replica.html#cfn-synthetics-canary-replica-lastmodified
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LastModified { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-replica.html#cfn-synthetics-canary-replica-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-replica.html#cfn-synthetics-canary-replica-vpcconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VPCConfig
            /// </summary>
            public Union<Humidifier.Synthetics.CanaryTypes.VPCConfig, BaseFunction>? VpcConfig { get; set; }
            /// <summary>
            /// ReplicationStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-replica.html#cfn-synthetics-canary-replica-replicationstatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicaReplicationStatus
            /// </summary>
            public Union<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus, BaseFunction>? ReplicationStatus { get; set; }
            /// <summary>
            /// CanaryState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-replica.html#cfn-synthetics-canary-replica-canarystate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CanaryState { get; set; }
            /// <summary>
            /// ResourcesToReplicateTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-replica.html#cfn-synthetics-canary-replica-resourcestoreplicatetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourcesToReplicateTags { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-replica.html#cfn-synthetics-canary-replica-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-replica.html#cfn-synthetics-canary-replica-location
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }

        public class ReplicaReplicationStatus : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-replicareplicationstatus.html#cfn-synthetics-canary-replicareplicationstatus-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class RetryConfig : Humidifier.Base.BaseSubResource, IHaveMaxRetries_Integer
        {
            /// <summary>
            /// MaxRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-retryconfig.html#cfn-synthetics-canary-retryconfig-maxretries
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRetries { get; set; }
        }

        public class RunConfig : Humidifier.Base.BaseSubResource, IHaveTimeoutInSeconds_Integer, IHaveStringDictionaryOfEnvironmentVariables, IHaveMemoryInMB_Integer, IHaveEphemeralStorage_Integer, IHaveActiveTracing_Boolean
        {
            /// <summary>
            /// TimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-runconfig.html#cfn-synthetics-canary-runconfig-timeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInSeconds { get; set; }
            /// <summary>
            /// EnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-runconfig.html#cfn-synthetics-canary-runconfig-environmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
            /// <summary>
            /// MemoryInMB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-runconfig.html#cfn-synthetics-canary-runconfig-memoryinmb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MemoryInMB { get; set; }
            /// <summary>
            /// EphemeralStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-runconfig.html#cfn-synthetics-canary-runconfig-ephemeralstorage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EphemeralStorage { get; set; }
            /// <summary>
            /// ActiveTracing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-runconfig.html#cfn-synthetics-canary-runconfig-activetracing
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ActiveTracing { get; set; }
        }

        public class S3Encryption : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveEncryptionMode
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-s3encryption.html#cfn-synthetics-canary-s3encryption-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// EncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-s3encryption.html#cfn-synthetics-canary-s3encryption-encryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionMode { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveDurationInSeconds, IHaveSyntheticsCanaryTypesRetryConfigRetryConfig, IHaveExpression
        {
            /// <summary>
            /// DurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-schedule.html#cfn-synthetics-canary-schedule-durationinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DurationInSeconds { get; set; }
            /// <summary>
            /// RetryConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-schedule.html#cfn-synthetics-canary-schedule-retryconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetryConfig
            /// </summary>
            public Union<Humidifier.Synthetics.CanaryTypes.RetryConfig, BaseFunction>? RetryConfig { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-schedule.html#cfn-synthetics-canary-schedule-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class VPCConfig : Humidifier.Base.BaseSubResource, IHaveIpv6AllowedForDualStack_Boolean, IHaveVpcId, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Ipv6AllowedForDualStack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-vpcconfig.html#cfn-synthetics-canary-vpcconfig-ipv6allowedfordualstack
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Ipv6AllowedForDualStack { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-vpcconfig.html#cfn-synthetics-canary-vpcconfig-vpcid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-vpcconfig.html#cfn-synthetics-canary-vpcconfig-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-vpcconfig.html#cfn-synthetics-canary-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }

        public class VisualReference : Humidifier.Base.BaseSubResource, IHaveListOfSyntheticsCanaryTypesBaseScreenshotBaseScreenshots, IHaveBrowserType, IHaveBaseCanaryRunId
        {
            /// <summary>
            /// BaseScreenshots
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-visualreference.html#cfn-synthetics-canary-visualreference-basescreenshots
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BaseScreenshot
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Synthetics.CanaryTypes.BaseScreenshot>, IReadOnlyList<Union<Humidifier.Synthetics.CanaryTypes.BaseScreenshot, BaseFunction>>, BaseFunction>? BaseScreenshots { get; set; }
            /// <summary>
            /// BrowserType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-visualreference.html#cfn-synthetics-canary-visualreference-browsertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BrowserType { get; set; }
            /// <summary>
            /// BaseCanaryRunId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-visualreference.html#cfn-synthetics-canary-visualreference-basecanaryrunid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseCanaryRunId { get; set; }
        }
    }
}