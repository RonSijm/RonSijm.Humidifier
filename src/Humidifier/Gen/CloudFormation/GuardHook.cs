namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;
    using GuardHookTypes;

    public class GuardHook : Humidifier.Base.BaseResource, IHaveExecutionRole, IHaveAlias
    {
        public class Attributes
        {
            public static string HookArn =  "HookArn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.GuardHook; }
        /// <summary>
        /// Options
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-options
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Options
        /// </summary>
        public Humidifier.CloudFormation.GuardHookTypes.Options Options { get; set; }

        /// <summary>
        /// RuleLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-rulelocation
        /// Required: True
        /// UpdateType: Mutable
        /// Type: S3Location
        /// </summary>
        [Required]
        public Humidifier.CloudFormation.GuardHookTypes.S3Location RuleLocation { get; set; }

        /// <summary>
        /// HookStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-hookstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic HookStatus { get; set; }

        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-alias
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Alias { get; set; }
        /// <summary>
        /// StackFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-stackfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StackFilters
        /// </summary>
        public Humidifier.CloudFormation.GuardHookTypes.StackFilters StackFilters { get; set; }

        /// <summary>
        /// TargetOperations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-targetoperations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic TargetOperations { get; set; }
        /// <summary>
        /// TargetFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-targetfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TargetFilters
        /// </summary>
        public Humidifier.CloudFormation.GuardHookTypes.TargetFilters TargetFilters { get; set; }
        /// <summary>
        /// LogBucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-logbucket
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LogBucket { get; set; }

        /// <summary>
        /// ExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-executionrole
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ExecutionRole { get; set; }

        /// <summary>
        /// FailureMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-failuremode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FailureMode { get; set; }
    }

    namespace GuardHookTypes
    {
        public class HookTarget : Humidifier.Base.BaseSubResource, IHaveAction
        {
            /// <summary>
            /// InvocationPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-hooktarget.html#cfn-cloudformation-guardhook-hooktarget-invocationpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationPoint { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-hooktarget.html#cfn-cloudformation-guardhook-hooktarget-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// TargetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-hooktarget.html#cfn-cloudformation-guardhook-hooktarget-targetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetName { get; set; }
        }

        public class Options : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-options.html#cfn-cloudformation-guardhook-options-inputparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Humidifier.CloudFormation.GuardHookTypes.S3Location InputParams { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveUri, IHaveVersionId
        {
            /// <summary>
            /// VersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-s3location.html#cfn-cloudformation-guardhook-s3location-versionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VersionId { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-s3location.html#cfn-cloudformation-guardhook-s3location-uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Uri { get; set; }
        }

        public class StackFilters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FilteringCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stackfilters.html#cfn-cloudformation-guardhook-stackfilters-filteringcriteria
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilteringCriteria { get; set; }
            /// <summary>
            /// StackNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stackfilters.html#cfn-cloudformation-guardhook-stackfilters-stacknames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StackNames
            /// </summary>
            public Humidifier.CloudFormation.GuardHookTypes.StackNames StackNames { get; set; }
            /// <summary>
            /// StackRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stackfilters.html#cfn-cloudformation-guardhook-stackfilters-stackroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StackRoles
            /// </summary>
            public Humidifier.CloudFormation.GuardHookTypes.StackRoles StackRoles { get; set; }
        }

        public class StackNames : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stacknames.html#cfn-cloudformation-guardhook-stacknames-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Exclude { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stacknames.html#cfn-cloudformation-guardhook-stacknames-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Include { get; set; }
        }

        public class StackRoles : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stackroles.html#cfn-cloudformation-guardhook-stackroles-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Exclude { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stackroles.html#cfn-cloudformation-guardhook-stackroles-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Include { get; set; }
        }

        public class TargetFilters : Humidifier.Base.BaseSubResource, IHaveActions
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-targetfilters.html#cfn-cloudformation-guardhook-targetfilters-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// TargetNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-targetfilters.html#cfn-cloudformation-guardhook-targetfilters-targetnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TargetNames { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-targetfilters.html#cfn-cloudformation-guardhook-targetfilters-targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HookTarget
            /// </summary>
            public List<Humidifier.CloudFormation.GuardHookTypes.HookTarget> Targets { get; set; }
            /// <summary>
            /// InvocationPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-targetfilters.html#cfn-cloudformation-guardhook-targetfilters-invocationpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InvocationPoints { get; set; }
        }
    }
}