namespace Humidifier.Batch
{
    using global::System.Collections.Generic;
    using QuotaShareTypes;

    public class QuotaShare : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveBatchQuotaShareTypesQuotaSharePreemptionConfigurationPreemptionConfiguration, IHaveJobQueue, IHaveState, IHaveBatchQuotaShareTypesQuotaShareResourceSharingConfigurationResourceSharingConfiguration, IHaveListOfBatchQuotaShareTypesQuotaShareCapacityLimitCapacityLimits, IHaveStringDictionaryOfTags, IHaveQuotaShareName
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
        public Union<Humidifier.Batch.QuotaShareTypes.QuotaSharePreemptionConfiguration, BaseFunction>? PreemptionConfiguration { get; set; }

        /// <summary>
        /// JobQueue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-quotashare.html#cfn-batch-quotashare-jobqueue
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? JobQueue { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-quotashare.html#cfn-batch-quotashare-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? State { get; set; }

        /// <summary>
        /// ResourceSharingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-quotashare.html#cfn-batch-quotashare-resourcesharingconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: QuotaShareResourceSharingConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Batch.QuotaShareTypes.QuotaShareResourceSharingConfiguration, BaseFunction>? ResourceSharingConfiguration { get; set; }

        /// <summary>
        /// CapacityLimits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-quotashare.html#cfn-batch-quotashare-capacitylimits
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: QuotaShareCapacityLimit
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Batch.QuotaShareTypes.QuotaShareCapacityLimit>, IReadOnlyList<Union<Humidifier.Batch.QuotaShareTypes.QuotaShareCapacityLimit, BaseFunction>>, BaseFunction>? CapacityLimits { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-quotashare.html#cfn-batch-quotashare-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? QuotaShareName { get => GivenName; set => GivenName = value; }
    }

    namespace QuotaShareTypes
    {
        public class QuotaShareCapacityLimit : Humidifier.Base.BaseSubResource, IHaveCapacityUnit, IHaveMaxCapacity_Integer
        {
            /// <summary>
            /// CapacityUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-quotashare-quotasharecapacitylimit.html#cfn-batch-quotashare-quotasharecapacitylimit-capacityunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityUnit { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-quotashare-quotasharecapacitylimit.html#cfn-batch-quotashare-quotasharecapacitylimit-maxcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacity { get; set; }
        }

        public class QuotaSharePreemptionConfiguration : Humidifier.Base.BaseSubResource, IHaveInSharePreemption
        {
            /// <summary>
            /// InSharePreemption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-quotashare-quotasharepreemptionconfiguration.html#cfn-batch-quotashare-quotasharepreemptionconfiguration-insharepreemption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InSharePreemption { get; set; }
        }

        public class QuotaShareResourceSharingConfiguration : Humidifier.Base.BaseSubResource, IHaveBorrowLimit_Integer, IHaveStrategy
        {
            /// <summary>
            /// BorrowLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-quotashare-quotashareresourcesharingconfiguration.html#cfn-batch-quotashare-quotashareresourcesharingconfiguration-borrowlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BorrowLimit { get; set; }
            /// <summary>
            /// Strategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-quotashare-quotashareresourcesharingconfiguration.html#cfn-batch-quotashare-quotashareresourcesharingconfiguration-strategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Strategy { get; set; }
        }
    }
}