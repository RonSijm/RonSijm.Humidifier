namespace Humidifier.Lambda
{
    using System.Collections.Generic;
    using VersionTypes;

    public class Version : Humidifier.Base.BaseResource, IHaveDescription, IHaveFunctionName
    {
        public class Attributes
        {
            public static string FunctionArn =  "FunctionArn" ;
            public static string Version =  "Version" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.Version; }

        /// <summary>
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-functionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FunctionName { get; set; }
        /// <summary>
        /// ProvisionedConcurrencyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-provisionedconcurrencyconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ProvisionedConcurrencyConfiguration
        /// </summary>
        public Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration ProvisionedConcurrencyConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// RuntimePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-runtimepolicy
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RuntimePolicy
        /// </summary>
        public Humidifier.Lambda.VersionTypes.RuntimePolicy RuntimePolicy { get; set; }
        /// <summary>
        /// CodeSha256
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-codesha256
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CodeSha256 { get; set; }
    }

    namespace VersionTypes
    {
        public class ProvisionedConcurrencyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProvisionedConcurrentExecutions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-provisionedconcurrencyconfiguration.html#cfn-lambda-version-provisionedconcurrencyconfiguration-provisionedconcurrentexecutions
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProvisionedConcurrentExecutions { get; set; }
        }

        public class RuntimePolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UpdateRuntimeOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-runtimepolicy.html#cfn-lambda-version-runtimepolicy-updateruntimeon
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateRuntimeOn { get; set; }
            /// <summary>
            /// RuntimeVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-runtimepolicy.html#cfn-lambda-version-runtimepolicy-runtimeversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuntimeVersionArn { get; set; }
        }
    }
}