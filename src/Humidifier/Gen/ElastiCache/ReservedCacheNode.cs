namespace Humidifier.ElastiCache
{
    using global::System.Collections.Generic;
    using ReservedCacheNodeTypes;

    public class ReservedCacheNode : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string UsagePrice =  "UsagePrice" ;
            public static string CacheNodeCount =  "CacheNodeCount" ;
            public static string StartTime =  "StartTime" ;
            public static string RecurringCharges =  "RecurringCharges" ;
            public static string ReservedCacheNodeId =  "ReservedCacheNodeId" ;
            public static string Duration =  "Duration" ;
            public static string ReservedCacheNodesOfferingId =  "ReservedCacheNodesOfferingId" ;
            public static string OfferingType =  "OfferingType" ;
            public static string CacheNodeType =  "CacheNodeType" ;
            public static string ReservationARN =  "ReservationARN" ;
            public static string State =  "State" ;
            public static string ProductDescription =  "ProductDescription" ;
            public static string Tags =  "Tags" ;
            public static string FixedPrice =  "FixedPrice" ;
        }

        public override string AWSTypeName { get => AWS.ElastiCache.ReservedCacheNode; }
    }

    namespace ReservedCacheNodeTypes
    {
        public class RecurringCharge : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RecurringChargeFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-reservedcachenode-recurringcharge.html#cfn-elasticache-reservedcachenode-recurringcharge-recurringchargefrequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecurringChargeFrequency { get; set; }
            /// <summary>
            /// RecurringChargeAmount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-reservedcachenode-recurringcharge.html#cfn-elasticache-reservedcachenode-recurringcharge-recurringchargeamount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RecurringChargeAmount { get; set; }
        }
    }
}