namespace Humidifier.Braket
{
    using global::System.Collections.Generic;
    using SpendingLimitTypes;

    public class SpendingLimit : Humidifier.Base.BaseResource, IHaveTags, IHaveSpendingLimit_, IHaveDeviceArn, IHaveBraketSpendingLimitTypesTimePeriodTimePeriod
    {
        public class Attributes
        {
            public static string TotalSpend =  "TotalSpend" ;
            public static string SpendingLimitArn =  "SpendingLimitArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string QueuedSpend =  "QueuedSpend" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Braket.SpendingLimit; }

        /// <summary>
        /// SpendingLimit_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-spendinglimit.html#cfn-braket-spendinglimit-spendinglimit
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SpendingLimit_ { get; set; }

        /// <summary>
        /// DeviceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-spendinglimit.html#cfn-braket-spendinglimit-devicearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DeviceArn { get; set; }
        /// <summary>
        /// TimePeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-spendinglimit.html#cfn-braket-spendinglimit-timeperiod
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TimePeriod
        /// </summary>
        public Union<Humidifier.Braket.SpendingLimitTypes.TimePeriod, BaseFunction>? TimePeriod { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-spendinglimit.html#cfn-braket-spendinglimit-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SpendingLimitTypes
    {
        public class TimePeriod : Humidifier.Base.BaseSubResource, IHaveEndAt, IHaveStartAt
        {
            /// <summary>
            /// EndAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-spendinglimit-timeperiod.html#cfn-braket-spendinglimit-timeperiod-endat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndAt { get; set; }
            /// <summary>
            /// StartAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-spendinglimit-timeperiod.html#cfn-braket-spendinglimit-timeperiod-startat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartAt { get; set; }
        }
    }
}