namespace Humidifier.Config
{
    using global::System.Collections.Generic;
    using ConfigurationRecorderTypes;

    public class ConfigurationRecorder : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStartedOnCreate_Boolean, IHaveConfigConfigurationRecorderTypesRecordingGroupRecordingGroup, IHaveConfigConfigurationRecorderTypesRecordingModeRecordingMode, IHaveRoleARN, IHaveName
    {
        public class Attributes
        {
            public static string ResourceARN =  "ResourceARN" ;
        }

        public override string AWSTypeName { get => AWS.Config.ConfigurationRecorder; }
        /// <summary>
        /// StartedOnCreate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html#cfn-config-configurationrecorder-startedoncreate
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? StartedOnCreate { get; set; }
        /// <summary>
        /// RecordingGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html#cfn-config-configurationrecorder-recordinggroup
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RecordingGroup
        /// </summary>
        public Union<Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup, BaseFunction>? RecordingGroup { get; set; }
        /// <summary>
        /// RecordingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html#cfn-config-configurationrecorder-recordingmode
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RecordingMode
        /// </summary>
        public Union<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode, BaseFunction>? RecordingMode { get; set; }

        /// <summary>
        /// RoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html#cfn-config-configurationrecorder-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleARN { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfigurationRecorderTypes
    {
        public class ExclusionByResourceTypes : Humidifier.Base.BaseSubResource, IHaveStringListOfResourceTypes
        {
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-exclusionbyresourcetypes.html#cfn-config-configurationrecorder-exclusionbyresourcetypes-resourcetypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceTypes { get; set; }
        }

        public class RecordingGroup : Humidifier.Base.BaseSubResource, IHaveIncludeGlobalResourceTypes_Boolean, IHaveStringListOfResourceTypes, IHaveConfigConfigurationRecorderTypesRecordingStrategyRecordingStrategy, IHaveConfigConfigurationRecorderTypesExclusionByResourceTypesExclusionByResourceTypes, IHaveAllSupported_Boolean
        {
            /// <summary>
            /// IncludeGlobalResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-includeglobalresourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeGlobalResourceTypes { get; set; }
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-resourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceTypes { get; set; }
            /// <summary>
            /// RecordingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-recordingstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RecordingStrategy
            /// </summary>
            public Union<Humidifier.Config.ConfigurationRecorderTypes.RecordingStrategy, BaseFunction>? RecordingStrategy { get; set; }
            /// <summary>
            /// ExclusionByResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-exclusionbyresourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExclusionByResourceTypes
            /// </summary>
            public Union<Humidifier.Config.ConfigurationRecorderTypes.ExclusionByResourceTypes, BaseFunction>? ExclusionByResourceTypes { get; set; }
            /// <summary>
            /// AllSupported
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-allsupported
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllSupported { get; set; }
        }

        public class RecordingMode : Humidifier.Base.BaseSubResource, IHaveListOfConfigConfigurationRecorderTypesRecordingModeOverrideRecordingModeOverrides, IHaveRecordingFrequency
        {
            /// <summary>
            /// RecordingModeOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingmode.html#cfn-config-configurationrecorder-recordingmode-recordingmodeoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RecordingModeOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Config.ConfigurationRecorderTypes.RecordingModeOverride>, IReadOnlyList<Union<Humidifier.Config.ConfigurationRecorderTypes.RecordingModeOverride, BaseFunction>>, BaseFunction>? RecordingModeOverrides { get; set; }
            /// <summary>
            /// RecordingFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingmode.html#cfn-config-configurationrecorder-recordingmode-recordingfrequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordingFrequency { get; set; }
        }

        public class RecordingModeOverride : Humidifier.Base.BaseSubResource, IHaveStringListOfResourceTypes, IHaveDescription, IHaveRecordingFrequency
        {
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingmodeoverride.html#cfn-config-configurationrecorder-recordingmodeoverride-resourcetypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceTypes { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingmodeoverride.html#cfn-config-configurationrecorder-recordingmodeoverride-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// RecordingFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingmodeoverride.html#cfn-config-configurationrecorder-recordingmodeoverride-recordingfrequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordingFrequency { get; set; }
        }

        public class RecordingStrategy : Humidifier.Base.BaseSubResource, IHaveUseOnly
        {
            /// <summary>
            /// UseOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingstrategy.html#cfn-config-configurationrecorder-recordingstrategy-useonly
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseOnly { get; set; }
        }
    }
}