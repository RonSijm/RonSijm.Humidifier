namespace Humidifier.Greengrass
{
    using System.Collections.Generic;
    using FunctionDefinitionTypes;

    public class FunctionDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDynamicTags
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
        public Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion InitialVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-functiondefinition.html#cfn-greengrass-functiondefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
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
            public Humidifier.Greengrass.FunctionDefinitionTypes.Execution Execution { get; set; }
        }

        public class Environment : Humidifier.Base.BaseSubResource, IHaveGreengrassFunctionDefinitionTypesExecutionExecution, IHaveVariables, IHaveAccessSysfs
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-environment.html#cfn-greengrass-functiondefinition-environment-variables
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Variables { get; set; }
            /// <summary>
            /// Execution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-environment.html#cfn-greengrass-functiondefinition-environment-execution
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Execution
            /// </summary>
            public Humidifier.Greengrass.FunctionDefinitionTypes.Execution Execution { get; set; }
            /// <summary>
            /// ResourceAccessPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-environment.html#cfn-greengrass-functiondefinition-environment-resourceaccesspolicies
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ResourceAccessPolicy
            /// </summary>
            public List<Humidifier.Greengrass.FunctionDefinitionTypes.ResourceAccessPolicy> ResourceAccessPolicies { get; set; }
            /// <summary>
            /// AccessSysfs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-environment.html#cfn-greengrass-functiondefinition-environment-accesssysfs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AccessSysfs { get; set; }
        }

        public class Execution : Humidifier.Base.BaseSubResource, IHaveIsolationMode
        {
            /// <summary>
            /// IsolationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-execution.html#cfn-greengrass-functiondefinition-execution-isolationmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IsolationMode { get; set; }
            /// <summary>
            /// RunAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-execution.html#cfn-greengrass-functiondefinition-execution-runas
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RunAs
            /// </summary>
            public Humidifier.Greengrass.FunctionDefinitionTypes.RunAs RunAs { get; set; }
        }

        public class Function : Humidifier.Base.BaseSubResource, IHaveId, IHaveFunctionArn
        {
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-function.html#cfn-greengrass-functiondefinition-function-functionarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionArn { get; set; }
            /// <summary>
            /// FunctionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-function.html#cfn-greengrass-functiondefinition-function-functionconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: FunctionConfiguration
            /// </summary>
            public Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration FunctionConfiguration { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-function.html#cfn-greengrass-functiondefinition-function-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class FunctionConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeout, IHaveMemorySize, IHaveEncodingType, IHavePinned, IHaveExecArgs, IHaveExecutable
        {
            /// <summary>
            /// MemorySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-memorysize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MemorySize { get; set; }
            /// <summary>
            /// Pinned
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-pinned
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Pinned { get; set; }
            /// <summary>
            /// ExecArgs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-execargs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecArgs { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-timeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Timeout { get; set; }
            /// <summary>
            /// EncodingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-encodingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncodingType { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Environment
            /// </summary>
            public Humidifier.Greengrass.FunctionDefinitionTypes.Environment Environment { get; set; }
            /// <summary>
            /// Executable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functionconfiguration.html#cfn-greengrass-functiondefinition-functionconfiguration-executable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Executable { get; set; }
        }

        public class FunctionDefinitionVersion : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functiondefinitionversion.html#cfn-greengrass-functiondefinition-functiondefinitionversion-defaultconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DefaultConfig
            /// </summary>
            public Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig DefaultConfig { get; set; }
            /// <summary>
            /// Functions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functiondefinitionversion.html#cfn-greengrass-functiondefinition-functiondefinitionversion-functions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Function
            /// </summary>
            public List<Humidifier.Greengrass.FunctionDefinitionTypes.Function> Functions { get; set; }
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
            public dynamic ResourceId { get; set; }
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-resourceaccesspolicy.html#cfn-greengrass-functiondefinition-resourceaccesspolicy-permission
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Permission { get; set; }
        }

        public class RunAs : Humidifier.Base.BaseSubResource, IHaveGid, IHaveUid
        {
            /// <summary>
            /// Uid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-runas.html#cfn-greengrass-functiondefinition-runas-uid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Uid { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-runas.html#cfn-greengrass-functiondefinition-runas-gid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Gid { get; set; }
        }
    }
}