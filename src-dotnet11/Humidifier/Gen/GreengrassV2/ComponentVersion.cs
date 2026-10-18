namespace Humidifier.GreengrassV2
{
    using global::System.Collections.Generic;
    using ComponentVersionTypes;

    public class ComponentVersion : Humidifier.Base.BaseResource, IHaveGreengrassV2ComponentVersionTypesLambdaFunctionRecipeSourceLambdaFunction, IHaveInlineRecipe, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string ComponentName =  "ComponentName" ;
            public static string Arn =  "Arn" ;
            public static string ComponentVersion =  "ComponentVersion" ;
        }

        public override string AWSTypeName { get => AWS.GreengrassV2.ComponentVersion; }
        /// <summary>
        /// LambdaFunction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-componentversion.html#cfn-greengrassv2-componentversion-lambdafunction
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LambdaFunctionRecipeSource
        /// </summary>
        public Union<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource, BaseFunction>? LambdaFunction { get; set; }
        /// <summary>
        /// InlineRecipe
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-componentversion.html#cfn-greengrassv2-componentversion-inlinerecipe
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InlineRecipe { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-componentversion.html#cfn-greengrassv2-componentversion-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ComponentVersionTypes
    {
        public class ComponentDependencyRequirement : Humidifier.Base.BaseSubResource, IHaveVersionRequirement, IHaveDependencyType
        {
            /// <summary>
            /// VersionRequirement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-componentdependencyrequirement.html#cfn-greengrassv2-componentversion-componentdependencyrequirement-versionrequirement
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VersionRequirement { get; set; }
            /// <summary>
            /// DependencyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-componentdependencyrequirement.html#cfn-greengrassv2-componentversion-componentdependencyrequirement-dependencytype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DependencyType { get; set; }
        }

        public class ComponentPlatform : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfAttributes_, IHaveName
        {
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-componentplatform.html#cfn-greengrassv2-componentversion-componentplatform-attributes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-componentplatform.html#cfn-greengrassv2-componentversion-componentplatform-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LambdaContainerParams : Humidifier.Base.BaseSubResource, IHaveListOfGreengrassV2ComponentVersionTypesLambdaVolumeMountVolumes, IHaveMountROSysfs_Boolean, IHaveMemorySizeInKB_Integer, IHaveListOfGreengrassV2ComponentVersionTypesLambdaDeviceMountDevices
        {
            /// <summary>
            /// Volumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdacontainerparams.html#cfn-greengrassv2-componentversion-lambdacontainerparams-volumes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: LambdaVolumeMount
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaVolumeMount>, IReadOnlyList<Union<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaVolumeMount, BaseFunction>>, BaseFunction>? Volumes { get; set; }
            /// <summary>
            /// MountROSysfs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdacontainerparams.html#cfn-greengrassv2-componentversion-lambdacontainerparams-mountrosysfs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MountROSysfs { get; set; }
            /// <summary>
            /// MemorySizeInKB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdacontainerparams.html#cfn-greengrassv2-componentversion-lambdacontainerparams-memorysizeinkb
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MemorySizeInKB { get; set; }
            /// <summary>
            /// Devices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdacontainerparams.html#cfn-greengrassv2-componentversion-lambdacontainerparams-devices
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: LambdaDeviceMount
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaDeviceMount>, IReadOnlyList<Union<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaDeviceMount, BaseFunction>>, BaseFunction>? Devices { get; set; }
        }

        public class LambdaDeviceMount : Humidifier.Base.BaseSubResource, IHavePath, IHaveAddGroupOwner_Boolean, IHavePermission
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdadevicemount.html#cfn-greengrassv2-componentversion-lambdadevicemount-path
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// AddGroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdadevicemount.html#cfn-greengrassv2-componentversion-lambdadevicemount-addgroupowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AddGroupOwner { get; set; }
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdadevicemount.html#cfn-greengrassv2-componentversion-lambdadevicemount-permission
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Permission { get; set; }
        }

        public class LambdaEventSource : Humidifier.Base.BaseSubResource, IHaveType, IHaveTopic
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaeventsource.html#cfn-greengrassv2-componentversion-lambdaeventsource-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Topic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaeventsource.html#cfn-greengrassv2-componentversion-lambdaeventsource-topic
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Topic { get; set; }
        }

        public class LambdaExecutionParameters : Humidifier.Base.BaseSubResource, IHaveMaxInstancesCount_Integer, IHaveTimeoutInSeconds_Integer, IHaveStringDictionaryOfEnvironmentVariables, IHaveListOfGreengrassV2ComponentVersionTypesLambdaEventSourceEventSources, IHavePinned_Boolean, IHaveStringListOfExecArgs, IHaveGreengrassV2ComponentVersionTypesLambdaLinuxProcessParamsLinuxProcessParams, IHaveInputPayloadEncodingType, IHaveMaxQueueSize_Integer, IHaveStatusTimeoutInSeconds_Integer, IHaveMaxIdleTimeInSeconds_Integer
        {
            /// <summary>
            /// MaxInstancesCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html#cfn-greengrassv2-componentversion-lambdaexecutionparameters-maxinstancescount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxInstancesCount { get; set; }
            /// <summary>
            /// TimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html#cfn-greengrassv2-componentversion-lambdaexecutionparameters-timeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInSeconds { get; set; }
            /// <summary>
            /// EnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html#cfn-greengrassv2-componentversion-lambdaexecutionparameters-environmentvariables
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
            /// <summary>
            /// EventSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html#cfn-greengrassv2-componentversion-lambdaexecutionparameters-eventsources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: LambdaEventSource
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaEventSource>, IReadOnlyList<Union<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaEventSource, BaseFunction>>, BaseFunction>? EventSources { get; set; }
            /// <summary>
            /// Pinned
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html#cfn-greengrassv2-componentversion-lambdaexecutionparameters-pinned
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Pinned { get; set; }
            /// <summary>
            /// ExecArgs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html#cfn-greengrassv2-componentversion-lambdaexecutionparameters-execargs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExecArgs { get; set; }
            /// <summary>
            /// LinuxProcessParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html#cfn-greengrassv2-componentversion-lambdaexecutionparameters-linuxprocessparams
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LambdaLinuxProcessParams
            /// </summary>
            public Union<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams, BaseFunction>? LinuxProcessParams { get; set; }
            /// <summary>
            /// InputPayloadEncodingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html#cfn-greengrassv2-componentversion-lambdaexecutionparameters-inputpayloadencodingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputPayloadEncodingType { get; set; }
            /// <summary>
            /// MaxQueueSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html#cfn-greengrassv2-componentversion-lambdaexecutionparameters-maxqueuesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxQueueSize { get; set; }
            /// <summary>
            /// StatusTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html#cfn-greengrassv2-componentversion-lambdaexecutionparameters-statustimeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StatusTimeoutInSeconds { get; set; }
            /// <summary>
            /// MaxIdleTimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaexecutionparameters.html#cfn-greengrassv2-componentversion-lambdaexecutionparameters-maxidletimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxIdleTimeInSeconds { get; set; }
        }

        public class LambdaFunctionRecipeSource : Humidifier.Base.BaseSubResource, IHaveMapOfGreengrassV2ComponentVersionTypesComponentDependencyRequirementComponentDependencies, IHaveGreengrassV2ComponentVersionTypesLambdaExecutionParametersComponentLambdaParameters, IHaveLambdaArn, IHaveListOfGreengrassV2ComponentVersionTypesComponentPlatformComponentPlatforms, IHaveComponentName, IHaveComponentVersion
        {
            /// <summary>
            /// ComponentDependencies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdafunctionrecipesource.html#cfn-greengrassv2-componentversion-lambdafunctionrecipesource-componentdependencies
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: ComponentDependencyRequirement
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.GreengrassV2.ComponentVersionTypes.ComponentDependencyRequirement>, IReadOnlyDictionary<string, Union<Humidifier.GreengrassV2.ComponentVersionTypes.ComponentDependencyRequirement, BaseFunction>>, BaseFunction>? ComponentDependencies { get; set; }
            /// <summary>
            /// ComponentLambdaParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdafunctionrecipesource.html#cfn-greengrassv2-componentversion-lambdafunctionrecipesource-componentlambdaparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LambdaExecutionParameters
            /// </summary>
            public Union<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters, BaseFunction>? ComponentLambdaParameters { get; set; }
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdafunctionrecipesource.html#cfn-greengrassv2-componentversion-lambdafunctionrecipesource-lambdaarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
            /// <summary>
            /// ComponentPlatforms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdafunctionrecipesource.html#cfn-greengrassv2-componentversion-lambdafunctionrecipesource-componentplatforms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ComponentPlatform
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GreengrassV2.ComponentVersionTypes.ComponentPlatform>, IReadOnlyList<Union<Humidifier.GreengrassV2.ComponentVersionTypes.ComponentPlatform, BaseFunction>>, BaseFunction>? ComponentPlatforms { get; set; }
            /// <summary>
            /// ComponentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdafunctionrecipesource.html#cfn-greengrassv2-componentversion-lambdafunctionrecipesource-componentname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentName { get; set; }
            /// <summary>
            /// ComponentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdafunctionrecipesource.html#cfn-greengrassv2-componentversion-lambdafunctionrecipesource-componentversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentVersion { get; set; }
        }

        public class LambdaLinuxProcessParams : Humidifier.Base.BaseSubResource, IHaveIsolationMode, IHaveGreengrassV2ComponentVersionTypesLambdaContainerParamsContainerParams
        {
            /// <summary>
            /// IsolationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdalinuxprocessparams.html#cfn-greengrassv2-componentversion-lambdalinuxprocessparams-isolationmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IsolationMode { get; set; }
            /// <summary>
            /// ContainerParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdalinuxprocessparams.html#cfn-greengrassv2-componentversion-lambdalinuxprocessparams-containerparams
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LambdaContainerParams
            /// </summary>
            public Union<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams, BaseFunction>? ContainerParams { get; set; }
        }

        public class LambdaVolumeMount : Humidifier.Base.BaseSubResource, IHaveSourcePath, IHaveDestinationPath, IHaveAddGroupOwner_Boolean, IHavePermission
        {
            /// <summary>
            /// SourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdavolumemount.html#cfn-greengrassv2-componentversion-lambdavolumemount-sourcepath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourcePath { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdavolumemount.html#cfn-greengrassv2-componentversion-lambdavolumemount-destinationpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPath { get; set; }
            /// <summary>
            /// AddGroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdavolumemount.html#cfn-greengrassv2-componentversion-lambdavolumemount-addgroupowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AddGroupOwner { get; set; }
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdavolumemount.html#cfn-greengrassv2-componentversion-lambdavolumemount-permission
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Permission { get; set; }
        }
    }
}