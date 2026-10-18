namespace Humidifier.DLM
{
    using global::System.Collections.Generic;
    using LifecyclePolicyTypes;

    public class LifecyclePolicy : Humidifier.Base.BaseResource, IHaveTags, IHaveExecutionRoleArn, IHaveDefaultPolicy, IHaveCreateInterval_Integer, IHaveDescription, IHaveExtendDeletion_Boolean, IHaveDLMLifecyclePolicyTypesExclusionsExclusions, IHaveState, IHaveListOfDLMLifecyclePolicyTypesCrossRegionCopyTargetCrossRegionCopyTargets, IHaveDLMLifecyclePolicyTypesPolicyDetailsPolicyDetails, IHaveRetainInterval_Integer, IHaveCopyTags_Boolean
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string PolicyId =  "PolicyId" ;
        }

        public override string AWSTypeName { get => AWS.DLM.LifecyclePolicy; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-executionrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// DefaultPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-defaultpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultPolicy { get; set; }
        /// <summary>
        /// CreateInterval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-createinterval
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? CreateInterval { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ExtendDeletion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-extenddeletion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ExtendDeletion { get; set; }
        /// <summary>
        /// Exclusions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-exclusions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Exclusions
        /// </summary>
        public Union<Humidifier.DLM.LifecyclePolicyTypes.Exclusions, BaseFunction>? Exclusions { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? State { get; set; }
        /// <summary>
        /// CrossRegionCopyTargets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-crossregioncopytargets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CrossRegionCopyTarget
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTarget>, IReadOnlyList<Union<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTarget, BaseFunction>>, BaseFunction>? CrossRegionCopyTargets { get; set; }
        /// <summary>
        /// PolicyDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-policydetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PolicyDetails
        /// </summary>
        public Union<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails, BaseFunction>? PolicyDetails { get; set; }
        /// <summary>
        /// RetainInterval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-retaininterval
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? RetainInterval { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// CopyTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-copytags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CopyTags { get; set; }
    }

    namespace LifecyclePolicyTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveListOfDLMLifecyclePolicyTypesCrossRegionCopyActionCrossRegionCopy, IHaveName
        {
            /// <summary>
            /// CrossRegionCopy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-action.html#cfn-dlm-lifecyclepolicy-action-crossregioncopy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CrossRegionCopyAction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyAction>, IReadOnlyList<Union<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyAction, BaseFunction>>, BaseFunction>? CrossRegionCopy { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-action.html#cfn-dlm-lifecyclepolicy-action-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ArchiveRetainRule : Humidifier.Base.BaseSubResource, IHaveDLMLifecyclePolicyTypesRetentionArchiveTierRetentionArchiveTier
        {
            /// <summary>
            /// RetentionArchiveTier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-archiveretainrule.html#cfn-dlm-lifecyclepolicy-archiveretainrule-retentionarchivetier
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RetentionArchiveTier
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.RetentionArchiveTier, BaseFunction>? RetentionArchiveTier { get; set; }
        }

        public class ArchiveRule : Humidifier.Base.BaseSubResource, IHaveDLMLifecyclePolicyTypesArchiveRetainRuleRetainRule
        {
            /// <summary>
            /// RetainRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-archiverule.html#cfn-dlm-lifecyclepolicy-archiverule-retainrule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ArchiveRetainRule
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.ArchiveRetainRule, BaseFunction>? RetainRule { get; set; }
        }

        public class CreateRule : Humidifier.Base.BaseSubResource, IHaveIntervalUnit, IHaveListOfDLMLifecyclePolicyTypesScriptScripts, IHaveStringListOfTimes, IHaveCronExpression, IHaveInterval_Integer, IHaveLocation
        {
            /// <summary>
            /// IntervalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html#cfn-dlm-lifecyclepolicy-createrule-intervalunit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntervalUnit { get; set; }
            /// <summary>
            /// Scripts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html#cfn-dlm-lifecyclepolicy-createrule-scripts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Script
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DLM.LifecyclePolicyTypes.Script>, IReadOnlyList<Union<Humidifier.DLM.LifecyclePolicyTypes.Script, BaseFunction>>, BaseFunction>? Scripts { get; set; }
            /// <summary>
            /// Times
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html#cfn-dlm-lifecyclepolicy-createrule-times
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Times { get; set; }
            /// <summary>
            /// CronExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html#cfn-dlm-lifecyclepolicy-createrule-cronexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CronExpression { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html#cfn-dlm-lifecyclepolicy-createrule-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html#cfn-dlm-lifecyclepolicy-createrule-location
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }

        public class CrossRegionCopyAction : Humidifier.Base.BaseSubResource, IHaveTarget, IHaveDLMLifecyclePolicyTypesEncryptionConfigurationEncryptionConfiguration, IHaveDLMLifecyclePolicyTypesCrossRegionCopyRetainRuleRetainRule
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyaction.html#cfn-dlm-lifecyclepolicy-crossregioncopyaction-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyaction.html#cfn-dlm-lifecyclepolicy-crossregioncopyaction-encryptionconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EncryptionConfiguration
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
            /// <summary>
            /// RetainRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyaction.html#cfn-dlm-lifecyclepolicy-crossregioncopyaction-retainrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CrossRegionCopyRetainRule
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyRetainRule, BaseFunction>? RetainRule { get; set; }
        }

        public class CrossRegionCopyDeprecateRule : Humidifier.Base.BaseSubResource, IHaveIntervalUnit, IHaveInterval_Integer
        {
            /// <summary>
            /// IntervalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopydeprecaterule.html#cfn-dlm-lifecyclepolicy-crossregioncopydeprecaterule-intervalunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntervalUnit { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopydeprecaterule.html#cfn-dlm-lifecyclepolicy-crossregioncopydeprecaterule-interval
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
        }

        public class CrossRegionCopyRetainRule : Humidifier.Base.BaseSubResource, IHaveIntervalUnit, IHaveInterval_Integer
        {
            /// <summary>
            /// IntervalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyretainrule.html#cfn-dlm-lifecyclepolicy-crossregioncopyretainrule-intervalunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntervalUnit { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyretainrule.html#cfn-dlm-lifecyclepolicy-crossregioncopyretainrule-interval
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
        }

        public class CrossRegionCopyRule : Humidifier.Base.BaseSubResource, IHaveTargetRegion, IHaveTarget, IHaveDLMLifecyclePolicyTypesCrossRegionCopyDeprecateRuleDeprecateRule, IHaveEncrypted_Boolean, IHaveCmkArn, IHaveDLMLifecyclePolicyTypesCrossRegionCopyRetainRuleRetainRule, IHaveCopyTags_Boolean
        {
            /// <summary>
            /// TargetRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyrule.html#cfn-dlm-lifecyclepolicy-crossregioncopyrule-targetregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetRegion { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyrule.html#cfn-dlm-lifecyclepolicy-crossregioncopyrule-target
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// DeprecateRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyrule.html#cfn-dlm-lifecyclepolicy-crossregioncopyrule-deprecaterule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CrossRegionCopyDeprecateRule
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyDeprecateRule, BaseFunction>? DeprecateRule { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyrule.html#cfn-dlm-lifecyclepolicy-crossregioncopyrule-encrypted
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// CmkArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyrule.html#cfn-dlm-lifecyclepolicy-crossregioncopyrule-cmkarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CmkArn { get; set; }
            /// <summary>
            /// RetainRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyrule.html#cfn-dlm-lifecyclepolicy-crossregioncopyrule-retainrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CrossRegionCopyRetainRule
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyRetainRule, BaseFunction>? RetainRule { get; set; }
            /// <summary>
            /// CopyTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyrule.html#cfn-dlm-lifecyclepolicy-crossregioncopyrule-copytags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CopyTags { get; set; }
        }

        public class CrossRegionCopyTarget : Humidifier.Base.BaseSubResource, IHaveTargetRegion
        {
            /// <summary>
            /// TargetRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopytarget.html#cfn-dlm-lifecyclepolicy-crossregioncopytarget-targetregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetRegion { get; set; }
        }

        public class DeprecateRule : Humidifier.Base.BaseSubResource, IHaveIntervalUnit, IHaveCount_Integer, IHaveInterval_Integer
        {
            /// <summary>
            /// IntervalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-deprecaterule.html#cfn-dlm-lifecyclepolicy-deprecaterule-intervalunit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntervalUnit { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-deprecaterule.html#cfn-dlm-lifecyclepolicy-deprecaterule-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Count { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-deprecaterule.html#cfn-dlm-lifecyclepolicy-deprecaterule-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveEncrypted_Boolean, IHaveCmkArn
        {
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-encryptionconfiguration.html#cfn-dlm-lifecyclepolicy-encryptionconfiguration-encrypted
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// CmkArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-encryptionconfiguration.html#cfn-dlm-lifecyclepolicy-encryptionconfiguration-cmkarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CmkArn { get; set; }
        }

        public class EventParameters : Humidifier.Base.BaseSubResource, IHaveEventType, IHaveStringListOfSnapshotOwner, IHaveDescriptionRegex
        {
            /// <summary>
            /// EventType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-eventparameters.html#cfn-dlm-lifecyclepolicy-eventparameters-eventtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventType { get; set; }
            /// <summary>
            /// SnapshotOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-eventparameters.html#cfn-dlm-lifecyclepolicy-eventparameters-snapshotowner
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SnapshotOwner { get; set; }
            /// <summary>
            /// DescriptionRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-eventparameters.html#cfn-dlm-lifecyclepolicy-eventparameters-descriptionregex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DescriptionRegex { get; set; }
        }

        public class EventSource : Humidifier.Base.BaseSubResource, IHaveType, IHaveDLMLifecyclePolicyTypesEventParametersParameters
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-eventsource.html#cfn-dlm-lifecyclepolicy-eventsource-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-eventsource.html#cfn-dlm-lifecyclepolicy-eventsource-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventParameters
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.EventParameters, BaseFunction>? Parameters { get; set; }
        }

        public class Exclusions : Humidifier.Base.BaseSubResource, IHaveTagListOfExcludeTags, IHaveStringListOfExcludeVolumeTypes, IHaveExcludeBootVolumes_Boolean
        {
            /// <summary>
            /// ExcludeTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-exclusions.html#cfn-dlm-lifecyclepolicy-exclusions-excludetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? ExcludeTags { get; set; }
            /// <summary>
            /// ExcludeVolumeTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-exclusions.html#cfn-dlm-lifecyclepolicy-exclusions-excludevolumetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludeVolumeTypes { get; set; }
            /// <summary>
            /// ExcludeBootVolumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-exclusions.html#cfn-dlm-lifecyclepolicy-exclusions-excludebootvolumes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExcludeBootVolumes { get; set; }
        }

        public class FastRestoreRule : Humidifier.Base.BaseSubResource, IHaveIntervalUnit, IHaveStringListOfAvailabilityZoneIds, IHaveStringListOfAvailabilityZones, IHaveCount_Integer, IHaveInterval_Integer
        {
            /// <summary>
            /// IntervalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-fastrestorerule.html#cfn-dlm-lifecyclepolicy-fastrestorerule-intervalunit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntervalUnit { get; set; }
            /// <summary>
            /// AvailabilityZoneIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-fastrestorerule.html#cfn-dlm-lifecyclepolicy-fastrestorerule-availabilityzoneids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailabilityZoneIds { get; set; }
            /// <summary>
            /// AvailabilityZones
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-fastrestorerule.html#cfn-dlm-lifecyclepolicy-fastrestorerule-availabilityzones
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailabilityZones { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-fastrestorerule.html#cfn-dlm-lifecyclepolicy-fastrestorerule-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Count { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-fastrestorerule.html#cfn-dlm-lifecyclepolicy-fastrestorerule-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
        }

        public class Parameters : Humidifier.Base.BaseSubResource, IHaveExcludeBootVolume_Boolean, IHaveTagListOfExcludeDataVolumeTags, IHaveNoReboot_Boolean
        {
            /// <summary>
            /// ExcludeBootVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-parameters.html#cfn-dlm-lifecyclepolicy-parameters-excludebootvolume
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExcludeBootVolume { get; set; }
            /// <summary>
            /// ExcludeDataVolumeTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-parameters.html#cfn-dlm-lifecyclepolicy-parameters-excludedatavolumetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? ExcludeDataVolumeTags { get; set; }
            /// <summary>
            /// NoReboot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-parameters.html#cfn-dlm-lifecyclepolicy-parameters-noreboot
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? NoReboot { get; set; }
        }

        public class PolicyDetails : Humidifier.Base.BaseSubResource, IHavePolicyLanguage, IHaveStringListOfResourceTypes, IHaveListOfDLMLifecyclePolicyTypesScheduleSchedules, IHavePolicyType, IHaveCreateInterval_Integer, IHaveDLMLifecyclePolicyTypesParametersParameters, IHaveExtendDeletion_Boolean, IHaveDLMLifecyclePolicyTypesExclusionsExclusions, IHaveListOfDLMLifecyclePolicyTypesActionActions, IHaveResourceType, IHaveRetainInterval_Integer, IHaveDLMLifecyclePolicyTypesEventSourceEventSource, IHaveListOfDLMLifecyclePolicyTypesCrossRegionCopyTargetCrossRegionCopyTargets, IHaveTagListOfTargetTags, IHaveStringListOfResourceLocations, IHaveCopyTags_Boolean
        {
            /// <summary>
            /// PolicyLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-policylanguage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyLanguage { get; set; }
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-resourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceTypes { get; set; }
            /// <summary>
            /// Schedules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-schedules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Schedule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DLM.LifecyclePolicyTypes.Schedule>, IReadOnlyList<Union<Humidifier.DLM.LifecyclePolicyTypes.Schedule, BaseFunction>>, BaseFunction>? Schedules { get; set; }
            /// <summary>
            /// PolicyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-policytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyType { get; set; }
            /// <summary>
            /// CreateInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-createinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CreateInterval { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Parameters
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.Parameters, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// ExtendDeletion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-extenddeletion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExtendDeletion { get; set; }
            /// <summary>
            /// Exclusions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-exclusions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Exclusions
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.Exclusions, BaseFunction>? Exclusions { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Action
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DLM.LifecyclePolicyTypes.Action>, IReadOnlyList<Union<Humidifier.DLM.LifecyclePolicyTypes.Action, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// RetainInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-retaininterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetainInterval { get; set; }
            /// <summary>
            /// EventSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-eventsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventSource
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.EventSource, BaseFunction>? EventSource { get; set; }
            /// <summary>
            /// CrossRegionCopyTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-crossregioncopytargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CrossRegionCopyTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTarget>, IReadOnlyList<Union<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTarget, BaseFunction>>, BaseFunction>? CrossRegionCopyTargets { get; set; }
            /// <summary>
            /// TargetTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-targettags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? TargetTags { get; set; }
            /// <summary>
            /// ResourceLocations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-resourcelocations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceLocations { get; set; }
            /// <summary>
            /// CopyTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-copytags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CopyTags { get; set; }
        }

        public class RetainRule : Humidifier.Base.BaseSubResource, IHaveIntervalUnit, IHaveCount_Integer, IHaveInterval_Integer
        {
            /// <summary>
            /// IntervalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-retainrule.html#cfn-dlm-lifecyclepolicy-retainrule-intervalunit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntervalUnit { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-retainrule.html#cfn-dlm-lifecyclepolicy-retainrule-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Count { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-retainrule.html#cfn-dlm-lifecyclepolicy-retainrule-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
        }

        public class RetentionArchiveTier : Humidifier.Base.BaseSubResource, IHaveIntervalUnit, IHaveCount_Integer, IHaveInterval_Integer
        {
            /// <summary>
            /// IntervalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-retentionarchivetier.html#cfn-dlm-lifecyclepolicy-retentionarchivetier-intervalunit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntervalUnit { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-retentionarchivetier.html#cfn-dlm-lifecyclepolicy-retentionarchivetier-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Count { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-retentionarchivetier.html#cfn-dlm-lifecyclepolicy-retentionarchivetier-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveListOfDLMLifecyclePolicyTypesShareRuleShareRules, IHaveDLMLifecyclePolicyTypesDeprecateRuleDeprecateRule, IHaveTagListOfTagsToAdd, IHaveDLMLifecyclePolicyTypesCreateRuleCreateRule, IHaveTagListOfVariableTags, IHaveDLMLifecyclePolicyTypesFastRestoreRuleFastRestoreRule, IHaveDLMLifecyclePolicyTypesArchiveRuleArchiveRule, IHaveDLMLifecyclePolicyTypesRetainRuleRetainRule, IHaveListOfDLMLifecyclePolicyTypesCrossRegionCopyRuleCrossRegionCopyRules, IHaveName, IHaveCopyTags_Boolean
        {
            /// <summary>
            /// ShareRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-sharerules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ShareRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DLM.LifecyclePolicyTypes.ShareRule>, IReadOnlyList<Union<Humidifier.DLM.LifecyclePolicyTypes.ShareRule, BaseFunction>>, BaseFunction>? ShareRules { get; set; }
            /// <summary>
            /// DeprecateRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-deprecaterule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeprecateRule
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.DeprecateRule, BaseFunction>? DeprecateRule { get; set; }
            /// <summary>
            /// TagsToAdd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-tagstoadd
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? TagsToAdd { get; set; }
            /// <summary>
            /// CreateRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-createrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CreateRule
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.CreateRule, BaseFunction>? CreateRule { get; set; }
            /// <summary>
            /// VariableTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-variabletags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? VariableTags { get; set; }
            /// <summary>
            /// FastRestoreRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-fastrestorerule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FastRestoreRule
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.FastRestoreRule, BaseFunction>? FastRestoreRule { get; set; }
            /// <summary>
            /// ArchiveRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-archiverule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveRule
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.ArchiveRule, BaseFunction>? ArchiveRule { get; set; }
            /// <summary>
            /// RetainRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-retainrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetainRule
            /// </summary>
            public Union<Humidifier.DLM.LifecyclePolicyTypes.RetainRule, BaseFunction>? RetainRule { get; set; }
            /// <summary>
            /// CrossRegionCopyRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-crossregioncopyrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CrossRegionCopyRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyRule>, IReadOnlyList<Union<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyRule, BaseFunction>>, BaseFunction>? CrossRegionCopyRules { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// CopyTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-copytags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CopyTags { get; set; }
        }

        public class Script : Humidifier.Base.BaseSubResource, IHaveExecutionHandlerService, IHaveExecutionTimeout_Integer, IHaveStringListOfStages, IHaveExecutionHandler, IHaveMaximumRetryCount_Integer, IHaveExecuteOperationOnScriptFailure_Boolean
        {
            /// <summary>
            /// ExecutionHandlerService
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-script.html#cfn-dlm-lifecyclepolicy-script-executionhandlerservice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionHandlerService { get; set; }
            /// <summary>
            /// ExecutionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-script.html#cfn-dlm-lifecyclepolicy-script-executiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExecutionTimeout { get; set; }
            /// <summary>
            /// Stages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-script.html#cfn-dlm-lifecyclepolicy-script-stages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Stages { get; set; }
            /// <summary>
            /// ExecutionHandler
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-script.html#cfn-dlm-lifecyclepolicy-script-executionhandler
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionHandler { get; set; }
            /// <summary>
            /// MaximumRetryCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-script.html#cfn-dlm-lifecyclepolicy-script-maximumretrycount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumRetryCount { get; set; }
            /// <summary>
            /// ExecuteOperationOnScriptFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-script.html#cfn-dlm-lifecyclepolicy-script-executeoperationonscriptfailure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExecuteOperationOnScriptFailure { get; set; }
        }

        public class ShareRule : Humidifier.Base.BaseSubResource, IHaveStringListOfTargetAccounts, IHaveUnshareIntervalUnit, IHaveUnshareInterval_Integer
        {
            /// <summary>
            /// TargetAccounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-sharerule.html#cfn-dlm-lifecyclepolicy-sharerule-targetaccounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetAccounts { get; set; }
            /// <summary>
            /// UnshareIntervalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-sharerule.html#cfn-dlm-lifecyclepolicy-sharerule-unshareintervalunit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnshareIntervalUnit { get; set; }
            /// <summary>
            /// UnshareInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-sharerule.html#cfn-dlm-lifecyclepolicy-sharerule-unshareinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UnshareInterval { get; set; }
        }
    }
}