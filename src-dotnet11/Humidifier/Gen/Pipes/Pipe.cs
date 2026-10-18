namespace Humidifier.Pipes
{
    using global::System.Collections.Generic;
    using PipeTypes;

    public class Pipe : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveEnrichment, IHaveKmsKeyIdentifier, IHaveDescription, IHavePipesPipeTypesPipeTargetParametersTargetParameters, IHavePipesPipeTypesPipeLogConfigurationLogConfiguration, IHavePipesPipeTypesPipeEnrichmentParametersEnrichmentParameters, IHaveRoleArn, IHaveSource, IHaveName, IHaveTarget, IHaveDesiredState, IHavePipesPipeTypesPipeSourceParametersSourceParameters, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string StateReason =  "StateReason" ;
            public static string CurrentState =  "CurrentState" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Pipes.Pipe; }
        /// <summary>
        /// Enrichment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-enrichment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Enrichment { get; set; }
        /// <summary>
        /// KmsKeyIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-kmskeyidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// TargetParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-targetparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PipeTargetParameters
        /// </summary>
        public Union<Humidifier.Pipes.PipeTypes.PipeTargetParameters, BaseFunction>? TargetParameters { get; set; }
        /// <summary>
        /// LogConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-logconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PipeLogConfiguration
        /// </summary>
        public Union<Humidifier.Pipes.PipeTypes.PipeLogConfiguration, BaseFunction>? LogConfiguration { get; set; }
        /// <summary>
        /// EnrichmentParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-enrichmentparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PipeEnrichmentParameters
        /// </summary>
        public Union<Humidifier.Pipes.PipeTypes.PipeEnrichmentParameters, BaseFunction>? EnrichmentParameters { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-source
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Source { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Target
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-target
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Target { get; set; }
        /// <summary>
        /// DesiredState
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-desiredstate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DesiredState { get; set; }
        /// <summary>
        /// SourceParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-sourceparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PipeSourceParameters
        /// </summary>
        public Union<Humidifier.Pipes.PipeTypes.PipeSourceParameters, BaseFunction>? SourceParameters { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pipes-pipe.html#cfn-pipes-pipe-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PipeTypes
    {
        public class AwsVpcConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets, IHaveAssignPublicIp
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-awsvpcconfiguration.html#cfn-pipes-pipe-awsvpcconfiguration-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-awsvpcconfiguration.html#cfn-pipes-pipe-awsvpcconfiguration-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// AssignPublicIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-awsvpcconfiguration.html#cfn-pipes-pipe-awsvpcconfiguration-assignpublicip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssignPublicIp { get; set; }
        }

        public class BatchArrayProperties : Humidifier.Base.BaseSubResource, IHaveSize_Integer
        {
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batcharrayproperties.html#cfn-pipes-pipe-batcharrayproperties-size
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Size { get; set; }
        }

        public class BatchContainerOverrides : Humidifier.Base.BaseSubResource, IHaveStringListOfCommand, IHaveListOfPipesPipeTypesBatchEnvironmentVariableEnvironment, IHaveInstanceType, IHaveListOfPipesPipeTypesBatchResourceRequirementResourceRequirements
        {
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batchcontaineroverrides.html#cfn-pipes-pipe-batchcontaineroverrides-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Command { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batchcontaineroverrides.html#cfn-pipes-pipe-batchcontaineroverrides-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BatchEnvironmentVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.BatchEnvironmentVariable>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.BatchEnvironmentVariable, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batchcontaineroverrides.html#cfn-pipes-pipe-batchcontaineroverrides-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// ResourceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batchcontaineroverrides.html#cfn-pipes-pipe-batchcontaineroverrides-resourcerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BatchResourceRequirement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.BatchResourceRequirement>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.BatchResourceRequirement, BaseFunction>>, BaseFunction>? ResourceRequirements { get; set; }
        }

        public class BatchEnvironmentVariable : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batchenvironmentvariable.html#cfn-pipes-pipe-batchenvironmentvariable-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batchenvironmentvariable.html#cfn-pipes-pipe-batchenvironmentvariable-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class BatchJobDependency : Humidifier.Base.BaseSubResource, IHaveType, IHaveJobId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batchjobdependency.html#cfn-pipes-pipe-batchjobdependency-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// JobId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batchjobdependency.html#cfn-pipes-pipe-batchjobdependency-jobid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JobId { get; set; }
        }

        public class BatchResourceRequirement : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batchresourcerequirement.html#cfn-pipes-pipe-batchresourcerequirement-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batchresourcerequirement.html#cfn-pipes-pipe-batchresourcerequirement-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class BatchRetryStrategy : Humidifier.Base.BaseSubResource, IHaveAttempts_Integer
        {
            /// <summary>
            /// Attempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-batchretrystrategy.html#cfn-pipes-pipe-batchretrystrategy-attempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Attempts { get; set; }
        }

        public class CapacityProviderStrategyItem : Humidifier.Base.BaseSubResource, IHaveCapacityProvider, IHaveWeight_Integer, IHaveBase_Integer
        {
            /// <summary>
            /// CapacityProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-capacityproviderstrategyitem.html#cfn-pipes-pipe-capacityproviderstrategyitem-capacityprovider
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProvider { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-capacityproviderstrategyitem.html#cfn-pipes-pipe-capacityproviderstrategyitem-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-capacityproviderstrategyitem.html#cfn-pipes-pipe-capacityproviderstrategyitem-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Base { get; set; }
        }

        public class CloudwatchLogsLogDestination : Humidifier.Base.BaseSubResource, IHaveLogGroupArn
        {
            /// <summary>
            /// LogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-cloudwatchlogslogdestination.html#cfn-pipes-pipe-cloudwatchlogslogdestination-loggrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupArn { get; set; }
        }

        public class DeadLetterConfig : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-deadletterconfig.html#cfn-pipes-pipe-deadletterconfig-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class DimensionMapping : Humidifier.Base.BaseSubResource, IHaveDimensionValueType, IHaveDimensionValue, IHaveDimensionName
        {
            /// <summary>
            /// DimensionValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-dimensionmapping.html#cfn-pipes-pipe-dimensionmapping-dimensionvaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DimensionValueType { get; set; }
            /// <summary>
            /// DimensionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-dimensionmapping.html#cfn-pipes-pipe-dimensionmapping-dimensionvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DimensionValue { get; set; }
            /// <summary>
            /// DimensionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-dimensionmapping.html#cfn-pipes-pipe-dimensionmapping-dimensionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DimensionName { get; set; }
        }

        public class EcsContainerOverride : Humidifier.Base.BaseSubResource, IHaveMemoryReservation_Integer, IHaveStringListOfCommand, IHaveMemory_Integer, IHaveCpu_Integer, IHaveListOfPipesPipeTypesEcsEnvironmentVariableEnvironment, IHaveListOfPipesPipeTypesEcsResourceRequirementResourceRequirements, IHaveListOfPipesPipeTypesEcsEnvironmentFileEnvironmentFiles, IHaveName
        {
            /// <summary>
            /// MemoryReservation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecscontaineroverride.html#cfn-pipes-pipe-ecscontaineroverride-memoryreservation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MemoryReservation { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecscontaineroverride.html#cfn-pipes-pipe-ecscontaineroverride-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Command { get; set; }
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecscontaineroverride.html#cfn-pipes-pipe-ecscontaineroverride-memory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Memory { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecscontaineroverride.html#cfn-pipes-pipe-ecscontaineroverride-cpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Cpu { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecscontaineroverride.html#cfn-pipes-pipe-ecscontaineroverride-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EcsEnvironmentVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.EcsEnvironmentVariable>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.EcsEnvironmentVariable, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// ResourceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecscontaineroverride.html#cfn-pipes-pipe-ecscontaineroverride-resourcerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EcsResourceRequirement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.EcsResourceRequirement>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.EcsResourceRequirement, BaseFunction>>, BaseFunction>? ResourceRequirements { get; set; }
            /// <summary>
            /// EnvironmentFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecscontaineroverride.html#cfn-pipes-pipe-ecscontaineroverride-environmentfiles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EcsEnvironmentFile
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.EcsEnvironmentFile>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.EcsEnvironmentFile, BaseFunction>>, BaseFunction>? EnvironmentFiles { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecscontaineroverride.html#cfn-pipes-pipe-ecscontaineroverride-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class EcsEnvironmentFile : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecsenvironmentfile.html#cfn-pipes-pipe-ecsenvironmentfile-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecsenvironmentfile.html#cfn-pipes-pipe-ecsenvironmentfile-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class EcsEnvironmentVariable : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecsenvironmentvariable.html#cfn-pipes-pipe-ecsenvironmentvariable-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecsenvironmentvariable.html#cfn-pipes-pipe-ecsenvironmentvariable-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class EcsEphemeralStorage : Humidifier.Base.BaseSubResource, IHaveSizeInGiB_Integer
        {
            /// <summary>
            /// SizeInGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecsephemeralstorage.html#cfn-pipes-pipe-ecsephemeralstorage-sizeingib
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeInGiB { get; set; }
        }

        public class EcsInferenceAcceleratorOverride : Humidifier.Base.BaseSubResource, IHaveDeviceType, IHaveDeviceName
        {
            /// <summary>
            /// DeviceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecsinferenceacceleratoroverride.html#cfn-pipes-pipe-ecsinferenceacceleratoroverride-devicetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceType { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecsinferenceacceleratoroverride.html#cfn-pipes-pipe-ecsinferenceacceleratoroverride-devicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }

        public class EcsResourceRequirement : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecsresourcerequirement.html#cfn-pipes-pipe-ecsresourcerequirement-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecsresourcerequirement.html#cfn-pipes-pipe-ecsresourcerequirement-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class EcsTaskOverride : Humidifier.Base.BaseSubResource, IHaveExecutionRoleArn, IHaveTaskRoleArn, IHaveMemory, IHaveCpu, IHaveListOfPipesPipeTypesEcsInferenceAcceleratorOverrideInferenceAcceleratorOverrides, IHavePipesPipeTypesEcsEphemeralStorageEphemeralStorage, IHaveListOfPipesPipeTypesEcsContainerOverrideContainerOverrides
        {
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecstaskoverride.html#cfn-pipes-pipe-ecstaskoverride-executionrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
            /// <summary>
            /// TaskRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecstaskoverride.html#cfn-pipes-pipe-ecstaskoverride-taskrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskRoleArn { get; set; }
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecstaskoverride.html#cfn-pipes-pipe-ecstaskoverride-memory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Memory { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecstaskoverride.html#cfn-pipes-pipe-ecstaskoverride-cpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cpu { get; set; }
            /// <summary>
            /// InferenceAcceleratorOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecstaskoverride.html#cfn-pipes-pipe-ecstaskoverride-inferenceacceleratoroverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EcsInferenceAcceleratorOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.EcsInferenceAcceleratorOverride>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.EcsInferenceAcceleratorOverride, BaseFunction>>, BaseFunction>? InferenceAcceleratorOverrides { get; set; }
            /// <summary>
            /// EphemeralStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecstaskoverride.html#cfn-pipes-pipe-ecstaskoverride-ephemeralstorage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcsEphemeralStorage
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage, BaseFunction>? EphemeralStorage { get; set; }
            /// <summary>
            /// ContainerOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-ecstaskoverride.html#cfn-pipes-pipe-ecstaskoverride-containeroverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EcsContainerOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.EcsContainerOverride>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.EcsContainerOverride, BaseFunction>>, BaseFunction>? ContainerOverrides { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHavePattern
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-filter.html#cfn-pipes-pipe-filter-pattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pattern { get; set; }
        }

        public class FilterCriteria : Humidifier.Base.BaseSubResource, IHaveListOfPipesPipeTypesFilterFilters
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-filtercriteria.html#cfn-pipes-pipe-filtercriteria-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.Filter>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.Filter, BaseFunction>>, BaseFunction>? Filters { get; set; }
        }

        public class FirehoseLogDestination : Humidifier.Base.BaseSubResource, IHaveDeliveryStreamArn
        {
            /// <summary>
            /// DeliveryStreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-firehoselogdestination.html#cfn-pipes-pipe-firehoselogdestination-deliverystreamarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStreamArn { get; set; }
        }

        public class MQBrokerAccessCredentials : Humidifier.Base.BaseSubResource, IHaveBasicAuth
        {
            /// <summary>
            /// BasicAuth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-mqbrokeraccesscredentials.html#cfn-pipes-pipe-mqbrokeraccesscredentials-basicauth
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BasicAuth { get; set; }
        }

        public class MSKAccessCredentials : Humidifier.Base.BaseSubResource, IHaveClientCertificateTlsAuth, IHaveSaslScram512Auth
        {
            /// <summary>
            /// ClientCertificateTlsAuth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-mskaccesscredentials.html#cfn-pipes-pipe-mskaccesscredentials-clientcertificatetlsauth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientCertificateTlsAuth { get; set; }
            /// <summary>
            /// SaslScram512Auth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-mskaccesscredentials.html#cfn-pipes-pipe-mskaccesscredentials-saslscram512auth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SaslScram512Auth { get; set; }
        }

        public class MultiMeasureAttributeMapping : Humidifier.Base.BaseSubResource, IHaveMultiMeasureAttributeName, IHaveMeasureValueType, IHaveMeasureValue
        {
            /// <summary>
            /// MultiMeasureAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-multimeasureattributemapping.html#cfn-pipes-pipe-multimeasureattributemapping-multimeasureattributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MultiMeasureAttributeName { get; set; }
            /// <summary>
            /// MeasureValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-multimeasureattributemapping.html#cfn-pipes-pipe-multimeasureattributemapping-measurevaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MeasureValueType { get; set; }
            /// <summary>
            /// MeasureValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-multimeasureattributemapping.html#cfn-pipes-pipe-multimeasureattributemapping-measurevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MeasureValue { get; set; }
        }

        public class MultiMeasureMapping : Humidifier.Base.BaseSubResource, IHaveMultiMeasureName, IHaveListOfPipesPipeTypesMultiMeasureAttributeMappingMultiMeasureAttributeMappings
        {
            /// <summary>
            /// MultiMeasureName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-multimeasuremapping.html#cfn-pipes-pipe-multimeasuremapping-multimeasurename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MultiMeasureName { get; set; }
            /// <summary>
            /// MultiMeasureAttributeMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-multimeasuremapping.html#cfn-pipes-pipe-multimeasuremapping-multimeasureattributemappings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MultiMeasureAttributeMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.MultiMeasureAttributeMapping>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.MultiMeasureAttributeMapping, BaseFunction>>, BaseFunction>? MultiMeasureAttributeMappings { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHavePipesPipeTypesAwsVpcConfigurationAwsvpcConfiguration
        {
            /// <summary>
            /// AwsvpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-networkconfiguration.html#cfn-pipes-pipe-networkconfiguration-awsvpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsVpcConfiguration
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration, BaseFunction>? AwsvpcConfiguration { get; set; }
        }

        public class PipeEnrichmentHttpParameters : Humidifier.Base.BaseSubResource, IHaveStringListOfPathParameterValues, IHaveStringDictionaryOfHeaderParameters, IHaveStringDictionaryOfQueryStringParameters
        {
            /// <summary>
            /// PathParameterValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipeenrichmenthttpparameters.html#cfn-pipes-pipe-pipeenrichmenthttpparameters-pathparametervalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PathParameterValues { get; set; }
            /// <summary>
            /// HeaderParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipeenrichmenthttpparameters.html#cfn-pipes-pipe-pipeenrichmenthttpparameters-headerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? HeaderParameters { get; set; }
            /// <summary>
            /// QueryStringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipeenrichmenthttpparameters.html#cfn-pipes-pipe-pipeenrichmenthttpparameters-querystringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? QueryStringParameters { get; set; }
        }

        public class PipeEnrichmentParameters : Humidifier.Base.BaseSubResource, IHavePipesPipeTypesPipeEnrichmentHttpParametersHttpParameters, IHaveInputTemplate
        {
            /// <summary>
            /// HttpParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipeenrichmentparameters.html#cfn-pipes-pipe-pipeenrichmentparameters-httpparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeEnrichmentHttpParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters, BaseFunction>? HttpParameters { get; set; }
            /// <summary>
            /// InputTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipeenrichmentparameters.html#cfn-pipes-pipe-pipeenrichmentparameters-inputtemplate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputTemplate { get; set; }
        }

        public class PipeLogConfiguration : Humidifier.Base.BaseSubResource, IHavePipesPipeTypesFirehoseLogDestinationFirehoseLogDestination, IHavePipesPipeTypesCloudwatchLogsLogDestinationCloudwatchLogsLogDestination, IHaveStringListOfIncludeExecutionData, IHavePipesPipeTypesS3LogDestinationS3LogDestination, IHaveLevel
        {
            /// <summary>
            /// FirehoseLogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipelogconfiguration.html#cfn-pipes-pipe-pipelogconfiguration-firehoselogdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FirehoseLogDestination
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.FirehoseLogDestination, BaseFunction>? FirehoseLogDestination { get; set; }
            /// <summary>
            /// CloudwatchLogsLogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipelogconfiguration.html#cfn-pipes-pipe-pipelogconfiguration-cloudwatchlogslogdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudwatchLogsLogDestination
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.CloudwatchLogsLogDestination, BaseFunction>? CloudwatchLogsLogDestination { get; set; }
            /// <summary>
            /// IncludeExecutionData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipelogconfiguration.html#cfn-pipes-pipe-pipelogconfiguration-includeexecutiondata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludeExecutionData { get; set; }
            /// <summary>
            /// S3LogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipelogconfiguration.html#cfn-pipes-pipe-pipelogconfiguration-s3logdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3LogDestination
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.S3LogDestination, BaseFunction>? S3LogDestination { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipelogconfiguration.html#cfn-pipes-pipe-pipelogconfiguration-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Level { get; set; }
        }

        public class PipeSourceActiveMQBrokerParameters : Humidifier.Base.BaseSubResource, IHaveBatchSize_Integer, IHaveQueueName, IHavePipesPipeTypesMQBrokerAccessCredentialsCredentials, IHaveMaximumBatchingWindowInSeconds_Integer
        {
            /// <summary>
            /// BatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceactivemqbrokerparameters.html#cfn-pipes-pipe-pipesourceactivemqbrokerparameters-batchsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BatchSize { get; set; }
            /// <summary>
            /// QueueName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceactivemqbrokerparameters.html#cfn-pipes-pipe-pipesourceactivemqbrokerparameters-queuename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueueName { get; set; }
            /// <summary>
            /// Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceactivemqbrokerparameters.html#cfn-pipes-pipe-pipesourceactivemqbrokerparameters-credentials
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MQBrokerAccessCredentials
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials, BaseFunction>? Credentials { get; set; }
            /// <summary>
            /// MaximumBatchingWindowInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceactivemqbrokerparameters.html#cfn-pipes-pipe-pipesourceactivemqbrokerparameters-maximumbatchingwindowinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumBatchingWindowInSeconds { get; set; }
        }

        public class PipeSourceDynamoDBStreamParameters : Humidifier.Base.BaseSubResource, IHaveStartingPosition, IHaveBatchSize_Integer, IHaveMaximumRetryAttempts_Integer, IHaveOnPartialBatchItemFailure, IHavePipesPipeTypesDeadLetterConfigDeadLetterConfig, IHaveParallelizationFactor_Integer, IHaveMaximumRecordAgeInSeconds_Integer, IHaveMaximumBatchingWindowInSeconds_Integer
        {
            /// <summary>
            /// StartingPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcedynamodbstreamparameters.html#cfn-pipes-pipe-pipesourcedynamodbstreamparameters-startingposition
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartingPosition { get; set; }
            /// <summary>
            /// BatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcedynamodbstreamparameters.html#cfn-pipes-pipe-pipesourcedynamodbstreamparameters-batchsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BatchSize { get; set; }
            /// <summary>
            /// MaximumRetryAttempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcedynamodbstreamparameters.html#cfn-pipes-pipe-pipesourcedynamodbstreamparameters-maximumretryattempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumRetryAttempts { get; set; }
            /// <summary>
            /// OnPartialBatchItemFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcedynamodbstreamparameters.html#cfn-pipes-pipe-pipesourcedynamodbstreamparameters-onpartialbatchitemfailure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnPartialBatchItemFailure { get; set; }
            /// <summary>
            /// DeadLetterConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcedynamodbstreamparameters.html#cfn-pipes-pipe-pipesourcedynamodbstreamparameters-deadletterconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeadLetterConfig
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.DeadLetterConfig, BaseFunction>? DeadLetterConfig { get; set; }
            /// <summary>
            /// ParallelizationFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcedynamodbstreamparameters.html#cfn-pipes-pipe-pipesourcedynamodbstreamparameters-parallelizationfactor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParallelizationFactor { get; set; }
            /// <summary>
            /// MaximumRecordAgeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcedynamodbstreamparameters.html#cfn-pipes-pipe-pipesourcedynamodbstreamparameters-maximumrecordageinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumRecordAgeInSeconds { get; set; }
            /// <summary>
            /// MaximumBatchingWindowInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcedynamodbstreamparameters.html#cfn-pipes-pipe-pipesourcedynamodbstreamparameters-maximumbatchingwindowinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumBatchingWindowInSeconds { get; set; }
        }

        public class PipeSourceKinesisStreamParameters : Humidifier.Base.BaseSubResource, IHaveStartingPosition, IHaveBatchSize_Integer, IHaveMaximumRetryAttempts_Integer, IHaveOnPartialBatchItemFailure, IHavePipesPipeTypesDeadLetterConfigDeadLetterConfig, IHaveParallelizationFactor_Integer, IHaveMaximumRecordAgeInSeconds_Integer, IHaveStartingPositionTimestamp, IHaveMaximumBatchingWindowInSeconds_Integer
        {
            /// <summary>
            /// StartingPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcekinesisstreamparameters.html#cfn-pipes-pipe-pipesourcekinesisstreamparameters-startingposition
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartingPosition { get; set; }
            /// <summary>
            /// BatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcekinesisstreamparameters.html#cfn-pipes-pipe-pipesourcekinesisstreamparameters-batchsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BatchSize { get; set; }
            /// <summary>
            /// MaximumRetryAttempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcekinesisstreamparameters.html#cfn-pipes-pipe-pipesourcekinesisstreamparameters-maximumretryattempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumRetryAttempts { get; set; }
            /// <summary>
            /// OnPartialBatchItemFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcekinesisstreamparameters.html#cfn-pipes-pipe-pipesourcekinesisstreamparameters-onpartialbatchitemfailure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnPartialBatchItemFailure { get; set; }
            /// <summary>
            /// DeadLetterConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcekinesisstreamparameters.html#cfn-pipes-pipe-pipesourcekinesisstreamparameters-deadletterconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeadLetterConfig
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.DeadLetterConfig, BaseFunction>? DeadLetterConfig { get; set; }
            /// <summary>
            /// ParallelizationFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcekinesisstreamparameters.html#cfn-pipes-pipe-pipesourcekinesisstreamparameters-parallelizationfactor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ParallelizationFactor { get; set; }
            /// <summary>
            /// MaximumRecordAgeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcekinesisstreamparameters.html#cfn-pipes-pipe-pipesourcekinesisstreamparameters-maximumrecordageinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumRecordAgeInSeconds { get; set; }
            /// <summary>
            /// StartingPositionTimestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcekinesisstreamparameters.html#cfn-pipes-pipe-pipesourcekinesisstreamparameters-startingpositiontimestamp
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartingPositionTimestamp { get; set; }
            /// <summary>
            /// MaximumBatchingWindowInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcekinesisstreamparameters.html#cfn-pipes-pipe-pipesourcekinesisstreamparameters-maximumbatchingwindowinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumBatchingWindowInSeconds { get; set; }
        }

        public class PipeSourceManagedStreamingKafkaParameters : Humidifier.Base.BaseSubResource, IHaveStartingPosition, IHaveBatchSize_Integer, IHaveConsumerGroupID, IHavePipesPipeTypesMSKAccessCredentialsCredentials, IHaveTopicName, IHaveMaximumBatchingWindowInSeconds_Integer
        {
            /// <summary>
            /// StartingPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcemanagedstreamingkafkaparameters.html#cfn-pipes-pipe-pipesourcemanagedstreamingkafkaparameters-startingposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartingPosition { get; set; }
            /// <summary>
            /// BatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcemanagedstreamingkafkaparameters.html#cfn-pipes-pipe-pipesourcemanagedstreamingkafkaparameters-batchsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BatchSize { get; set; }
            /// <summary>
            /// ConsumerGroupID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcemanagedstreamingkafkaparameters.html#cfn-pipes-pipe-pipesourcemanagedstreamingkafkaparameters-consumergroupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConsumerGroupID { get; set; }
            /// <summary>
            /// Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcemanagedstreamingkafkaparameters.html#cfn-pipes-pipe-pipesourcemanagedstreamingkafkaparameters-credentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MSKAccessCredentials
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.MSKAccessCredentials, BaseFunction>? Credentials { get; set; }
            /// <summary>
            /// TopicName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcemanagedstreamingkafkaparameters.html#cfn-pipes-pipe-pipesourcemanagedstreamingkafkaparameters-topicname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicName { get; set; }
            /// <summary>
            /// MaximumBatchingWindowInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcemanagedstreamingkafkaparameters.html#cfn-pipes-pipe-pipesourcemanagedstreamingkafkaparameters-maximumbatchingwindowinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumBatchingWindowInSeconds { get; set; }
        }

        public class PipeSourceParameters : Humidifier.Base.BaseSubResource, IHavePipesPipeTypesPipeSourceManagedStreamingKafkaParametersManagedStreamingKafkaParameters, IHavePipesPipeTypesPipeSourceDynamoDBStreamParametersDynamoDBStreamParameters, IHavePipesPipeTypesPipeSourceSelfManagedKafkaParametersSelfManagedKafkaParameters, IHavePipesPipeTypesPipeSourceRabbitMQBrokerParametersRabbitMQBrokerParameters, IHavePipesPipeTypesPipeSourceSqsQueueParametersSqsQueueParameters, IHavePipesPipeTypesPipeSourceKinesisStreamParametersKinesisStreamParameters, IHavePipesPipeTypesFilterCriteriaFilterCriteria, IHavePipesPipeTypesPipeSourceActiveMQBrokerParametersActiveMQBrokerParameters
        {
            /// <summary>
            /// ManagedStreamingKafkaParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceparameters.html#cfn-pipes-pipe-pipesourceparameters-managedstreamingkafkaparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeSourceManagedStreamingKafkaParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeSourceManagedStreamingKafkaParameters, BaseFunction>? ManagedStreamingKafkaParameters { get; set; }
            /// <summary>
            /// DynamoDBStreamParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceparameters.html#cfn-pipes-pipe-pipesourceparameters-dynamodbstreamparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeSourceDynamoDBStreamParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeSourceDynamoDBStreamParameters, BaseFunction>? DynamoDBStreamParameters { get; set; }
            /// <summary>
            /// SelfManagedKafkaParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceparameters.html#cfn-pipes-pipe-pipesourceparameters-selfmanagedkafkaparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeSourceSelfManagedKafkaParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeSourceSelfManagedKafkaParameters, BaseFunction>? SelfManagedKafkaParameters { get; set; }
            /// <summary>
            /// RabbitMQBrokerParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceparameters.html#cfn-pipes-pipe-pipesourceparameters-rabbitmqbrokerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeSourceRabbitMQBrokerParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeSourceRabbitMQBrokerParameters, BaseFunction>? RabbitMQBrokerParameters { get; set; }
            /// <summary>
            /// SqsQueueParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceparameters.html#cfn-pipes-pipe-pipesourceparameters-sqsqueueparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeSourceSqsQueueParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeSourceSqsQueueParameters, BaseFunction>? SqsQueueParameters { get; set; }
            /// <summary>
            /// KinesisStreamParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceparameters.html#cfn-pipes-pipe-pipesourceparameters-kinesisstreamparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeSourceKinesisStreamParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeSourceKinesisStreamParameters, BaseFunction>? KinesisStreamParameters { get; set; }
            /// <summary>
            /// FilterCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceparameters.html#cfn-pipes-pipe-pipesourceparameters-filtercriteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterCriteria
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.FilterCriteria, BaseFunction>? FilterCriteria { get; set; }
            /// <summary>
            /// ActiveMQBrokerParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceparameters.html#cfn-pipes-pipe-pipesourceparameters-activemqbrokerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeSourceActiveMQBrokerParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeSourceActiveMQBrokerParameters, BaseFunction>? ActiveMQBrokerParameters { get; set; }
        }

        public class PipeSourceRabbitMQBrokerParameters : Humidifier.Base.BaseSubResource, IHaveBatchSize_Integer, IHaveVirtualHost, IHaveQueueName, IHavePipesPipeTypesMQBrokerAccessCredentialsCredentials, IHaveMaximumBatchingWindowInSeconds_Integer
        {
            /// <summary>
            /// BatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcerabbitmqbrokerparameters.html#cfn-pipes-pipe-pipesourcerabbitmqbrokerparameters-batchsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BatchSize { get; set; }
            /// <summary>
            /// VirtualHost
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcerabbitmqbrokerparameters.html#cfn-pipes-pipe-pipesourcerabbitmqbrokerparameters-virtualhost
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualHost { get; set; }
            /// <summary>
            /// QueueName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcerabbitmqbrokerparameters.html#cfn-pipes-pipe-pipesourcerabbitmqbrokerparameters-queuename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueueName { get; set; }
            /// <summary>
            /// Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcerabbitmqbrokerparameters.html#cfn-pipes-pipe-pipesourcerabbitmqbrokerparameters-credentials
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MQBrokerAccessCredentials
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials, BaseFunction>? Credentials { get; set; }
            /// <summary>
            /// MaximumBatchingWindowInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcerabbitmqbrokerparameters.html#cfn-pipes-pipe-pipesourcerabbitmqbrokerparameters-maximumbatchingwindowinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumBatchingWindowInSeconds { get; set; }
        }

        public class PipeSourceSelfManagedKafkaParameters : Humidifier.Base.BaseSubResource, IHaveStartingPosition, IHaveBatchSize_Integer, IHaveConsumerGroupID, IHaveStringListOfAdditionalBootstrapServers, IHavePipesPipeTypesSelfManagedKafkaAccessConfigurationVpcVpc, IHavePipesPipeTypesSelfManagedKafkaAccessConfigurationCredentialsCredentials, IHaveServerRootCaCertificate, IHaveTopicName, IHaveMaximumBatchingWindowInSeconds_Integer
        {
            /// <summary>
            /// StartingPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceselfmanagedkafkaparameters.html#cfn-pipes-pipe-pipesourceselfmanagedkafkaparameters-startingposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartingPosition { get; set; }
            /// <summary>
            /// BatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceselfmanagedkafkaparameters.html#cfn-pipes-pipe-pipesourceselfmanagedkafkaparameters-batchsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BatchSize { get; set; }
            /// <summary>
            /// ConsumerGroupID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceselfmanagedkafkaparameters.html#cfn-pipes-pipe-pipesourceselfmanagedkafkaparameters-consumergroupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConsumerGroupID { get; set; }
            /// <summary>
            /// AdditionalBootstrapServers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceselfmanagedkafkaparameters.html#cfn-pipes-pipe-pipesourceselfmanagedkafkaparameters-additionalbootstrapservers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdditionalBootstrapServers { get; set; }
            /// <summary>
            /// Vpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceselfmanagedkafkaparameters.html#cfn-pipes-pipe-pipesourceselfmanagedkafkaparameters-vpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedKafkaAccessConfigurationVpc
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationVpc, BaseFunction>? Vpc { get; set; }
            /// <summary>
            /// Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceselfmanagedkafkaparameters.html#cfn-pipes-pipe-pipesourceselfmanagedkafkaparameters-credentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedKafkaAccessConfigurationCredentials
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationCredentials, BaseFunction>? Credentials { get; set; }
            /// <summary>
            /// ServerRootCaCertificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceselfmanagedkafkaparameters.html#cfn-pipes-pipe-pipesourceselfmanagedkafkaparameters-serverrootcacertificate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerRootCaCertificate { get; set; }
            /// <summary>
            /// TopicName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceselfmanagedkafkaparameters.html#cfn-pipes-pipe-pipesourceselfmanagedkafkaparameters-topicname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicName { get; set; }
            /// <summary>
            /// MaximumBatchingWindowInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourceselfmanagedkafkaparameters.html#cfn-pipes-pipe-pipesourceselfmanagedkafkaparameters-maximumbatchingwindowinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumBatchingWindowInSeconds { get; set; }
        }

        public class PipeSourceSqsQueueParameters : Humidifier.Base.BaseSubResource, IHaveBatchSize_Integer, IHaveMaximumBatchingWindowInSeconds_Integer
        {
            /// <summary>
            /// BatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcesqsqueueparameters.html#cfn-pipes-pipe-pipesourcesqsqueueparameters-batchsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BatchSize { get; set; }
            /// <summary>
            /// MaximumBatchingWindowInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipesourcesqsqueueparameters.html#cfn-pipes-pipe-pipesourcesqsqueueparameters-maximumbatchingwindowinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumBatchingWindowInSeconds { get; set; }
        }

        public class PipeTargetBatchJobParameters : Humidifier.Base.BaseSubResource, IHaveListOfPipesPipeTypesBatchJobDependencyDependsOn, IHaveStringDictionaryOfParameters, IHavePipesPipeTypesBatchArrayPropertiesArrayProperties, IHaveJobName, IHavePipesPipeTypesBatchRetryStrategyRetryStrategy, IHaveJobDefinition, IHavePipesPipeTypesBatchContainerOverridesContainerOverrides
        {
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetbatchjobparameters.html#cfn-pipes-pipe-pipetargetbatchjobparameters-dependson
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BatchJobDependency
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.BatchJobDependency>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.BatchJobDependency, BaseFunction>>, BaseFunction>? DependsOn { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetbatchjobparameters.html#cfn-pipes-pipe-pipetargetbatchjobparameters-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// ArrayProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetbatchjobparameters.html#cfn-pipes-pipe-pipetargetbatchjobparameters-arrayproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BatchArrayProperties
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.BatchArrayProperties, BaseFunction>? ArrayProperties { get; set; }
            /// <summary>
            /// JobName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetbatchjobparameters.html#cfn-pipes-pipe-pipetargetbatchjobparameters-jobname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JobName { get; set; }
            /// <summary>
            /// RetryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetbatchjobparameters.html#cfn-pipes-pipe-pipetargetbatchjobparameters-retrystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BatchRetryStrategy
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.BatchRetryStrategy, BaseFunction>? RetryStrategy { get; set; }
            /// <summary>
            /// JobDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetbatchjobparameters.html#cfn-pipes-pipe-pipetargetbatchjobparameters-jobdefinition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JobDefinition { get; set; }
            /// <summary>
            /// ContainerOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetbatchjobparameters.html#cfn-pipes-pipe-pipetargetbatchjobparameters-containeroverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BatchContainerOverrides
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.BatchContainerOverrides, BaseFunction>? ContainerOverrides { get; set; }
        }

        public class PipeTargetCloudWatchLogsParameters : Humidifier.Base.BaseSubResource, IHaveLogStreamName, IHaveTimestamp
        {
            /// <summary>
            /// LogStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetcloudwatchlogsparameters.html#cfn-pipes-pipe-pipetargetcloudwatchlogsparameters-logstreamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogStreamName { get; set; }
            /// <summary>
            /// Timestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetcloudwatchlogsparameters.html#cfn-pipes-pipe-pipetargetcloudwatchlogsparameters-timestamp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Timestamp { get; set; }
        }

        public class PipeTargetEcsTaskParameters : Humidifier.Base.BaseSubResource, IHaveTags, IHavePlatformVersion, IHaveGroup, IHaveEnableECSManagedTags_Boolean, IHaveTaskCount_Integer, IHaveEnableExecuteCommand_Boolean, IHaveListOfPipesPipeTypesPlacementConstraintPlacementConstraints, IHavePropagateTags, IHaveListOfPipesPipeTypesPlacementStrategyPlacementStrategy, IHaveLaunchType, IHaveListOfPipesPipeTypesCapacityProviderStrategyItemCapacityProviderStrategy, IHaveReferenceId, IHavePipesPipeTypesEcsTaskOverrideOverrides, IHavePipesPipeTypesNetworkConfigurationNetworkConfiguration, IHaveTaskDefinitionArn
        {
            /// <summary>
            /// PlatformVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-platformversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PlatformVersion { get; set; }
            /// <summary>
            /// Group
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-group
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Group { get; set; }
            /// <summary>
            /// EnableECSManagedTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-enableecsmanagedtags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableECSManagedTags { get; set; }
            /// <summary>
            /// TaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-taskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TaskCount { get; set; }
            /// <summary>
            /// EnableExecuteCommand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-enableexecutecommand
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableExecuteCommand { get; set; }
            /// <summary>
            /// PlacementConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-placementconstraints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PlacementConstraint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.PlacementConstraint>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.PlacementConstraint, BaseFunction>>, BaseFunction>? PlacementConstraints { get; set; }
            /// <summary>
            /// PropagateTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-propagatetags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropagateTags { get; set; }
            /// <summary>
            /// PlacementStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-placementstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PlacementStrategy
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.PlacementStrategy>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.PlacementStrategy, BaseFunction>>, BaseFunction>? PlacementStrategy { get; set; }
            /// <summary>
            /// LaunchType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-launchtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchType { get; set; }
            /// <summary>
            /// CapacityProviderStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-capacityproviderstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CapacityProviderStrategyItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.CapacityProviderStrategyItem>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.CapacityProviderStrategyItem, BaseFunction>>, BaseFunction>? CapacityProviderStrategy { get; set; }
            /// <summary>
            /// ReferenceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-referenceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReferenceId { get; set; }
            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-overrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcsTaskOverride
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.EcsTaskOverride, BaseFunction>? Overrides { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkConfiguration
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// TaskDefinitionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetecstaskparameters.html#cfn-pipes-pipe-pipetargetecstaskparameters-taskdefinitionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskDefinitionArn { get; set; }
        }

        public class PipeTargetEventBridgeEventBusParameters : Humidifier.Base.BaseSubResource, IHaveDetailType, IHaveEndpointId, IHaveTime, IHaveStringListOfResources, IHaveSource
        {
            /// <summary>
            /// DetailType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargeteventbridgeeventbusparameters.html#cfn-pipes-pipe-pipetargeteventbridgeeventbusparameters-detailtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DetailType { get; set; }
            /// <summary>
            /// EndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargeteventbridgeeventbusparameters.html#cfn-pipes-pipe-pipetargeteventbridgeeventbusparameters-endpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointId { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargeteventbridgeeventbusparameters.html#cfn-pipes-pipe-pipetargeteventbridgeeventbusparameters-time
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Time { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargeteventbridgeeventbusparameters.html#cfn-pipes-pipe-pipetargeteventbridgeeventbusparameters-resources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Resources { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargeteventbridgeeventbusparameters.html#cfn-pipes-pipe-pipetargeteventbridgeeventbusparameters-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class PipeTargetHttpParameters : Humidifier.Base.BaseSubResource, IHaveStringListOfPathParameterValues, IHaveStringDictionaryOfHeaderParameters, IHaveStringDictionaryOfQueryStringParameters
        {
            /// <summary>
            /// PathParameterValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargethttpparameters.html#cfn-pipes-pipe-pipetargethttpparameters-pathparametervalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PathParameterValues { get; set; }
            /// <summary>
            /// HeaderParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargethttpparameters.html#cfn-pipes-pipe-pipetargethttpparameters-headerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? HeaderParameters { get; set; }
            /// <summary>
            /// QueryStringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargethttpparameters.html#cfn-pipes-pipe-pipetargethttpparameters-querystringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? QueryStringParameters { get; set; }
        }

        public class PipeTargetKinesisStreamParameters : Humidifier.Base.BaseSubResource, IHavePartitionKey
        {
            /// <summary>
            /// PartitionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetkinesisstreamparameters.html#cfn-pipes-pipe-pipetargetkinesisstreamparameters-partitionkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartitionKey { get; set; }
        }

        public class PipeTargetLambdaFunctionParameters : Humidifier.Base.BaseSubResource, IHaveInvocationType
        {
            /// <summary>
            /// InvocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetlambdafunctionparameters.html#cfn-pipes-pipe-pipetargetlambdafunctionparameters-invocationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationType { get; set; }
        }

        public class PipeTargetParameters : Humidifier.Base.BaseSubResource, IHavePipesPipeTypesPipeTargetStateMachineParametersStepFunctionStateMachineParameters, IHavePipesPipeTypesPipeTargetHttpParametersHttpParameters, IHavePipesPipeTypesPipeTargetTimestreamParametersTimestreamParameters, IHaveInputTemplate, IHavePipesPipeTypesPipeTargetEventBridgeEventBusParametersEventBridgeEventBusParameters, IHavePipesPipeTypesPipeTargetLambdaFunctionParametersLambdaFunctionParameters, IHavePipesPipeTypesPipeTargetBatchJobParametersBatchJobParameters, IHavePipesPipeTypesPipeTargetRedshiftDataParametersRedshiftDataParameters, IHavePipesPipeTypesPipeTargetSqsQueueParametersSqsQueueParameters, IHavePipesPipeTypesPipeTargetCloudWatchLogsParametersCloudWatchLogsParameters, IHavePipesPipeTypesPipeTargetKinesisStreamParametersKinesisStreamParameters, IHavePipesPipeTypesPipeTargetSageMakerPipelineParametersSageMakerPipelineParameters, IHavePipesPipeTypesPipeTargetEcsTaskParametersEcsTaskParameters
        {
            /// <summary>
            /// StepFunctionStateMachineParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-stepfunctionstatemachineparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetStateMachineParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetStateMachineParameters, BaseFunction>? StepFunctionStateMachineParameters { get; set; }
            /// <summary>
            /// HttpParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-httpparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetHttpParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetHttpParameters, BaseFunction>? HttpParameters { get; set; }
            /// <summary>
            /// TimestreamParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-timestreamparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetTimestreamParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetTimestreamParameters, BaseFunction>? TimestreamParameters { get; set; }
            /// <summary>
            /// InputTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-inputtemplate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputTemplate { get; set; }
            /// <summary>
            /// EventBridgeEventBusParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-eventbridgeeventbusparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetEventBridgeEventBusParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetEventBridgeEventBusParameters, BaseFunction>? EventBridgeEventBusParameters { get; set; }
            /// <summary>
            /// LambdaFunctionParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-lambdafunctionparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetLambdaFunctionParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetLambdaFunctionParameters, BaseFunction>? LambdaFunctionParameters { get; set; }
            /// <summary>
            /// BatchJobParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-batchjobparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetBatchJobParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetBatchJobParameters, BaseFunction>? BatchJobParameters { get; set; }
            /// <summary>
            /// RedshiftDataParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-redshiftdataparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetRedshiftDataParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetRedshiftDataParameters, BaseFunction>? RedshiftDataParameters { get; set; }
            /// <summary>
            /// SqsQueueParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-sqsqueueparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetSqsQueueParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetSqsQueueParameters, BaseFunction>? SqsQueueParameters { get; set; }
            /// <summary>
            /// CloudWatchLogsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-cloudwatchlogsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetCloudWatchLogsParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetCloudWatchLogsParameters, BaseFunction>? CloudWatchLogsParameters { get; set; }
            /// <summary>
            /// KinesisStreamParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-kinesisstreamparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetKinesisStreamParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetKinesisStreamParameters, BaseFunction>? KinesisStreamParameters { get; set; }
            /// <summary>
            /// SageMakerPipelineParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-sagemakerpipelineparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetSageMakerPipelineParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetSageMakerPipelineParameters, BaseFunction>? SageMakerPipelineParameters { get; set; }
            /// <summary>
            /// EcsTaskParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetparameters.html#cfn-pipes-pipe-pipetargetparameters-ecstaskparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PipeTargetEcsTaskParameters
            /// </summary>
            public Union<Humidifier.Pipes.PipeTypes.PipeTargetEcsTaskParameters, BaseFunction>? EcsTaskParameters { get; set; }
        }

        public class PipeTargetRedshiftDataParameters : Humidifier.Base.BaseSubResource, IHaveStatementName, IHaveStringListOfSqls, IHaveDatabase, IHaveSecretManagerArn, IHaveDbUser, IHaveWithEvent_Boolean
        {
            /// <summary>
            /// StatementName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetredshiftdataparameters.html#cfn-pipes-pipe-pipetargetredshiftdataparameters-statementname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatementName { get; set; }
            /// <summary>
            /// Sqls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetredshiftdataparameters.html#cfn-pipes-pipe-pipetargetredshiftdataparameters-sqls
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Sqls { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetredshiftdataparameters.html#cfn-pipes-pipe-pipetargetredshiftdataparameters-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// SecretManagerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetredshiftdataparameters.html#cfn-pipes-pipe-pipetargetredshiftdataparameters-secretmanagerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretManagerArn { get; set; }
            /// <summary>
            /// DbUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetredshiftdataparameters.html#cfn-pipes-pipe-pipetargetredshiftdataparameters-dbuser
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DbUser { get; set; }
            /// <summary>
            /// WithEvent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetredshiftdataparameters.html#cfn-pipes-pipe-pipetargetredshiftdataparameters-withevent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? WithEvent { get; set; }
        }

        public class PipeTargetSageMakerPipelineParameters : Humidifier.Base.BaseSubResource, IHaveListOfPipesPipeTypesSageMakerPipelineParameterPipelineParameterList
        {
            /// <summary>
            /// PipelineParameterList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetsagemakerpipelineparameters.html#cfn-pipes-pipe-pipetargetsagemakerpipelineparameters-pipelineparameterlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SageMakerPipelineParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.SageMakerPipelineParameter>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.SageMakerPipelineParameter, BaseFunction>>, BaseFunction>? PipelineParameterList { get; set; }
        }

        public class PipeTargetSqsQueueParameters : Humidifier.Base.BaseSubResource, IHaveMessageGroupId, IHaveMessageDeduplicationId
        {
            /// <summary>
            /// MessageGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetsqsqueueparameters.html#cfn-pipes-pipe-pipetargetsqsqueueparameters-messagegroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageGroupId { get; set; }
            /// <summary>
            /// MessageDeduplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetsqsqueueparameters.html#cfn-pipes-pipe-pipetargetsqsqueueparameters-messagededuplicationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageDeduplicationId { get; set; }
        }

        public class PipeTargetStateMachineParameters : Humidifier.Base.BaseSubResource, IHaveInvocationType
        {
            /// <summary>
            /// InvocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargetstatemachineparameters.html#cfn-pipes-pipe-pipetargetstatemachineparameters-invocationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationType { get; set; }
        }

        public class PipeTargetTimestreamParameters : Humidifier.Base.BaseSubResource, IHaveVersionValue, IHaveListOfPipesPipeTypesDimensionMappingDimensionMappings, IHaveEpochTimeUnit, IHaveTimeFieldType, IHaveTimestampFormat, IHaveListOfPipesPipeTypesMultiMeasureMappingMultiMeasureMappings, IHaveTimeValue, IHaveListOfPipesPipeTypesSingleMeasureMappingSingleMeasureMappings
        {
            /// <summary>
            /// VersionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargettimestreamparameters.html#cfn-pipes-pipe-pipetargettimestreamparameters-versionvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VersionValue { get; set; }
            /// <summary>
            /// DimensionMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargettimestreamparameters.html#cfn-pipes-pipe-pipetargettimestreamparameters-dimensionmappings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.DimensionMapping>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.DimensionMapping, BaseFunction>>, BaseFunction>? DimensionMappings { get; set; }
            /// <summary>
            /// EpochTimeUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargettimestreamparameters.html#cfn-pipes-pipe-pipetargettimestreamparameters-epochtimeunit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EpochTimeUnit { get; set; }
            /// <summary>
            /// TimeFieldType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargettimestreamparameters.html#cfn-pipes-pipe-pipetargettimestreamparameters-timefieldtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeFieldType { get; set; }
            /// <summary>
            /// TimestampFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargettimestreamparameters.html#cfn-pipes-pipe-pipetargettimestreamparameters-timestampformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimestampFormat { get; set; }
            /// <summary>
            /// MultiMeasureMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargettimestreamparameters.html#cfn-pipes-pipe-pipetargettimestreamparameters-multimeasuremappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MultiMeasureMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.MultiMeasureMapping>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.MultiMeasureMapping, BaseFunction>>, BaseFunction>? MultiMeasureMappings { get; set; }
            /// <summary>
            /// TimeValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargettimestreamparameters.html#cfn-pipes-pipe-pipetargettimestreamparameters-timevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeValue { get; set; }
            /// <summary>
            /// SingleMeasureMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-pipetargettimestreamparameters.html#cfn-pipes-pipe-pipetargettimestreamparameters-singlemeasuremappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SingleMeasureMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pipes.PipeTypes.SingleMeasureMapping>, IReadOnlyList<Union<Humidifier.Pipes.PipeTypes.SingleMeasureMapping, BaseFunction>>, BaseFunction>? SingleMeasureMappings { get; set; }
        }

        public class PlacementConstraint : Humidifier.Base.BaseSubResource, IHaveType, IHaveExpression
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-placementconstraint.html#cfn-pipes-pipe-placementconstraint-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-placementconstraint.html#cfn-pipes-pipe-placementconstraint-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class PlacementStrategy : Humidifier.Base.BaseSubResource, IHaveField, IHaveType
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-placementstrategy.html#cfn-pipes-pipe-placementstrategy-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-placementstrategy.html#cfn-pipes-pipe-placementstrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class S3LogDestination : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveOutputFormat, IHavePrefix, IHaveBucketOwner
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-s3logdestination.html#cfn-pipes-pipe-s3logdestination-bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-s3logdestination.html#cfn-pipes-pipe-s3logdestination-outputformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputFormat { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-s3logdestination.html#cfn-pipes-pipe-s3logdestination-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-s3logdestination.html#cfn-pipes-pipe-s3logdestination-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwner { get; set; }
        }

        public class SageMakerPipelineParameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-sagemakerpipelineparameter.html#cfn-pipes-pipe-sagemakerpipelineparameter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-sagemakerpipelineparameter.html#cfn-pipes-pipe-sagemakerpipelineparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SelfManagedKafkaAccessConfigurationCredentials : Humidifier.Base.BaseSubResource, IHaveBasicAuth, IHaveSaslScram256Auth, IHaveClientCertificateTlsAuth, IHaveSaslScram512Auth
        {
            /// <summary>
            /// BasicAuth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-selfmanagedkafkaaccessconfigurationcredentials.html#cfn-pipes-pipe-selfmanagedkafkaaccessconfigurationcredentials-basicauth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BasicAuth { get; set; }
            /// <summary>
            /// SaslScram256Auth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-selfmanagedkafkaaccessconfigurationcredentials.html#cfn-pipes-pipe-selfmanagedkafkaaccessconfigurationcredentials-saslscram256auth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SaslScram256Auth { get; set; }
            /// <summary>
            /// ClientCertificateTlsAuth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-selfmanagedkafkaaccessconfigurationcredentials.html#cfn-pipes-pipe-selfmanagedkafkaaccessconfigurationcredentials-clientcertificatetlsauth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientCertificateTlsAuth { get; set; }
            /// <summary>
            /// SaslScram512Auth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-selfmanagedkafkaaccessconfigurationcredentials.html#cfn-pipes-pipe-selfmanagedkafkaaccessconfigurationcredentials-saslscram512auth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SaslScram512Auth { get; set; }
        }

        public class SelfManagedKafkaAccessConfigurationVpc : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroup
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-selfmanagedkafkaaccessconfigurationvpc.html#cfn-pipes-pipe-selfmanagedkafkaaccessconfigurationvpc-subnets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-selfmanagedkafkaaccessconfigurationvpc.html#cfn-pipes-pipe-selfmanagedkafkaaccessconfigurationvpc-securitygroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroup { get; set; }
        }

        public class SingleMeasureMapping : Humidifier.Base.BaseSubResource, IHaveMeasureName, IHaveMeasureValueType, IHaveMeasureValue
        {
            /// <summary>
            /// MeasureName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-singlemeasuremapping.html#cfn-pipes-pipe-singlemeasuremapping-measurename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MeasureName { get; set; }
            /// <summary>
            /// MeasureValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-singlemeasuremapping.html#cfn-pipes-pipe-singlemeasuremapping-measurevaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MeasureValueType { get; set; }
            /// <summary>
            /// MeasureValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pipes-pipe-singlemeasuremapping.html#cfn-pipes-pipe-singlemeasuremapping-measurevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MeasureValue { get; set; }
        }
    }
}