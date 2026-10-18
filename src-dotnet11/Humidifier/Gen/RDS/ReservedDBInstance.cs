namespace Humidifier.RDS
{
    using global::System.Collections.Generic;
    using ReservedDBInstanceTypes;

    public class ReservedDBInstance : Humidifier.Base.BaseResource, IHaveDBInstanceCount_Integer
    {
        public class Attributes
        {
            public static string UsagePrice =  "UsagePrice" ;
            public static string DBInstanceClass =  "DBInstanceClass" ;
            public static string ReservedDBInstanceId =  "ReservedDBInstanceId" ;
            public static string StartTime =  "StartTime" ;
            public static string RecurringCharges =  "RecurringCharges" ;
            public static string ReservedDBInstancesOfferingId =  "ReservedDBInstancesOfferingId" ;
            public static string Duration =  "Duration" ;
            public static string CurrencyCode =  "CurrencyCode" ;
            public static string OfferingType =  "OfferingType" ;
            public static string State =  "State" ;
            public static string ProductDescription =  "ProductDescription" ;
            public static string ReservedDBInstanceArn =  "ReservedDBInstanceArn" ;
            public static string MultiAZ =  "MultiAZ" ;
            public static string Tags =  "Tags" ;
            public static string FixedPrice =  "FixedPrice" ;
        }

        public override string AWSTypeName { get => AWS.RDS.ReservedDBInstance; }
        /// <summary>
        /// DBInstanceCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-reserveddbinstance.html#cfn-rds-reserveddbinstance-dbinstancecount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DBInstanceCount { get; set; }
    }

    namespace ReservedDBInstanceTypes
    {
        public class RecurringCharge : Humidifier.Base.BaseSubResource, IHaveRecurringChargeFrequency, IHaveRecurringChargeAmount_Double
        {
            /// <summary>
            /// RecurringChargeFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-reserveddbinstance-recurringcharge.html#cfn-rds-reserveddbinstance-recurringcharge-recurringchargefrequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecurringChargeFrequency { get; set; }
            /// <summary>
            /// RecurringChargeAmount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-reserveddbinstance-recurringcharge.html#cfn-rds-reserveddbinstance-recurringcharge-recurringchargeamount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RecurringChargeAmount { get; set; }
        }
    }
}