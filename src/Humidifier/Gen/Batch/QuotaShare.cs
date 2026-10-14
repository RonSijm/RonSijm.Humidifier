namespace Humidifier.Batch
{
    using global::System.Collections.Generic;
    using QuotaShareTypes;

    public class QuotaShare : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveState
    {
        public class Attributes
        {
            public static string QuotaShareArn =  "QuotaShareArn" ;
        }

        public override string AWSTypeName { get => AWS.Batch.QuotaShare; }

        /// <summary>
        /// PreemptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-quotashare.html#cfn-batch-quotashare-preemptionconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: QuotaSharePreemptionConfiguration
        /// </summary>
        [Required]
        public Humidifier.Batch.QuotaShareTypes.QuotaSharePreemptionConfiguration PreemptionConfiguration { get; set; }

        /// <summary>
        /// JobQueue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-quotashare.html#cfn-batch-quotashare-jobqueue
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic JobQueue { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-quotashare.html#cfn-batch-quotashare-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic State { get; set; }

        /// <summary>
        /// ResourceSharingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-quotashare.html#cfn-batch-quotashare-resourcesharingconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: QuotaShareResourceSharingConfiguration
        /// </summary>
        [Required]
        public Humidifier.Batch.QuotaShareTypes.QuotaShareResourceSharingConfiguration ResourceSharingConfiguration { get; set; }

        /// <summary>
        /// CapacityLimits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-quotashare.html#cfn-batch-quotashare-capacitylimits
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: QuotaShareCapacityLimit
        /// </summary>
        [Required]
        public List<Humidifier.Batch.QuotaShareTypes.QuotaShareCapacityLimit> CapacityLimits { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-quotashare.html#cfn-batch-quotashare-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic QuotaShareName { get => GivenName; set => GivenName = value; }
    }

    namespace QuotaShareTypes
    {
        public class QuotaShareCapacityLimit : Humidifier.Base.BaseSubResource, IHaveMaxCapacity
        {
            /// <summary>
            /// CapacityUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-quotashare-quotasharecapacitylimit.html#cfn-batch-quotashare-quotasharecapacitylimit-capacityunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityUnit { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-quotashare-quotasharecapacitylimit.html#cfn-batch-quotashare-quotasharecapacitylimit-maxcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCapacity { get; set; }
        }

        public class QuotaSharePreemptionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InSharePreemption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-quotashare-quotasharepreemptionconfiguration.html#cfn-batch-quotashare-quotasharepreemptionconfiguration-insharepreemption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InSharePreemption { get; set; }
        }

        public class QuotaShareResourceSharingConfiguration : Humidifier.Base.BaseSubResource, IHaveStrategy
        {
            /// <summary>
            /// BorrowLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-quotashare-quotashareresourcesharingconfiguration.html#cfn-batch-quotashare-quotashareresourcesharingconfiguration-borrowlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BorrowLimit { get; set; }
            /// <summary>
            /// Strategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-quotashare-quotashareresourcesharingconfiguration.html#cfn-batch-quotashare-quotashareresourcesharingconfiguration-strategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Strategy { get; set; }
        }
    }
}