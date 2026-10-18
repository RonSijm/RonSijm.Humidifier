namespace Humidifier.StepFunctions
{
    using global::System.Collections.Generic;
    using StateMachineTypes;

    public class StateMachine : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStepFunctionsStateMachineTypesEncryptionConfigurationEncryptionConfiguration, IHaveDefinitionString, IHaveStepFunctionsStateMachineTypesLoggingConfigurationLoggingConfiguration, IHaveJsonDictionaryOfDefinitionSubstitutions, IHaveDefinition_Json, IHaveStepFunctionsStateMachineTypesS3LocationDefinitionS3Location, IHaveStateMachineName, IHaveRoleArn, IHaveListOfStepFunctionsStateMachineTypesTagsEntryTags, IHaveStateMachineType, IHaveStepFunctionsStateMachineTypesTracingConfigurationTracingConfiguration
    {
        public class Attributes
        {
            public static string StateMachineRevisionId =  "StateMachineRevisionId" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.StepFunctions.StateMachine; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-encryptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.StepFunctions.StateMachineTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// DefinitionString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitionstring
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefinitionString { get; set; }
        /// <summary>
        /// LoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-loggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingConfiguration
        /// </summary>
        public Union<Humidifier.StepFunctions.StateMachineTypes.LoggingConfiguration, BaseFunction>? LoggingConfiguration { get; set; }
        /// <summary>
        /// DefinitionSubstitutions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitionsubstitutions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: Json
        /// </summary>
        public Union<IReadOnlyDictionary<string, object>, IReadOnlyDictionary<string, Union<object, BaseFunction>>, BaseFunction>? DefinitionSubstitutions { get; set; }
        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definition
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Definition { get; set; }
        /// <summary>
        /// DefinitionS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitions3location
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3Location
        /// </summary>
        public Union<Humidifier.StepFunctions.StateMachineTypes.S3Location, BaseFunction>? DefinitionS3Location { get; set; }
        public Union<string, BaseFunction>? StateMachineName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsEntry
        /// </summary>
        public Union<IReadOnlyList<Humidifier.StepFunctions.StateMachineTypes.TagsEntry>, IReadOnlyList<Union<Humidifier.StepFunctions.StateMachineTypes.TagsEntry, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// StateMachineType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-statemachinetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StateMachineType { get; set; }
        /// <summary>
        /// TracingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-tracingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TracingConfiguration
        /// </summary>
        public Union<Humidifier.StepFunctions.StateMachineTypes.TracingConfiguration, BaseFunction>? TracingConfiguration { get; set; }
    }

    namespace StateMachineTypes
    {
        public class CloudWatchLogsLogGroup : Humidifier.Base.BaseSubResource, IHaveLogGroupArn
        {
            /// <summary>
            /// LogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-cloudwatchlogsloggroup.html#cfn-stepfunctions-statemachine-cloudwatchlogsloggroup-loggrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupArn { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveKmsKeyId, IHaveKmsDataKeyReusePeriodSeconds_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-encryptionconfiguration.html#cfn-stepfunctions-statemachine-encryptionconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-encryptionconfiguration.html#cfn-stepfunctions-statemachine-encryptionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// KmsDataKeyReusePeriodSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-encryptionconfiguration.html#cfn-stepfunctions-statemachine-encryptionconfiguration-kmsdatakeyreuseperiodseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? KmsDataKeyReusePeriodSeconds { get; set; }
        }

        public class LogDestination : Humidifier.Base.BaseSubResource, IHaveStepFunctionsStateMachineTypesCloudWatchLogsLogGroupCloudWatchLogsLogGroup
        {
            /// <summary>
            /// CloudWatchLogsLogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-logdestination.html#cfn-stepfunctions-statemachine-logdestination-cloudwatchlogsloggroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsLogGroup
            /// </summary>
            public Union<Humidifier.StepFunctions.StateMachineTypes.CloudWatchLogsLogGroup, BaseFunction>? CloudWatchLogsLogGroup { get; set; }
        }

        public class LoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveIncludeExecutionData_Boolean, IHaveListOfStepFunctionsStateMachineTypesLogDestinationDestinations, IHaveLevel
        {
            /// <summary>
            /// IncludeExecutionData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-loggingconfiguration.html#cfn-stepfunctions-statemachine-loggingconfiguration-includeexecutiondata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeExecutionData { get; set; }
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-loggingconfiguration.html#cfn-stepfunctions-statemachine-loggingconfiguration-destinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LogDestination
            /// </summary>
            public Union<IReadOnlyList<Humidifier.StepFunctions.StateMachineTypes.LogDestination>, IReadOnlyList<Union<Humidifier.StepFunctions.StateMachineTypes.LogDestination, BaseFunction>>, BaseFunction>? Destinations { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-loggingconfiguration.html#cfn-stepfunctions-statemachine-loggingconfiguration-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Level { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveVersion, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-s3location.html#cfn-stepfunctions-statemachine-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-s3location.html#cfn-stepfunctions-statemachine-s3location-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-s3location.html#cfn-stepfunctions-statemachine-s3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TagsEntry : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-tagsentry.html#cfn-stepfunctions-statemachine-tagsentry-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-tagsentry.html#cfn-stepfunctions-statemachine-tagsentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TracingConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-tracingconfiguration.html#cfn-stepfunctions-statemachine-tracingconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }
    }
}