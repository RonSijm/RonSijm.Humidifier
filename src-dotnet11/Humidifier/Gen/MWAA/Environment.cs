namespace Humidifier.MWAA
{
    using global::System.Collections.Generic;
    using EnvironmentTypes;

    public class Environment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAirflowConfigurationOptions_Json, IHavePluginsS3Path, IHaveWorkerReplacementStrategy, IHaveStartupScriptS3Path, IHaveName, IHaveExecutionRoleArn, IHaveStartupScriptS3ObjectVersion, IHaveDagS3Path, IHaveMWAAEnvironmentTypesLoggingConfigurationLoggingConfiguration, IHaveWebserverAccessMode, IHaveMWAAEnvironmentTypesNetworkConfigurationNetworkConfiguration, IHaveKmsKey, IHaveTags_Json, IHaveMaxWorkers_Integer, IHaveEnvironmentClass, IHaveSchedulers_Integer, IHaveRequirementsS3Path, IHaveMinWorkers_Integer, IHaveAirflowVersion, IHaveRequirementsS3ObjectVersion, IHaveSourceBucketArn, IHaveWeeklyMaintenanceWindowStart, IHavePluginsS3ObjectVersion, IHaveEndpointManagement, IHaveMaxWebservers_Integer, IHaveMinWebservers_Integer
    {
        public class Attributes
        {
            public static string WebserverVpcEndpointService =  "WebserverVpcEndpointService" ;
            public static string DatabaseVpcEndpointService =  "DatabaseVpcEndpointService" ;
            public static string CeleryExecutorQueue =  "CeleryExecutorQueue" ;
            public static string WebserverUrl =  "WebserverUrl" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MWAA.Environment; }
        /// <summary>
        /// AirflowConfigurationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-airflowconfigurationoptions
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? AirflowConfigurationOptions { get; set; }
        /// <summary>
        /// PluginsS3Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-pluginss3path
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PluginsS3Path { get; set; }
        /// <summary>
        /// WorkerReplacementStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-workerreplacementstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkerReplacementStrategy { get; set; }
        /// <summary>
        /// StartupScriptS3Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-startupscripts3path
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StartupScriptS3Path { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-executionrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// StartupScriptS3ObjectVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-startupscripts3objectversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StartupScriptS3ObjectVersion { get; set; }
        /// <summary>
        /// DagS3Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-dags3path
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DagS3Path { get; set; }
        /// <summary>
        /// LoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-loggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingConfiguration
        /// </summary>
        public Union<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration, BaseFunction>? LoggingConfiguration { get; set; }
        /// <summary>
        /// WebserverAccessMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-webserveraccessmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WebserverAccessMode { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-networkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NetworkConfiguration
        /// </summary>
        public Union<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
        /// <summary>
        /// KmsKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-kmskey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKey { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MaxWorkers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-maxworkers
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxWorkers { get; set; }
        /// <summary>
        /// EnvironmentClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-environmentclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentClass { get; set; }
        /// <summary>
        /// Schedulers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-schedulers
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Schedulers { get; set; }
        /// <summary>
        /// RequirementsS3Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-requirementss3path
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RequirementsS3Path { get; set; }
        /// <summary>
        /// MinWorkers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-minworkers
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MinWorkers { get; set; }
        /// <summary>
        /// AirflowVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-airflowversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AirflowVersion { get; set; }
        /// <summary>
        /// RequirementsS3ObjectVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-requirementss3objectversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RequirementsS3ObjectVersion { get; set; }
        /// <summary>
        /// SourceBucketArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-sourcebucketarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceBucketArn { get; set; }
        /// <summary>
        /// WeeklyMaintenanceWindowStart
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-weeklymaintenancewindowstart
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WeeklyMaintenanceWindowStart { get; set; }
        /// <summary>
        /// PluginsS3ObjectVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-pluginss3objectversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PluginsS3ObjectVersion { get; set; }
        /// <summary>
        /// EndpointManagement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-endpointmanagement
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointManagement { get; set; }
        /// <summary>
        /// MaxWebservers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-maxwebservers
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxWebservers { get; set; }
        /// <summary>
        /// MinWebservers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-minwebservers
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MinWebservers { get; set; }
    }

    namespace EnvironmentTypes
    {
        public class LoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveMWAAEnvironmentTypesModuleLoggingConfigurationSchedulerLogs, IHaveMWAAEnvironmentTypesModuleLoggingConfigurationTaskLogs, IHaveMWAAEnvironmentTypesModuleLoggingConfigurationDagProcessingLogs, IHaveMWAAEnvironmentTypesModuleLoggingConfigurationWebserverLogs, IHaveMWAAEnvironmentTypesModuleLoggingConfigurationWorkerLogs
        {
            /// <summary>
            /// SchedulerLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-loggingconfiguration.html#cfn-mwaa-environment-loggingconfiguration-schedulerlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModuleLoggingConfiguration
            /// </summary>
            public Union<Humidifier.MWAA.EnvironmentTypes.ModuleLoggingConfiguration, BaseFunction>? SchedulerLogs { get; set; }
            /// <summary>
            /// TaskLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-loggingconfiguration.html#cfn-mwaa-environment-loggingconfiguration-tasklogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModuleLoggingConfiguration
            /// </summary>
            public Union<Humidifier.MWAA.EnvironmentTypes.ModuleLoggingConfiguration, BaseFunction>? TaskLogs { get; set; }
            /// <summary>
            /// DagProcessingLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-loggingconfiguration.html#cfn-mwaa-environment-loggingconfiguration-dagprocessinglogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModuleLoggingConfiguration
            /// </summary>
            public Union<Humidifier.MWAA.EnvironmentTypes.ModuleLoggingConfiguration, BaseFunction>? DagProcessingLogs { get; set; }
            /// <summary>
            /// WebserverLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-loggingconfiguration.html#cfn-mwaa-environment-loggingconfiguration-webserverlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModuleLoggingConfiguration
            /// </summary>
            public Union<Humidifier.MWAA.EnvironmentTypes.ModuleLoggingConfiguration, BaseFunction>? WebserverLogs { get; set; }
            /// <summary>
            /// WorkerLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-loggingconfiguration.html#cfn-mwaa-environment-loggingconfiguration-workerlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModuleLoggingConfiguration
            /// </summary>
            public Union<Humidifier.MWAA.EnvironmentTypes.ModuleLoggingConfiguration, BaseFunction>? WorkerLogs { get; set; }
        }

        public class ModuleLoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveCloudWatchLogGroupArn, IHaveEnabled_Boolean, IHaveLogLevel
        {
            /// <summary>
            /// CloudWatchLogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-moduleloggingconfiguration.html#cfn-mwaa-environment-moduleloggingconfiguration-cloudwatchloggrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudWatchLogGroupArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-moduleloggingconfiguration.html#cfn-mwaa-environment-moduleloggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-moduleloggingconfiguration.html#cfn-mwaa-environment-moduleloggingconfiguration-loglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogLevel { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-networkconfiguration.html#cfn-mwaa-environment-networkconfiguration-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-networkconfiguration.html#cfn-mwaa-environment-networkconfiguration-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}