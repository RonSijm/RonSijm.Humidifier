namespace Humidifier.Config
{
    using System.Collections.Generic;
    using ConfigurationRecorderTypes;

    public class ConfigurationRecorder : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveRoleARN
    {
        public override string AWSTypeName { get => AWS.Config.ConfigurationRecorder; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RecordingGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html#cfn-config-configurationrecorder-recordinggroup
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RecordingGroup
        /// </summary>
        public Humidifier.Config.ConfigurationRecorderTypes.RecordingGroup RecordingGroup { get; set; }
        /// <summary>
        /// RecordingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html#cfn-config-configurationrecorder-recordingmode
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RecordingMode
        /// </summary>
        public Humidifier.Config.ConfigurationRecorderTypes.RecordingMode RecordingMode { get; set; }

        /// <summary>
        /// RoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html#cfn-config-configurationrecorder-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleARN { get; set; }
    }

    namespace ConfigurationRecorderTypes
    {
        public class ExclusionByResourceTypes : Humidifier.Base.BaseSubResource, IHaveResourceTypes
        {
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-exclusionbyresourcetypes.html#cfn-config-configurationrecorder-exclusionbyresourcetypes-resourcetypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ResourceTypes { get; set; }
        }

        public class RecordingGroup : Humidifier.Base.BaseSubResource, IHaveResourceTypes
        {
            /// <summary>
            /// AllSupported
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-allsupported
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllSupported { get; set; }
            /// <summary>
            /// ExclusionByResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-exclusionbyresourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExclusionByResourceTypes
            /// </summary>
            public Humidifier.Config.ConfigurationRecorderTypes.ExclusionByResourceTypes ExclusionByResourceTypes { get; set; }
            /// <summary>
            /// IncludeGlobalResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-includeglobalresourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeGlobalResourceTypes { get; set; }
            /// <summary>
            /// RecordingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-recordingstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RecordingStrategy
            /// </summary>
            public Humidifier.Config.ConfigurationRecorderTypes.RecordingStrategy RecordingStrategy { get; set; }
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordinggroup.html#cfn-config-configurationrecorder-recordinggroup-resourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ResourceTypes { get; set; }
        }

        public class RecordingMode : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RecordingFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingmode.html#cfn-config-configurationrecorder-recordingmode-recordingfrequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordingFrequency { get; set; }
            /// <summary>
            /// RecordingModeOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingmode.html#cfn-config-configurationrecorder-recordingmode-recordingmodeoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RecordingModeOverride
            /// </summary>
            public List<Humidifier.Config.ConfigurationRecorderTypes.RecordingModeOverride> RecordingModeOverrides { get; set; }
        }

        public class RecordingModeOverride : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveResourceTypes
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingmodeoverride.html#cfn-config-configurationrecorder-recordingmodeoverride-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// RecordingFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingmodeoverride.html#cfn-config-configurationrecorder-recordingmodeoverride-recordingfrequency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordingFrequency { get; set; }
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingmodeoverride.html#cfn-config-configurationrecorder-recordingmodeoverride-resourcetypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ResourceTypes { get; set; }
        }

        public class RecordingStrategy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UseOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationrecorder-recordingstrategy.html#cfn-config-configurationrecorder-recordingstrategy-useonly
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseOnly { get; set; }
        }
    }
}