namespace Humidifier.Braket
{
    using global::System.Collections.Generic;
    using SpendingLimitTypes;

    public class SpendingLimit : Humidifier.Base.BaseResource, IHaveTags
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
        public dynamic SpendingLimit_ { get; set; }

        /// <summary>
        /// DeviceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-spendinglimit.html#cfn-braket-spendinglimit-devicearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DeviceArn { get; set; }
        /// <summary>
        /// TimePeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-spendinglimit.html#cfn-braket-spendinglimit-timeperiod
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TimePeriod
        /// </summary>
        public Humidifier.Braket.SpendingLimitTypes.TimePeriod TimePeriod { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-spendinglimit.html#cfn-braket-spendinglimit-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace SpendingLimitTypes
    {
        public class TimePeriod : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EndAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-spendinglimit-timeperiod.html#cfn-braket-spendinglimit-timeperiod-endat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndAt { get; set; }
            /// <summary>
            /// StartAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-spendinglimit-timeperiod.html#cfn-braket-spendinglimit-timeperiod-startat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartAt { get; set; }
        }
    }
}