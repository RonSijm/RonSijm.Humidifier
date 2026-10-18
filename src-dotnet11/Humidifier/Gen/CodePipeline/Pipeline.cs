namespace Humidifier.CodePipeline
{
    using global::System.Collections.Generic;
    using PipelineTypes;

    public class Pipeline : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfCodePipelinePipelineTypesVariableDeclarationVariables, IHaveListOfCodePipelinePipelineTypesArtifactStoreMapArtifactStores, IHaveCodePipelinePipelineTypesArtifactStoreArtifactStore, IHaveListOfCodePipelinePipelineTypesStageTransitionDisableInboundStageTransitions, IHaveListOfCodePipelinePipelineTypesStageDeclarationStages, IHavePipelineType, IHaveExecutionMode, IHaveRestartExecutionOnUpdate_Boolean, IHaveListOfCodePipelinePipelineTypesPipelineTriggerDeclarationTriggers, IHaveRoleArn, IHaveName
    {
        public class Attributes
        {
            public static string Version =  "Version" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CodePipeline.Pipeline; }
        /// <summary>
        /// Variables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html#cfn-codepipeline-pipeline-variables
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VariableDeclaration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.VariableDeclaration>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.VariableDeclaration, BaseFunction>>, BaseFunction>? Variables { get; set; }
        /// <summary>
        /// ArtifactStores
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html#cfn-codepipeline-pipeline-artifactstores
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ArtifactStoreMap
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.ArtifactStoreMap>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.ArtifactStoreMap, BaseFunction>>, BaseFunction>? ArtifactStores { get; set; }
        /// <summary>
        /// ArtifactStore
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html#cfn-codepipeline-pipeline-artifactstore
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ArtifactStore
        /// </summary>
        public Union<Humidifier.CodePipeline.PipelineTypes.ArtifactStore, BaseFunction>? ArtifactStore { get; set; }
        /// <summary>
        /// DisableInboundStageTransitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html#cfn-codepipeline-pipeline-disableinboundstagetransitions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StageTransition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.StageTransition>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.StageTransition, BaseFunction>>, BaseFunction>? DisableInboundStageTransitions { get; set; }

        /// <summary>
        /// Stages
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html#cfn-codepipeline-pipeline-stages
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StageDeclaration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.StageDeclaration>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.StageDeclaration, BaseFunction>>, BaseFunction>? Stages { get; set; }
        /// <summary>
        /// PipelineType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html#cfn-codepipeline-pipeline-pipelinetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PipelineType { get; set; }
        /// <summary>
        /// ExecutionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html#cfn-codepipeline-pipeline-executionmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionMode { get; set; }
        /// <summary>
        /// RestartExecutionOnUpdate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html#cfn-codepipeline-pipeline-restartexecutiononupdate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RestartExecutionOnUpdate { get; set; }
        /// <summary>
        /// Triggers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html#cfn-codepipeline-pipeline-triggers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PipelineTriggerDeclaration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.PipelineTriggerDeclaration>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.PipelineTriggerDeclaration, BaseFunction>>, BaseFunction>? Triggers { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html#cfn-codepipeline-pipeline-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html#cfn-codepipeline-pipeline-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PipelineTypes
    {
        public class ActionDeclaration : Humidifier.Base.BaseSubResource, IHaveCodePipelinePipelineTypesActionTypeIdActionTypeId, IHaveConfiguration_Json, IHaveListOfCodePipelinePipelineTypesOutputArtifactOutputArtifacts, IHaveStringListOfOutputVariables, IHaveNamespace_, IHaveRoleArn, IHaveName, IHaveListOfCodePipelinePipelineTypesEnvironmentVariableEnvironmentVariables, IHaveListOfCodePipelinePipelineTypesInputArtifactInputArtifacts, IHaveStringListOfCommands, IHaveRegion, IHaveRunOrder_Integer, IHaveTimeoutInMinutes_Integer
        {
            /// <summary>
            /// ActionTypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-actiontypeid
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ActionTypeId
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.ActionTypeId, BaseFunction>? ActionTypeId { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// OutputArtifacts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-outputartifacts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputArtifact
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.OutputArtifact>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.OutputArtifact, BaseFunction>>, BaseFunction>? OutputArtifacts { get; set; }
            /// <summary>
            /// OutputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-outputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OutputVariables { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// EnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-environmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EnvironmentVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.EnvironmentVariable>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.EnvironmentVariable, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
            /// <summary>
            /// InputArtifacts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-inputartifacts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputArtifact
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.InputArtifact>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.InputArtifact, BaseFunction>>, BaseFunction>? InputArtifacts { get; set; }
            /// <summary>
            /// Commands
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-commands
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Commands { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// RunOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-runorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RunOrder { get; set; }
            /// <summary>
            /// TimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiondeclaration.html#cfn-codepipeline-pipeline-actiondeclaration-timeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInMinutes { get; set; }
        }

        public class ActionTypeId : Humidifier.Base.BaseSubResource, IHaveOwner, IHaveCategory, IHaveVersion, IHaveProvider
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiontypeid.html#cfn-codepipeline-pipeline-actiontypeid-owner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Owner { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiontypeid.html#cfn-codepipeline-pipeline-actiontypeid-category
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Category { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiontypeid.html#cfn-codepipeline-pipeline-actiontypeid-version
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Provider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-actiontypeid.html#cfn-codepipeline-pipeline-actiontypeid-provider
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Provider { get; set; }
        }

        public class ArtifactStore : Humidifier.Base.BaseSubResource, IHaveType, IHaveCodePipelinePipelineTypesEncryptionKeyEncryptionKey, IHaveLocation
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstore.html#cfn-codepipeline-pipeline-artifactstore-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// EncryptionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstore.html#cfn-codepipeline-pipeline-artifactstore-encryptionkey
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionKey
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.EncryptionKey, BaseFunction>? EncryptionKey { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstore.html#cfn-codepipeline-pipeline-artifactstore-location
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }

        public class ArtifactStoreMap : Humidifier.Base.BaseSubResource, IHaveCodePipelinePipelineTypesArtifactStoreArtifactStore, IHaveRegion
        {
            /// <summary>
            /// ArtifactStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstoremap.html#cfn-codepipeline-pipeline-artifactstoremap-artifactstore
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ArtifactStore
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.ArtifactStore, BaseFunction>? ArtifactStore { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstoremap.html#cfn-codepipeline-pipeline-artifactstoremap-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }

        public class BeforeEntryConditions : Humidifier.Base.BaseSubResource, IHaveListOfCodePipelinePipelineTypesConditionConditions
        {
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-beforeentryconditions.html#cfn-codepipeline-pipeline-beforeentryconditions-conditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Condition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.Condition>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.Condition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }

        public class BlockerDeclaration : Humidifier.Base.BaseSubResource, IHaveType, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-blockerdeclaration.html#cfn-codepipeline-pipeline-blockerdeclaration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-blockerdeclaration.html#cfn-codepipeline-pipeline-blockerdeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource, IHaveListOfCodePipelinePipelineTypesRuleDeclarationRules, IHaveResult
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-condition.html#cfn-codepipeline-pipeline-condition-rules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleDeclaration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.RuleDeclaration>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.RuleDeclaration, BaseFunction>>, BaseFunction>? Rules { get; set; }
            /// <summary>
            /// Result
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-condition.html#cfn-codepipeline-pipeline-condition-result
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Result { get; set; }
        }

        public class EncryptionKey : Humidifier.Base.BaseSubResource, IHaveType, IHaveId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-encryptionkey.html#cfn-codepipeline-pipeline-encryptionkey-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-encryptionkey.html#cfn-codepipeline-pipeline-encryptionkey-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class EnvironmentVariable : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-environmentvariable.html#cfn-codepipeline-pipeline-environmentvariable-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-environmentvariable.html#cfn-codepipeline-pipeline-environmentvariable-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-environmentvariable.html#cfn-codepipeline-pipeline-environmentvariable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FailureConditions : Humidifier.Base.BaseSubResource, IHaveCodePipelinePipelineTypesRetryConfigurationRetryConfiguration, IHaveListOfCodePipelinePipelineTypesConditionConditions, IHaveResult
        {
            /// <summary>
            /// RetryConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-failureconditions.html#cfn-codepipeline-pipeline-failureconditions-retryconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetryConfiguration
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration, BaseFunction>? RetryConfiguration { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-failureconditions.html#cfn-codepipeline-pipeline-failureconditions-conditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Condition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.Condition>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.Condition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
            /// <summary>
            /// Result
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-failureconditions.html#cfn-codepipeline-pipeline-failureconditions-result
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Result { get; set; }
        }

        public class GitBranchFilterCriteria : Humidifier.Base.BaseSubResource, IHaveStringListOfIncludes, IHaveStringListOfExcludes
        {
            /// <summary>
            /// Includes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitbranchfiltercriteria.html#cfn-codepipeline-pipeline-gitbranchfiltercriteria-includes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Includes { get; set; }
            /// <summary>
            /// Excludes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitbranchfiltercriteria.html#cfn-codepipeline-pipeline-gitbranchfiltercriteria-excludes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Excludes { get; set; }
        }

        public class GitConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfCodePipelinePipelineTypesGitPullRequestFilterPullRequest, IHaveListOfCodePipelinePipelineTypesGitPushFilterPush, IHaveSourceActionName
        {
            /// <summary>
            /// PullRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitconfiguration.html#cfn-codepipeline-pipeline-gitconfiguration-pullrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GitPullRequestFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.GitPullRequestFilter>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.GitPullRequestFilter, BaseFunction>>, BaseFunction>? PullRequest { get; set; }
            /// <summary>
            /// Push
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitconfiguration.html#cfn-codepipeline-pipeline-gitconfiguration-push
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GitPushFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.GitPushFilter>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.GitPushFilter, BaseFunction>>, BaseFunction>? Push { get; set; }
            /// <summary>
            /// SourceActionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitconfiguration.html#cfn-codepipeline-pipeline-gitconfiguration-sourceactionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceActionName { get; set; }
        }

        public class GitFilePathFilterCriteria : Humidifier.Base.BaseSubResource, IHaveStringListOfIncludes, IHaveStringListOfExcludes
        {
            /// <summary>
            /// Includes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitfilepathfiltercriteria.html#cfn-codepipeline-pipeline-gitfilepathfiltercriteria-includes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Includes { get; set; }
            /// <summary>
            /// Excludes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitfilepathfiltercriteria.html#cfn-codepipeline-pipeline-gitfilepathfiltercriteria-excludes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Excludes { get; set; }
        }

        public class GitPullRequestFilter : Humidifier.Base.BaseSubResource, IHaveCodePipelinePipelineTypesGitFilePathFilterCriteriaFilePaths, IHaveStringListOfEvents, IHaveCodePipelinePipelineTypesGitBranchFilterCriteriaBranches
        {
            /// <summary>
            /// FilePaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitpullrequestfilter.html#cfn-codepipeline-pipeline-gitpullrequestfilter-filepaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitFilePathFilterCriteria
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.GitFilePathFilterCriteria, BaseFunction>? FilePaths { get; set; }
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitpullrequestfilter.html#cfn-codepipeline-pipeline-gitpullrequestfilter-events
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Events { get; set; }
            /// <summary>
            /// Branches
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitpullrequestfilter.html#cfn-codepipeline-pipeline-gitpullrequestfilter-branches
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitBranchFilterCriteria
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.GitBranchFilterCriteria, BaseFunction>? Branches { get; set; }
        }

        public class GitPushFilter : Humidifier.Base.BaseSubResource, IHaveCodePipelinePipelineTypesGitFilePathFilterCriteriaFilePaths, IHaveCodePipelinePipelineTypesGitBranchFilterCriteriaBranches, IHaveCodePipelinePipelineTypesGitTagFilterCriteriaTags
        {
            /// <summary>
            /// FilePaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitpushfilter.html#cfn-codepipeline-pipeline-gitpushfilter-filepaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitFilePathFilterCriteria
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.GitFilePathFilterCriteria, BaseFunction>? FilePaths { get; set; }
            /// <summary>
            /// Branches
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitpushfilter.html#cfn-codepipeline-pipeline-gitpushfilter-branches
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitBranchFilterCriteria
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.GitBranchFilterCriteria, BaseFunction>? Branches { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gitpushfilter.html#cfn-codepipeline-pipeline-gitpushfilter-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitTagFilterCriteria
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.GitTagFilterCriteria, BaseFunction>? Tags { get; set; }
        }

        public class GitTagFilterCriteria : Humidifier.Base.BaseSubResource, IHaveStringListOfIncludes, IHaveStringListOfExcludes
        {
            /// <summary>
            /// Includes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gittagfiltercriteria.html#cfn-codepipeline-pipeline-gittagfiltercriteria-includes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Includes { get; set; }
            /// <summary>
            /// Excludes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-gittagfiltercriteria.html#cfn-codepipeline-pipeline-gittagfiltercriteria-excludes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Excludes { get; set; }
        }

        public class InputArtifact : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-inputartifact.html#cfn-codepipeline-pipeline-inputartifact-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class OutputArtifact : Humidifier.Base.BaseSubResource, IHaveStringListOfFiles, IHaveName
        {
            /// <summary>
            /// Files
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-outputartifact.html#cfn-codepipeline-pipeline-outputartifact-files
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Files { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-outputartifact.html#cfn-codepipeline-pipeline-outputartifact-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PipelineTriggerDeclaration : Humidifier.Base.BaseSubResource, IHaveCodePipelinePipelineTypesGitConfigurationGitConfiguration, IHaveProviderType
        {
            /// <summary>
            /// GitConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-pipelinetriggerdeclaration.html#cfn-codepipeline-pipeline-pipelinetriggerdeclaration-gitconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitConfiguration
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.GitConfiguration, BaseFunction>? GitConfiguration { get; set; }
            /// <summary>
            /// ProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-pipelinetriggerdeclaration.html#cfn-codepipeline-pipeline-pipelinetriggerdeclaration-providertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProviderType { get; set; }
        }

        public class RetryConfiguration : Humidifier.Base.BaseSubResource, IHaveRetryMode
        {
            /// <summary>
            /// RetryMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-retryconfiguration.html#cfn-codepipeline-pipeline-retryconfiguration-retrymode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RetryMode { get; set; }
        }

        public class RuleDeclaration : Humidifier.Base.BaseSubResource, IHaveCodePipelinePipelineTypesRuleTypeIdRuleTypeId, IHaveConfiguration_Json, IHaveListOfCodePipelinePipelineTypesInputArtifactInputArtifacts, IHaveStringListOfCommands, IHaveRegion, IHaveRoleArn, IHaveName
        {
            /// <summary>
            /// RuleTypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-ruledeclaration.html#cfn-codepipeline-pipeline-ruledeclaration-ruletypeid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleTypeId
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.RuleTypeId, BaseFunction>? RuleTypeId { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-ruledeclaration.html#cfn-codepipeline-pipeline-ruledeclaration-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// InputArtifacts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-ruledeclaration.html#cfn-codepipeline-pipeline-ruledeclaration-inputartifacts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputArtifact
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.InputArtifact>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.InputArtifact, BaseFunction>>, BaseFunction>? InputArtifacts { get; set; }
            /// <summary>
            /// Commands
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-ruledeclaration.html#cfn-codepipeline-pipeline-ruledeclaration-commands
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Commands { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-ruledeclaration.html#cfn-codepipeline-pipeline-ruledeclaration-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-ruledeclaration.html#cfn-codepipeline-pipeline-ruledeclaration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-ruledeclaration.html#cfn-codepipeline-pipeline-ruledeclaration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RuleTypeId : Humidifier.Base.BaseSubResource, IHaveOwner, IHaveCategory, IHaveVersion, IHaveProvider
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-ruletypeid.html#cfn-codepipeline-pipeline-ruletypeid-owner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Owner { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-ruletypeid.html#cfn-codepipeline-pipeline-ruletypeid-category
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Category { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-ruletypeid.html#cfn-codepipeline-pipeline-ruletypeid-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Provider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-ruletypeid.html#cfn-codepipeline-pipeline-ruletypeid-provider
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Provider { get; set; }
        }

        public class StageDeclaration : Humidifier.Base.BaseSubResource, IHaveListOfCodePipelinePipelineTypesBlockerDeclarationBlockers, IHaveListOfCodePipelinePipelineTypesActionDeclarationActions, IHaveCodePipelinePipelineTypesBeforeEntryConditionsBeforeEntry, IHaveCodePipelinePipelineTypesSuccessConditionsOnSuccess, IHaveName, IHaveCodePipelinePipelineTypesFailureConditionsOnFailure
        {
            /// <summary>
            /// Blockers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stagedeclaration.html#cfn-codepipeline-pipeline-stagedeclaration-blockers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BlockerDeclaration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.BlockerDeclaration>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.BlockerDeclaration, BaseFunction>>, BaseFunction>? Blockers { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stagedeclaration.html#cfn-codepipeline-pipeline-stagedeclaration-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ActionDeclaration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.ActionDeclaration>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.ActionDeclaration, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// BeforeEntry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stagedeclaration.html#cfn-codepipeline-pipeline-stagedeclaration-beforeentry
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BeforeEntryConditions
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.BeforeEntryConditions, BaseFunction>? BeforeEntry { get; set; }
            /// <summary>
            /// OnSuccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stagedeclaration.html#cfn-codepipeline-pipeline-stagedeclaration-onsuccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SuccessConditions
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.SuccessConditions, BaseFunction>? OnSuccess { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stagedeclaration.html#cfn-codepipeline-pipeline-stagedeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// OnFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stagedeclaration.html#cfn-codepipeline-pipeline-stagedeclaration-onfailure
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FailureConditions
            /// </summary>
            public Union<Humidifier.CodePipeline.PipelineTypes.FailureConditions, BaseFunction>? OnFailure { get; set; }
        }

        public class StageTransition : Humidifier.Base.BaseSubResource, IHaveStageName, IHaveReason
        {
            /// <summary>
            /// StageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stagetransition.html#cfn-codepipeline-pipeline-stagetransition-stagename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StageName { get; set; }
            /// <summary>
            /// Reason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stagetransition.html#cfn-codepipeline-pipeline-stagetransition-reason
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Reason { get; set; }
        }

        public class SuccessConditions : Humidifier.Base.BaseSubResource, IHaveListOfCodePipelinePipelineTypesConditionConditions
        {
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-successconditions.html#cfn-codepipeline-pipeline-successconditions-conditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Condition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodePipeline.PipelineTypes.Condition>, IReadOnlyList<Union<Humidifier.CodePipeline.PipelineTypes.Condition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }

        public class VariableDeclaration : Humidifier.Base.BaseSubResource, IHaveDefaultValue, IHaveDescription, IHaveName
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-variabledeclaration.html#cfn-codepipeline-pipeline-variabledeclaration-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-variabledeclaration.html#cfn-codepipeline-pipeline-variabledeclaration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-variabledeclaration.html#cfn-codepipeline-pipeline-variabledeclaration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}