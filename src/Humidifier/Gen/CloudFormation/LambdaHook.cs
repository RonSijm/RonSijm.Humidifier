namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;
    using LambdaHookTypes;

    public class LambdaHook : Humidifier.Base.BaseResource, IHaveExecutionRole, IHaveAlias, IHaveHookStatus, IHaveTargetOperations, IHaveFailureMode
    {
        public class Attributes
        {
            public static string HookArn =  "HookArn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.LambdaHook; }

        /// <summary>
        /// HookStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-hookstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic HookStatus { get; set; }

        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-alias
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Alias { get; set; }
        /// <summary>
        /// StackFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-stackfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StackFilters
        /// </summary>
        public Humidifier.CloudFormation.LambdaHookTypes.StackFilters StackFilters { get; set; }

        /// <summary>
        /// TargetOperations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-targetoperations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic TargetOperations { get; set; }
        /// <summary>
        /// TargetFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-targetfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TargetFilters
        /// </summary>
        public Humidifier.CloudFormation.LambdaHookTypes.TargetFilters TargetFilters { get; set; }

        /// <summary>
        /// LambdaFunction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-lambdafunction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LambdaFunction { get; set; }

        /// <summary>
        /// ExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-executionrole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ExecutionRole { get; set; }

        /// <summary>
        /// FailureMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-lambdahook.html#cfn-cloudformation-lambdahook-failuremode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FailureMode { get; set; }
    }

    namespace LambdaHookTypes
    {
        public class HookTarget : Humidifier.Base.BaseSubResource, IHaveAction, IHaveTargetName, IHaveInvocationPoint
        {
            /// <summary>
            /// InvocationPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-hooktarget.html#cfn-cloudformation-lambdahook-hooktarget-invocationpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationPoint { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-hooktarget.html#cfn-cloudformation-lambdahook-hooktarget-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// TargetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-hooktarget.html#cfn-cloudformation-lambdahook-hooktarget-targetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetName { get; set; }
        }

        public class StackFilters : Humidifier.Base.BaseSubResource, IHaveFilteringCriteria
        {
            /// <summary>
            /// FilteringCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stackfilters.html#cfn-cloudformation-lambdahook-stackfilters-filteringcriteria
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilteringCriteria { get; set; }
            /// <summary>
            /// StackNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stackfilters.html#cfn-cloudformation-lambdahook-stackfilters-stacknames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StackNames
            /// </summary>
            public Humidifier.CloudFormation.LambdaHookTypes.StackNames StackNames { get; set; }
            /// <summary>
            /// StackRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stackfilters.html#cfn-cloudformation-lambdahook-stackfilters-stackroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StackRoles
            /// </summary>
            public Humidifier.CloudFormation.LambdaHookTypes.StackRoles StackRoles { get; set; }
        }

        public class StackNames : Humidifier.Base.BaseSubResource, IHaveInclude, IHaveExclude
        {
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stacknames.html#cfn-cloudformation-lambdahook-stacknames-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Exclude { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stacknames.html#cfn-cloudformation-lambdahook-stacknames-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Include { get; set; }
        }

        public class StackRoles : Humidifier.Base.BaseSubResource, IHaveInclude, IHaveExclude
        {
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stackroles.html#cfn-cloudformation-lambdahook-stackroles-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Exclude { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-stackroles.html#cfn-cloudformation-lambdahook-stackroles-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Include { get; set; }
        }

        public class TargetFilters : Humidifier.Base.BaseSubResource, IHaveActions, IHaveTargetNames, IHaveInvocationPoints
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-targetfilters.html#cfn-cloudformation-lambdahook-targetfilters-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// TargetNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-targetfilters.html#cfn-cloudformation-lambdahook-targetfilters-targetnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TargetNames { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-targetfilters.html#cfn-cloudformation-lambdahook-targetfilters-targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HookTarget
            /// </summary>
            public List<Humidifier.CloudFormation.LambdaHookTypes.HookTarget> Targets { get; set; }
            /// <summary>
            /// InvocationPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-lambdahook-targetfilters.html#cfn-cloudformation-lambdahook-targetfilters-invocationpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InvocationPoints { get; set; }
        }
    }
}