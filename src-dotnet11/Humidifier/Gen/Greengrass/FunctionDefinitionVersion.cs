namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using FunctionDefinitionVersionTypes;

    public class FunctionDefinitionVersion : Humidifier.Base.BaseResource, IHaveGreengrassFunctionDefinitionVersionTypesDefaultConfigDefaultConfig, IHaveListOfGreengrassFunctionDefinitionVersionTypesFunctionFunctions, IHaveFunctionDefinitionId
    {
        public override string AWSTypeName { get => AWS.Greengrass.FunctionDefinitionVersion; }
        /// <summary>
        /// DefaultConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-functiondefinitionversion.html#cfn-greengrass-functiondefinitionversion-defaultconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DefaultConfig
        /// </summary>
        public Union<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig, BaseFunction>? DefaultConfig { get; set; }

        /// <summary>
        /// Functions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-functiondefinitionversion.html#cfn-greengrass-functiondefinitionversion-functions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Function
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function>, IReadOnlyList<Union<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function, BaseFunction>>, BaseFunction>? Functions { get; set; }

        /// <summary>
        /// FunctionDefinitionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-functiondefinitionversion.html#cfn-greengrass-functiondefinitionversion-functiondefinitionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FunctionDefinitionId { get; set; }
    }

    namespace FunctionDefinitionVersionTypes
    {
        public class DefaultConfig : Humidifier.Base.BaseSubResource, IHaveGreengrassFunctionDefinitionVersionTypesExecutionExecution
        {
            /// <summary>
            /// Execution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-defaultconfig.html#cfn-greengrass-functiondefinitionversion-defaultconfig-execution
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Execution
            /// </summary>
            public Union<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution, BaseFunction>? Execution { get; set; }
        }

        public class Environment : Humidifier.Base.BaseSubResource, IHaveVariables_Json, IHaveGreengrassFunctionDefinitionVersionTypesExecutionExecution, IHaveListOfGreengrassFunctionDefinitionVersionTypesResourceAccessPolicyResourceAccessPolicies, IHaveAccessSysfs_Boolean
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-environment.html#cfn-greengrass-functiondefinitionversion-environment-variables
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Variables { get; set; }
            /// <summary>
            /// Execution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-environment.html#cfn-greengrass-functiondefinitionversion-environment-execution
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Execution
            /// </summary>
            public Union<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution, BaseFunction>? Execution { get; set; }
            /// <summary>
            /// ResourceAccessPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-environment.html#cfn-greengrass-functiondefinitionversion-environment-resourceaccesspolicies
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ResourceAccessPolicy
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Greengrass.FunctionDefinitionVersionTypes.ResourceAccessPolicy>, IReadOnlyList<Union<Humidifier.Greengrass.FunctionDefinitionVersionTypes.ResourceAccessPolicy, BaseFunction>>, BaseFunction>? ResourceAccessPolicies { get; set; }
            /// <summary>
            /// AccessSysfs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-environment.html#cfn-greengrass-functiondefinitionversion-environment-accesssysfs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AccessSysfs { get; set; }
        }

        public class Execution : Humidifier.Base.BaseSubResource, IHaveIsolationMode, IHaveGreengrassFunctionDefinitionVersionTypesRunAsRunAs
        {
            /// <summary>
            /// IsolationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-execution.html#cfn-greengrass-functiondefinitionversion-execution-isolationmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IsolationMode { get; set; }
            /// <summary>
            /// RunAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-execution.html#cfn-greengrass-functiondefinitionversion-execution-runas
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RunAs
            /// </summary>
            public Union<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs, BaseFunction>? RunAs { get; set; }
        }

        public class Function : Humidifier.Base.BaseSubResource, IHaveFunctionArn, IHaveGreengrassFunctionDefinitionVersionTypesFunctionConfigurationFunctionConfiguration, IHaveId
        {
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-function.html#cfn-greengrass-functiondefinitionversion-function-functionarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionArn { get; set; }
            /// <summary>
            /// FunctionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-function.html#cfn-greengrass-functiondefinitionversion-function-functionconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: FunctionConfiguration
            /// </summary>
            public Union<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration, BaseFunction>? FunctionConfiguration { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-function.html#cfn-greengrass-functiondefinitionversion-function-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class FunctionConfiguration : Humidifier.Base.BaseSubResource, IHaveMemorySize_Integer, IHavePinned_Boolean, IHaveExecArgs, IHaveTimeout_Integer, IHaveEncodingType, IHaveGreengrassFunctionDefinitionVersionTypesEnvironmentEnvironment, IHaveExecutable
        {
            /// <summary>
            /// MemorySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-functionconfiguration.html#cfn-greengrass-functiondefinitionversion-functionconfiguration-memorysize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MemorySize { get; set; }
            /// <summary>
            /// Pinned
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-functionconfiguration.html#cfn-greengrass-functiondefinitionversion-functionconfiguration-pinned
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Pinned { get; set; }
            /// <summary>
            /// ExecArgs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-functionconfiguration.html#cfn-greengrass-functiondefinitionversion-functionconfiguration-execargs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecArgs { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-functionconfiguration.html#cfn-greengrass-functiondefinitionversion-functionconfiguration-timeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// EncodingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-functionconfiguration.html#cfn-greengrass-functiondefinitionversion-functionconfiguration-encodingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncodingType { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-functionconfiguration.html#cfn-greengrass-functiondefinitionversion-functionconfiguration-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Environment
            /// </summary>
            public Union<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// Executable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-functionconfiguration.html#cfn-greengrass-functiondefinitionversion-functionconfiguration-executable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Executable { get; set; }
        }

        public class ResourceAccessPolicy : Humidifier.Base.BaseSubResource, IHaveResourceId, IHavePermission
        {
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-resourceaccesspolicy.html#cfn-greengrass-functiondefinitionversion-resourceaccesspolicy-resourceid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceId { get; set; }
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-resourceaccesspolicy.html#cfn-greengrass-functiondefinitionversion-resourceaccesspolicy-permission
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Permission { get; set; }
        }

        public class RunAs : Humidifier.Base.BaseSubResource, IHaveUid_Integer, IHaveGid_Integer
        {
            /// <summary>
            /// Uid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-runas.html#cfn-greengrass-functiondefinitionversion-runas-uid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Uid { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-runas.html#cfn-greengrass-functiondefinitionversion-runas-gid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Gid { get; set; }
        }
    }
}