namespace Humidifier.ARCZonalShift
{
    using System.Collections.Generic;
    using ZonalAutoshiftConfigurationTypes;

    public class ZonalAutoshiftConfiguration : Humidifier.Base.BaseResource, IHaveResourceIdentifier
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
        public dynamic ResourceIdentifier { get; set; }
        /// <summary>
        /// ZonalAutoshiftStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arczonalshift-zonalautoshiftconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-zonalautoshiftstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ZonalAutoshiftStatus { get; set; }
        /// <summary>
        /// PracticeRunConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-arczonalshift-zonalautoshiftconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PracticeRunConfiguration
        /// </summary>
        public Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration PracticeRunConfiguration { get; set; }
    }

    namespace ZonalAutoshiftConfigurationTypes
    {
        public class ControlCondition : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-controlcondition.html#cfn-arczonalshift-zonalautoshiftconfiguration-controlcondition-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// AlarmIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-controlcondition.html#cfn-arczonalshift-zonalautoshiftconfiguration-controlcondition-alarmidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlarmIdentifier { get; set; }
        }

        public class PracticeRunConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BlockedDates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration-blockeddates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic BlockedDates { get; set; }
            /// <summary>
            /// OutcomeAlarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration-outcomealarms
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ControlCondition
            /// </summary>
            public List<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.ControlCondition> OutcomeAlarms { get; set; }
            /// <summary>
            /// BlockingAlarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration-blockingalarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ControlCondition
            /// </summary>
            public List<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.ControlCondition> BlockingAlarms { get; set; }
            /// <summary>
            /// BlockedWindows
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration.html#cfn-arczonalshift-zonalautoshiftconfiguration-practicerunconfiguration-blockedwindows
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic BlockedWindows { get; set; }
        }
    }
}