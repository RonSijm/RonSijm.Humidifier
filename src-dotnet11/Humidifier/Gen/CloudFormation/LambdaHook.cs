namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;
    using LambdaHookTypes;

    public class LambdaHook : Humidifier.Base.BaseResource, IHaveAutoUpdate_Boolean, IHaveHookStatus, IHaveAlias, IHaveCloudFormationLambdaHookTypesLoggingConfigLoggingConfig, IHaveCloudFormationLambdaHookTypesStackFiltersStackFilters, IHaveStringListOfTargetOperations, IHaveCloudFormationLambdaHookTypesTargetFiltersTargetFilters, IHaveLambdaFunction, IHaveExecutionRole, IHaveFailureMode
    {
        public class Attributes
        {
            public static string HookArn =  "HookArn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.LambdaHook; }
        /// <summary>
        /// AutoUpdate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-autoupdate
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoUpdate { get; set; }

        /// <summary>
        /// HookStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-hookstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? HookStatus { get; set; }

        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-alias
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Alias { get; set; }
        /// <summary>
        /// LoggingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-loggingconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LoggingConfig
        /// </summary>
        public Union<Humidifier.CloudFormation.LambdaHookTypes.LoggingConfig, BaseFunction>? LoggingConfig { get; set; }
        /// <summary>
        /// StackFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-stackfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StackFilters
        /// </summary>
        public Union<Humidifier.CloudFormation.LambdaHookTypes.StackFilters, BaseFunction>? StackFilters { get; set; }

        /// <summary>
        /// TargetOperations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-targetoperations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetOperations { get; set; }
        /// <summary>
        /// TargetFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-targetfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TargetFilters
        /// </summary>
        public Union<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters, BaseFunction>? TargetFilters { get; set; }

        /// <summary>
        /// LambdaFunction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-lambdafunction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LambdaFunction { get; set; }

        /// <summary>
        /// ExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-executionrole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExecutionRole { get; set; }

        /// <summary>
        /// FailureMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-failuremode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FailureMode { get; set; }
    }

    namespace LambdaHookTypes
    {
        public class HookTarget : Humidifier.Base.BaseSubResource, IHaveInvocationPoint, IHaveAction, IHaveTargetName
        {
            /// <summary>
            /// InvocationPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-hooktarget.html#cfn-cloudformation-lambdahook-hooktarget-invocationpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationPoint { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-hooktarget.html#cfn-cloudformation-lambdahook-hooktarget-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// TargetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-hooktarget.html#cfn-cloudformation-lambdahook-hooktarget-targetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetName { get; set; }
        }

        public class LoggingConfig : Humidifier.Base.BaseSubResource, IHaveLogGroupName, IHaveLogRoleArn
        {
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-loggingconfig.html#cfn-cloudformation-lambdahook-loggingconfig-loggroupname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
            /// <summary>
            /// LogRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-loggingconfig.html#cfn-cloudformation-lambdahook-loggingconfig-logrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogRoleArn { get; set; }
        }

        public class StackFilters : Humidifier.Base.BaseSubResource, IHaveFilteringCriteria, IHaveCloudFormationLambdaHookTypesStackNamesStackNames, IHaveCloudFormationLambdaHookTypesStackRolesStackRoles
        {
            /// <summary>
            /// FilteringCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stackfilters.html#cfn-cloudformation-lambdahook-stackfilters-filteringcriteria
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilteringCriteria { get; set; }
            /// <summary>
            /// StackNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stackfilters.html#cfn-cloudformation-lambdahook-stackfilters-stacknames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StackNames
            /// </summary>
            public Union<Humidifier.CloudFormation.LambdaHookTypes.StackNames, BaseFunction>? StackNames { get; set; }
            /// <summary>
            /// StackRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stackfilters.html#cfn-cloudformation-lambdahook-stackfilters-stackroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StackRoles
            /// </summary>
            public Union<Humidifier.CloudFormation.LambdaHookTypes.StackRoles, BaseFunction>? StackRoles { get; set; }
        }

        public class StackNames : Humidifier.Base.BaseSubResource, IHaveStringListOfExclude, IHaveStringListOfInclude
        {
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stacknames.html#cfn-cloudformation-lambdahook-stacknames-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Exclude { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stacknames.html#cfn-cloudformation-lambdahook-stacknames-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Include { get; set; }
        }

        public class StackRoles : Humidifier.Base.BaseSubResource, IHaveStringListOfExclude, IHaveStringListOfInclude
        {
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stackroles.html#cfn-cloudformation-lambdahook-stackroles-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Exclude { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stackroles.html#cfn-cloudformation-lambdahook-stackroles-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Include { get; set; }
        }

        public class TargetFilters : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHaveStringListOfTargetNames, IHaveListOfCloudFormationLambdaHookTypesHookTargetTargets, IHaveStringListOfInvocationPoints
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-targetfilters.html#cfn-cloudformation-lambdahook-targetfilters-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// TargetNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-targetfilters.html#cfn-cloudformation-lambdahook-targetfilters-targetnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetNames { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-targetfilters.html#cfn-cloudformation-lambdahook-targetfilters-targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HookTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFormation.LambdaHookTypes.HookTarget>, IReadOnlyList<Union<Humidifier.CloudFormation.LambdaHookTypes.HookTarget, BaseFunction>>, BaseFunction>? Targets { get; set; }
            /// <summary>
            /// InvocationPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-targetfilters.html#cfn-cloudformation-lambdahook-targetfilters-invocationpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InvocationPoints { get; set; }
        }
    }
}