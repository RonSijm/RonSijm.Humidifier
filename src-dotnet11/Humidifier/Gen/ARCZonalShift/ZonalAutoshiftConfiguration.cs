namespace Humidifier.ARCZonalShift
{
    using global::System.Collections.Generic;
    using ZonalAutoshiftConfigurationTypes;

    public class ZonalAutoshiftConfiguration : Humidifier.Base.BaseResource, IHaveResourceIdentifier, IHaveZonalAutoshiftStatus, IHaveARCZonalShiftZonalAutoshiftConfigurationTypesPracticeRunConfigurationPracticeRunConfiguration
    {
        public override string AWSTypeName { get => AWS.ARCZonalShift.ZonalAutoshiftConfiguration; }

        /// <summary>
        /// ResourceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arczonalshift-zonalautoshiftconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-resourceidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceIdentifier { get; set; }
        /// <summary>
        /// ZonalAutoshiftStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arczonalshift-zonalautoshiftconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-zonalautoshiftstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ZonalAutoshiftStatus { get; set; }
        /// <summary>
        /// PracticeRunConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arczonalshift-zonalautoshiftconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PracticeRunConfiguration
        /// </summary>
        public Union<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration, BaseFunction>? PracticeRunConfiguration { get; set; }
    }

    namespace ZonalAutoshiftConfigurationTypes
    {
        public class ControlCondition : Humidifier.Base.BaseSubResource, IHaveAlarmIdentifier, IHaveType
        {
            /// <summary>
            /// AlarmIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-controlcondition.html#cfn-arczonalshift-zonalautoshiftconfiguration-controlcondition-alarmidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlarmIdentifier { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-controlcondition.html#cfn-arczonalshift-zonalautoshiftconfiguration-controlcondition-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class PracticeRunConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfBlockedDates, IHaveListOfARCZonalShiftZonalAutoshiftConfigurationTypesControlConditionOutcomeAlarms, IHaveListOfARCZonalShiftZonalAutoshiftConfigurationTypesControlConditionBlockingAlarms, IHaveStringListOfBlockedWindows
        {
            /// <summary>
            /// BlockedDates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration-blockeddates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? BlockedDates { get; set; }
            /// <summary>
            /// OutcomeAlarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration-outcomealarms
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ControlCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.ControlCondition>, IReadOnlyList<Union<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.ControlCondition, BaseFunction>>, BaseFunction>? OutcomeAlarms { get; set; }
            /// <summary>
            /// BlockingAlarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration-blockingalarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ControlCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.ControlCondition>, IReadOnlyList<Union<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.ControlCondition, BaseFunction>>, BaseFunction>? BlockingAlarms { get; set; }
            /// <summary>
            /// BlockedWindows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration-blockedwindows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? BlockedWindows { get; set; }
        }
    }
}