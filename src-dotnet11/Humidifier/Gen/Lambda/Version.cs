namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using VersionTypes;

    public class Version : Humidifier.Base.BaseResource, IHaveLambdaVersionTypesFunctionScalingConfigFunctionScalingConfig, IHaveFunctionName, IHaveLambdaVersionTypesProvisionedConcurrencyConfigurationProvisionedConcurrencyConfig, IHaveDescription, IHaveLambdaVersionTypesRuntimePolicyRuntimePolicy, IHaveCodeSha256
    {
        public class Attributes
        {
            public static string FunctionArn =  "FunctionArn" ;
            public static string Version =  "Version" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.Version; }
        /// <summary>
        /// FunctionScalingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-functionscalingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FunctionScalingConfig
        /// </summary>
        public Union<Humidifier.Lambda.VersionTypes.FunctionScalingConfig, BaseFunction>? FunctionScalingConfig { get; set; }

        /// <summary>
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-functionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FunctionName { get; set; }
        /// <summary>
        /// ProvisionedConcurrencyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-provisionedconcurrencyconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ProvisionedConcurrencyConfiguration
        /// </summary>
        public Union<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration, BaseFunction>? ProvisionedConcurrencyConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// RuntimePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-runtimepolicy
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RuntimePolicy
        /// </summary>
        public Union<Humidifier.Lambda.VersionTypes.RuntimePolicy, BaseFunction>? RuntimePolicy { get; set; }
        /// <summary>
        /// CodeSha256
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-codesha256
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CodeSha256 { get; set; }
    }

    namespace VersionTypes
    {
        public class FunctionScalingConfig : Humidifier.Base.BaseSubResource, IHaveMinExecutionEnvironments_Integer, IHaveMaxExecutionEnvironments_Integer
        {
            /// <summary>
            /// MinExecutionEnvironments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-functionscalingconfig.html#cfn-lambda-version-functionscalingconfig-minexecutionenvironments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinExecutionEnvironments { get; set; }
            /// <summary>
            /// MaxExecutionEnvironments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-functionscalingconfig.html#cfn-lambda-version-functionscalingconfig-maxexecutionenvironments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxExecutionEnvironments { get; set; }
        }

        public class ProvisionedConcurrencyConfiguration : Humidifier.Base.BaseSubResource, IHaveProvisionedConcurrentExecutions_Integer
        {
            /// <summary>
            /// ProvisionedConcurrentExecutions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-provisionedconcurrencyconfiguration.html#cfn-lambda-version-provisionedconcurrencyconfiguration-provisionedconcurrentexecutions
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProvisionedConcurrentExecutions { get; set; }
        }

        public class RuntimePolicy : Humidifier.Base.BaseSubResource, IHaveUpdateRuntimeOn, IHaveRuntimeVersionArn
        {
            /// <summary>
            /// UpdateRuntimeOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-runtimepolicy.html#cfn-lambda-version-runtimepolicy-updateruntimeon
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateRuntimeOn { get; set; }
            /// <summary>
            /// RuntimeVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-runtimepolicy.html#cfn-lambda-version-runtimepolicy-runtimeversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuntimeVersionArn { get; set; }
        }
    }
}