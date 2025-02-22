namespace Humidifier.Config
{
    using System.Collections.Generic;
    using RemediationConfigurationTypes;

    public class RemediationConfiguration : Humidifier.Base.BaseResource, IHaveResourceType, IHaveParameters, IHaveTargetType, IHaveTargetId, IHaveConfigRuleName
    {
        public override string AWSTypeName { get => AWS.Config.RemediationConfiguration; }
        /// <summary>
        /// TargetVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-targetversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetVersion { get; set; }
        /// <summary>
        /// ExecutionControls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-executioncontrols
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExecutionControls
        /// </summary>
        public Humidifier.Config.RemediationConfigurationTypes.ExecutionControls ExecutionControls { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Parameters { get; set; }

        /// <summary>
        /// TargetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-targettype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TargetType { get; set; }

        /// <summary>
        /// ConfigRuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-configrulename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConfigRuleName { get; set; }
        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-resourcetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceType { get; set; }
        /// <summary>
        /// RetryAttemptSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-retryattemptseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic RetryAttemptSeconds { get; set; }
        /// <summary>
        /// MaximumAutomaticAttempts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-maximumautomaticattempts
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaximumAutomaticAttempts { get; set; }

        /// <summary>
        /// TargetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-targetid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TargetId { get; set; }
        /// <summary>
        /// Automatic
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-remediationconfiguration.html#cfn-config-remediationconfiguration-automatic
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Automatic { get; set; }
    }

    namespace RemediationConfigurationTypes
    {
        public class ExecutionControls : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SsmControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-executioncontrols.html#cfn-config-remediationconfiguration-executioncontrols-ssmcontrols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SsmControls
            /// </summary>
            public Humidifier.Config.RemediationConfigurationTypes.SsmControls SsmControls { get; set; }
        }

        public class RemediationParameterValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-remediationparametervalue.html#cfn-config-remediationconfiguration-remediationparametervalue-resourcevalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceValue
            /// </summary>
            public Humidifier.Config.RemediationConfigurationTypes.ResourceValue ResourceValue { get; set; }
            /// <summary>
            /// StaticValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-remediationparametervalue.html#cfn-config-remediationconfiguration-remediationparametervalue-staticvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticValue
            /// </summary>
            public Humidifier.Config.RemediationConfigurationTypes.StaticValue StaticValue { get; set; }
        }

        public class ResourceValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-resourcevalue.html#cfn-config-remediationconfiguration-resourcevalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class SsmControls : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ErrorPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-ssmcontrols.html#cfn-config-remediationconfiguration-ssmcontrols-errorpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ErrorPercentage { get; set; }
            /// <summary>
            /// ConcurrentExecutionRatePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-ssmcontrols.html#cfn-config-remediationconfiguration-ssmcontrols-concurrentexecutionratepercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ConcurrentExecutionRatePercentage { get; set; }
        }

        public class StaticValue : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-staticvalue.html#cfn-config-remediationconfiguration-staticvalue-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }
    }
}