namespace Humidifier.ImageBuilder
{
    using global::System.Collections.Generic;
    using ImagePipelineTypes;

    public class ImagePipeline : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStatus, IHaveImageBuilderImagePipelineTypesImageScanningConfigurationImageScanningConfiguration, IHaveDescription, IHaveContainerRecipeArn, IHaveListOfImageBuilderImagePipelineTypesWorkflowConfigurationWorkflows, IHaveStringDictionaryOfImageTags, IHaveName, IHaveInfrastructureConfigurationArn, IHaveImageRecipeArn, IHaveDistributionConfigurationArn, IHaveImageBuilderImagePipelineTypesScheduleSchedule, IHaveImageBuilderImagePipelineTypesPipelineLoggingConfigurationLoggingConfiguration, IHaveImageBuilderImagePipelineTypesImageTestsConfigurationImageTestsConfiguration, IHaveEnhancedImageMetadataEnabled_Boolean, IHaveExecutionRole, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string DeploymentId =  "DeploymentId" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.ImageBuilder.ImagePipeline; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// ImageScanningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-imagescanningconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ImageScanningConfiguration
        /// </summary>
        public Union<Humidifier.ImageBuilder.ImagePipelineTypes.ImageScanningConfiguration, BaseFunction>? ImageScanningConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ContainerRecipeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-containerrecipearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ContainerRecipeArn { get; set; }
        /// <summary>
        /// Workflows
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-workflows
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: WorkflowConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ImageBuilder.ImagePipelineTypes.WorkflowConfiguration>, IReadOnlyList<Union<Humidifier.ImageBuilder.ImagePipelineTypes.WorkflowConfiguration, BaseFunction>>, BaseFunction>? Workflows { get; set; }
        /// <summary>
        /// ImageTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-imagetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ImageTags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// InfrastructureConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-infrastructureconfigurationarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InfrastructureConfigurationArn { get; set; }
        /// <summary>
        /// ImageRecipeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-imagerecipearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageRecipeArn { get; set; }
        /// <summary>
        /// DistributionConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-distributionconfigurationarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DistributionConfigurationArn { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        public Union<Humidifier.ImageBuilder.ImagePipelineTypes.Schedule, BaseFunction>? Schedule { get; set; }
        /// <summary>
        /// LoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-loggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PipelineLoggingConfiguration
        /// </summary>
        public Union<Humidifier.ImageBuilder.ImagePipelineTypes.PipelineLoggingConfiguration, BaseFunction>? LoggingConfiguration { get; set; }
        /// <summary>
        /// ImageTestsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-imagetestsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ImageTestsConfiguration
        /// </summary>
        public Union<Humidifier.ImageBuilder.ImagePipelineTypes.ImageTestsConfiguration, BaseFunction>? ImageTestsConfiguration { get; set; }
        /// <summary>
        /// EnhancedImageMetadataEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-enhancedimagemetadataenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnhancedImageMetadataEnabled { get; set; }
        /// <summary>
        /// ExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-executionrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRole { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html#cfn-imagebuilder-imagepipeline-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ImagePipelineTypes
    {
        public class AutoDisablePolicy : Humidifier.Base.BaseSubResource, IHaveFailureCount_Integer
        {
            /// <summary>
            /// FailureCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-autodisablepolicy.html#cfn-imagebuilder-imagepipeline-autodisablepolicy-failurecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FailureCount { get; set; }
        }

        public class EcrConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfContainerTags, IHaveRepositoryName
        {
            /// <summary>
            /// ContainerTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-ecrconfiguration.html#cfn-imagebuilder-imagepipeline-ecrconfiguration-containertags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerTags { get; set; }
            /// <summary>
            /// RepositoryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-ecrconfiguration.html#cfn-imagebuilder-imagepipeline-ecrconfiguration-repositoryname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepositoryName { get; set; }
        }

        public class ImageScanningConfiguration : Humidifier.Base.BaseSubResource, IHaveImageBuilderImagePipelineTypesEcrConfigurationEcrConfiguration, IHaveImageScanningEnabled_Boolean
        {
            /// <summary>
            /// EcrConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-imagescanningconfiguration.html#cfn-imagebuilder-imagepipeline-imagescanningconfiguration-ecrconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcrConfiguration
            /// </summary>
            public Union<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration, BaseFunction>? EcrConfiguration { get; set; }
            /// <summary>
            /// ImageScanningEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-imagescanningconfiguration.html#cfn-imagebuilder-imagepipeline-imagescanningconfiguration-imagescanningenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ImageScanningEnabled { get; set; }
        }

        public class ImageTestsConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes_Integer, IHaveImageTestsEnabled_Boolean
        {
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-imagetestsconfiguration.html#cfn-imagebuilder-imagepipeline-imagetestsconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// ImageTestsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-imagetestsconfiguration.html#cfn-imagebuilder-imagepipeline-imagetestsconfiguration-imagetestsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ImageTestsEnabled { get; set; }
        }

        public class PipelineLoggingConfiguration : Humidifier.Base.BaseSubResource, IHavePipelineLogGroupName, IHaveImageLogGroupName
        {
            /// <summary>
            /// PipelineLogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-pipelineloggingconfiguration.html#cfn-imagebuilder-imagepipeline-pipelineloggingconfiguration-pipelineloggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PipelineLogGroupName { get; set; }
            /// <summary>
            /// ImageLogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-pipelineloggingconfiguration.html#cfn-imagebuilder-imagepipeline-pipelineloggingconfiguration-imageloggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageLogGroupName { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveTimezone, IHaveScheduleExpression, IHavePipelineExecutionStartCondition, IHaveImageBuilderImagePipelineTypesAutoDisablePolicyAutoDisablePolicy
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-schedule.html#cfn-imagebuilder-imagepipeline-schedule-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Timezone { get; set; }
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-schedule.html#cfn-imagebuilder-imagepipeline-schedule-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
            /// <summary>
            /// PipelineExecutionStartCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-schedule.html#cfn-imagebuilder-imagepipeline-schedule-pipelineexecutionstartcondition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PipelineExecutionStartCondition { get; set; }
            /// <summary>
            /// AutoDisablePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-schedule.html#cfn-imagebuilder-imagepipeline-schedule-autodisablepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoDisablePolicy
            /// </summary>
            public Union<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy, BaseFunction>? AutoDisablePolicy { get; set; }
        }

        public class WorkflowConfiguration : Humidifier.Base.BaseSubResource, IHaveParallelGroup, IHaveListOfImageBuilderImagePipelineTypesWorkflowParameterParameters, IHaveWorkflowArn, IHaveOnFailure
        {
            /// <summary>
            /// ParallelGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-workflowconfiguration.html#cfn-imagebuilder-imagepipeline-workflowconfiguration-parallelgroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParallelGroup { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-workflowconfiguration.html#cfn-imagebuilder-imagepipeline-workflowconfiguration-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WorkflowParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ImageBuilder.ImagePipelineTypes.WorkflowParameter>, IReadOnlyList<Union<Humidifier.ImageBuilder.ImagePipelineTypes.WorkflowParameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// WorkflowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-workflowconfiguration.html#cfn-imagebuilder-imagepipeline-workflowconfiguration-workflowarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkflowArn { get; set; }
            /// <summary>
            /// OnFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-workflowconfiguration.html#cfn-imagebuilder-imagepipeline-workflowconfiguration-onfailure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnFailure { get; set; }
        }

        public class WorkflowParameter : Humidifier.Base.BaseSubResource, IHaveStringListOfValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-workflowparameter.html#cfn-imagebuilder-imagepipeline-workflowparameter-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-workflowparameter.html#cfn-imagebuilder-imagepipeline-workflowparameter-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}