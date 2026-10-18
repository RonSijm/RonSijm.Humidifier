namespace Humidifier.Config
{
    using global::System.Collections.Generic;
    using RemediationConfigurationTypes;

    public class RemediationConfiguration : Humidifier.Base.BaseResource, IHaveTargetVersion, IHaveConfigRemediationConfigurationTypesExecutionControlsExecutionControls, IHaveParameters_Json, IHaveTargetType, IHaveConfigRuleName, IHaveResourceType, IHaveRetryAttemptSeconds_Integer, IHaveMaximumAutomaticAttempts_Integer, IHaveTargetId, IHaveAutomatic_Boolean
    {
        public override string AWSTypeName { get => AWS.Config.RemediationConfiguration; }
        /// <summary>
        /// TargetVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-targetversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TargetVersion { get; set; }
        /// <summary>
        /// ExecutionControls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-executioncontrols
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExecutionControls
        /// </summary>
        public Union<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls, BaseFunction>? ExecutionControls { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Parameters { get; set; }

        /// <summary>
        /// TargetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-targettype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetType { get; set; }

        /// <summary>
        /// ConfigRuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-configrulename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConfigRuleName { get; set; }
        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-resourcetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceType { get; set; }
        /// <summary>
        /// RetryAttemptSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-retryattemptseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? RetryAttemptSeconds { get; set; }
        /// <summary>
        /// MaximumAutomaticAttempts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-maximumautomaticattempts
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaximumAutomaticAttempts { get; set; }

        /// <summary>
        /// TargetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-targetid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetId { get; set; }
        /// <summary>
        /// Automatic
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-automatic
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Automatic { get; set; }
    }

    namespace RemediationConfigurationTypes
    {
        public class ExecutionControls : Humidifier.Base.BaseSubResource, IHaveConfigRemediationConfigurationTypesSsmControlsSsmControls
        {
            /// <summary>
            /// SsmControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-executioncontrols.html#cfn-config-remediationconfiguration-executioncontrols-ssmcontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SsmControls
            /// </summary>
            public Union<Humidifier.Config.RemediationConfigurationTypes.SsmControls, BaseFunction>? SsmControls { get; set; }
        }

        public class SsmControls : Humidifier.Base.BaseSubResource, IHaveErrorPercentage_Integer, IHaveConcurrentExecutionRatePercentage_Integer
        {
            /// <summary>
            /// ErrorPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-ssmcontrols.html#cfn-config-remediationconfiguration-ssmcontrols-errorpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ErrorPercentage { get; set; }
            /// <summary>
            /// ConcurrentExecutionRatePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-ssmcontrols.html#cfn-config-remediationconfiguration-ssmcontrols-concurrentexecutionratepercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConcurrentExecutionRatePercentage { get; set; }
        }
    }
}