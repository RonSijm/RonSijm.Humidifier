namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;
    using GuardHookTypes;

    public class GuardHook : Humidifier.Base.BaseResource, IHaveCloudFormationGuardHookTypesOptionsOptions, IHaveCloudFormationGuardHookTypesS3LocationRuleLocation, IHaveHookStatus, IHaveAlias, IHaveCloudFormationGuardHookTypesStackFiltersStackFilters, IHaveStringListOfTargetOperations, IHaveCloudFormationGuardHookTypesTargetFiltersTargetFilters, IHaveLogBucket, IHaveExecutionRole, IHaveFailureMode
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
        public Union<Humidifier.CloudFormation.GuardHookTypes.Options, BaseFunction>? Options { get; set; }

        /// <summary>
        /// RuleLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-rulelocation
        /// Required: True
        /// UpdateType: Mutable
        /// Type: S3Location
        /// </summary>
        [Required]
        public Union<Humidifier.CloudFormation.GuardHookTypes.S3Location, BaseFunction>? RuleLocation { get; set; }

        /// <summary>
        /// HookStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-hookstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? HookStatus { get; set; }

        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-alias
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Alias { get; set; }
        /// <summary>
        /// StackFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-stackfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StackFilters
        /// </summary>
        public Union<Humidifier.CloudFormation.GuardHookTypes.StackFilters, BaseFunction>? StackFilters { get; set; }

        /// <summary>
        /// TargetOperations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-targetoperations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetOperations { get; set; }
        /// <summary>
        /// TargetFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-targetfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TargetFilters
        /// </summary>
        public Union<Humidifier.CloudFormation.GuardHookTypes.TargetFilters, BaseFunction>? TargetFilters { get; set; }
        /// <summary>
        /// LogBucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-logbucket
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogBucket { get; set; }

        /// <summary>
        /// ExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-executionrole
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExecutionRole { get; set; }

        /// <summary>
        /// FailureMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-guardhook.html#cfn-cloudformation-guardhook-failuremode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FailureMode { get; set; }
    }

    namespace GuardHookTypes
    {
        public class HookTarget : Humidifier.Base.BaseSubResource, IHaveInvocationPoint, IHaveAction, IHaveTargetName
        {
            /// <summary>
            /// InvocationPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-hooktarget.html#cfn-cloudformation-guardhook-hooktarget-invocationpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationPoint { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-hooktarget.html#cfn-cloudformation-guardhook-hooktarget-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// TargetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-hooktarget.html#cfn-cloudformation-guardhook-hooktarget-targetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetName { get; set; }
        }

        public class Options : Humidifier.Base.BaseSubResource, IHaveCloudFormationGuardHookTypesS3LocationInputParams
        {
            /// <summary>
            /// InputParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-options.html#cfn-cloudformation-guardhook-options-inputparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.CloudFormation.GuardHookTypes.S3Location, BaseFunction>? InputParams { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveVersionId, IHaveUri
        {
            /// <summary>
            /// VersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-s3location.html#cfn-cloudformation-guardhook-s3location-versionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VersionId { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-s3location.html#cfn-cloudformation-guardhook-s3location-uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uri { get; set; }
        }

        public class StackFilters : Humidifier.Base.BaseSubResource, IHaveFilteringCriteria, IHaveCloudFormationGuardHookTypesStackNamesStackNames, IHaveCloudFormationGuardHookTypesStackRolesStackRoles
        {
            /// <summary>
            /// FilteringCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stackfilters.html#cfn-cloudformation-guardhook-stackfilters-filteringcriteria
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilteringCriteria { get; set; }
            /// <summary>
            /// StackNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stackfilters.html#cfn-cloudformation-guardhook-stackfilters-stacknames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StackNames
            /// </summary>
            public Union<Humidifier.CloudFormation.GuardHookTypes.StackNames, BaseFunction>? StackNames { get; set; }
            /// <summary>
            /// StackRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stackfilters.html#cfn-cloudformation-guardhook-stackfilters-stackroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StackRoles
            /// </summary>
            public Union<Humidifier.CloudFormation.GuardHookTypes.StackRoles, BaseFunction>? StackRoles { get; set; }
        }

        public class StackNames : Humidifier.Base.BaseSubResource, IHaveStringListOfExclude, IHaveStringListOfInclude
        {
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stacknames.html#cfn-cloudformation-guardhook-stacknames-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Exclude { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stacknames.html#cfn-cloudformation-guardhook-stacknames-include
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stackroles.html#cfn-cloudformation-guardhook-stackroles-exclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Exclude { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-stackroles.html#cfn-cloudformation-guardhook-stackroles-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Include { get; set; }
        }

        public class TargetFilters : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHaveStringListOfTargetNames, IHaveListOfCloudFormationGuardHookTypesHookTargetTargets, IHaveStringListOfInvocationPoints
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-targetfilters.html#cfn-cloudformation-guardhook-targetfilters-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// TargetNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-targetfilters.html#cfn-cloudformation-guardhook-targetfilters-targetnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetNames { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-targetfilters.html#cfn-cloudformation-guardhook-targetfilters-targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HookTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudFormation.GuardHookTypes.HookTarget>, IReadOnlyList<Union<Humidifier.CloudFormation.GuardHookTypes.HookTarget, BaseFunction>>, BaseFunction>? Targets { get; set; }
            /// <summary>
            /// InvocationPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-guardhook-targetfilters.html#cfn-cloudformation-guardhook-targetfilters-invocationpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InvocationPoints { get; set; }
        }
    }
}