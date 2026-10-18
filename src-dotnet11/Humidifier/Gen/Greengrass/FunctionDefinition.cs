namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using FunctionDefinitionTypes;

    public class FunctionDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGreengrassFunctionDefinitionTypesFunctionDefinitionVersionInitialVersion, IHaveTags_Json, IHaveName
    {
        public class Attributes
        {
            public static string LatestVersionArn =  "LatestVersionArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Greengrass.FunctionDefinition; }
        /// <summary>
        /// InitialVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-functiondefinition.html#cfn-greengrass-functiondefinition-initialversion
        /// Required: False
        /// UpdateType: Immutable
        /// Type: FunctionDefinitionVersion
        /// </summary>
        public Union<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion, BaseFunction>? InitialVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-functiondefinition.html#cfn-greengrass-functiondefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FunctionDefinitionTypes
    {
        public class DefaultConfig : Humidifier.Base.BaseSubResource, IHaveGreengrassFunctionDefinitionTypesExecutionExecution
        {
            /// <summary>
            /// Execution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-defaultconfig.html#cfn-greengrass-functiondefinition-defaultconfig-execution
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Execution
            /// </summary>
            public Union<Humidifier.Greengrass.FunctionDefinitionTypes.Execution, BaseFunction>? Execution { get; set; }
        }

        public class Environment : Humidifier.Base.BaseSubResource, IHaveVariables_Json, IHaveGreengrassFunctionDefinitionTypesExecutionExecution, IHaveListOfGreengrassFunctionDefinitionTypesResourceAccessPolicyResourceAccessPolicies, IHaveAccessSysfs_Boolean
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-environment.html#cfn-greengrass-functiondefinition-environment-variables
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Variables { get; set; }
            /// <summary>
            /// Execution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-environment.html#cfn-greengrass-functiondefinition-environment-execution
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Execution
            /// </summary>
            public Union<Humidifier.Greengrass.FunctionDefinitionTypes.Execution, BaseFunction>? Execution { get; set; }
            /// <summary>
            /// ResourceAccessPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-environment.html#cfn-greengrass-functiondefinition-environment-resourceaccesspolicies
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ResourceAccessPolicy
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Greengrass.FunctionDefinitionTypes.ResourceAccessPolicy>, IReadOnlyList<Union<Humidifier.Greengrass.FunctionDefinitionTypes.ResourceAccessPolicy, BaseFunction>>, BaseFunction>? ResourceAccessPolicies { get; set; }
            /// <summary>
            /// AccessSysfs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-environment.html#cfn-greengrass-functiondefinition-environment-accesssysfs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AccessSysfs { get; set; }
        }

        public class Execution : Humidifier.Base.BaseSubResource, IHaveIsolationMode, IHaveGreengrassFunctionDefinitionTypesRunAsRunAs
        {
            /// <summary>
            /// IsolationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-execution.html#cfn-greengrass-functiondefinition-execution-isolationmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IsolationMode { get; set; }
            /// <summary>
            /// RunAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-execution.html#cfn-greengrass-functiondefinition-execution-runas
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RunAs
            /// </summary>
            public Union<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs, BaseFunction>? RunAs { get; set; }
        }

        public class Function : Humidifier.Base.BaseSubResource, IHaveFunctionArn, IHaveGreengrassFunctionDefinitionTypesFunctionConfigurationFunctionConfiguration, IHaveId
        {
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-function.html#cfn-greengrass-functiondefinition-function-functionarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionArn { get; set; }
            /// <summary>
            /// FunctionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-function.html#cfn-greengrass-functiondefinition-function-functionconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: FunctionConfiguration
            /// </summary>
            public Union<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration, BaseFunction>? FunctionConfiguration { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-function.html#cfn-greengrass-functiondefinition-function-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class FunctionConfiguration : Humidifier.Base.BaseSubResource, IHaveMemorySize_Integer, IHavePinned_Boolean, IHaveExecArgs, IHaveTimeout_Integer, IHaveEncodingType, IHaveGreengrassFunctionDefinitionTypesEnvironmentEnvironment, IHaveExecutable
        {
            /// <summary>
            /// MemorySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-memorysize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MemorySize { get; set; }
            /// <summary>
            /// Pinned
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-pinned
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Pinned { get; set; }
            /// <summary>
            /// ExecArgs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-execargs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecArgs { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-timeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// EncodingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-encodingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncodingType { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Environment
            /// </summary>
            public Union<Humidifier.Greengrass.FunctionDefinitionTypes.Environment, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// Executable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-executable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Executable { get; set; }
        }

        public class FunctionDefinitionVersion : Humidifier.Base.BaseSubResource, IHaveGreengrassFunctionDefinitionTypesDefaultConfigDefaultConfig, IHaveListOfGreengrassFunctionDefinitionTypesFunctionFunctions
        {
            /// <summary>
            /// DefaultConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functiondefinitionversion.html#cfn-greengrass-functiondefinition-functiondefinitionversion-defaultconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DefaultConfig
            /// </summary>
            public Union<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig, BaseFunction>? DefaultConfig { get; set; }
            /// <summary>
            /// Functions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functiondefinitionversion.html#cfn-greengrass-functiondefinition-functiondefinitionversion-functions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Function
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Greengrass.FunctionDefinitionTypes.Function>, IReadOnlyList<Union<Humidifier.Greengrass.FunctionDefinitionTypes.Function, BaseFunction>>, BaseFunction>? Functions { get; set; }
        }

        public class ResourceAccessPolicy : Humidifier.Base.BaseSubResource, IHaveResourceId, IHavePermission
        {
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-resourceaccesspolicy.html#cfn-greengrass-functiondefinition-resourceaccesspolicy-resourceid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceId { get; set; }
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-resourceaccesspolicy.html#cfn-greengrass-functiondefinition-resourceaccesspolicy-permission
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-runas.html#cfn-greengrass-functiondefinition-runas-uid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Uid { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-runas.html#cfn-greengrass-functiondefinition-runas-gid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Gid { get; set; }
        }
    }
}