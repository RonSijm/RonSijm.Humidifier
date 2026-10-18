namespace Humidifier.MemoryDB
{
    using global::System.Collections.Generic;
    using ReservedNodeTypes;

    public class ReservedNode : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string OfferingType =  "OfferingType" ;
            public static string NodeCount =  "NodeCount" ;
            public static string ReservationId =  "ReservationId" ;
            public static string State =  "State" ;
            public static string NodeType =  "NodeType" ;
            public static string StartTime =  "StartTime" ;
            public static string RecurringCharges =  "RecurringCharges" ;
            public static string Duration =  "Duration" ;
            public static string Arn =  "Arn" ;
            public static string ReservedNodesOfferingId =  "ReservedNodesOfferingId" ;
            public static string Tags =  "Tags" ;
            public static string FixedPrice =  "FixedPrice" ;
        }

        public override string AWSTypeName { get => AWS.MemoryDB.ReservedNode; }
    }

    namespace ReservedNodeTypes
    {
        public class RecurringCharge : Humidifier.Base.BaseSubResource, IHaveRecurringChargeFrequency, IHaveRecurringChargeAmount_Double
        {
            /// <summary>
            /// RecurringChargeFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-reservednode-recurringcharge.html#cfn-memorydb-reservednode-recurringcharge-recurringchargefrequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecurringChargeFrequency { get; set; }
            /// <summary>
            /// RecurringChargeAmount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-reservednode-recurringcharge.html#cfn-memorydb-reservednode-recurringcharge-recurringchargeamount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RecurringChargeAmount { get; set; }
        }
    }
}