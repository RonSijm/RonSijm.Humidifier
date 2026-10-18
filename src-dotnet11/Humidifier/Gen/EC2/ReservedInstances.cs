namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using ReservedInstancesTypes;

    public class ReservedInstances : Humidifier.Base.BaseResource, IHaveInstanceCount_Integer
    {
        public class Attributes
        {
            public static string UsagePrice =  "UsagePrice" ;
            public static string OfferingClass =  "OfferingClass" ;
            public static string Start =  "Start" ;
            public static string AvailabilityZoneId =  "AvailabilityZoneId" ;
            public static string RecurringCharges =  "RecurringCharges" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string Duration =  "Duration" ;
            public static string CurrencyCode =  "CurrencyCode" ;
            public static string OfferingType =  "OfferingType" ;
            public static string ReservedInstancesId =  "ReservedInstancesId" ;
            public static string Scope =  "Scope" ;
            public static string InstanceTenancy =  "InstanceTenancy" ;
            public static string State =  "State" ;
            public static string End =  "End" ;
            public static string ProductDescription =  "ProductDescription" ;
            public static string Arn =  "Arn" ;
            public static string InstanceType =  "InstanceType" ;
            public static string Tags =  "Tags" ;
            public static string FixedPrice =  "FixedPrice" ;
        }

        public override string AWSTypeName { get => AWS.EC2.ReservedInstances; }
        /// <summary>
        /// InstanceCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-reservedinstances.html#cfn-ec2-reservedinstances-instancecount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? InstanceCount { get; set; }
    }

    namespace ReservedInstancesTypes
    {
        public class RecurringCharge : Humidifier.Base.BaseSubResource, IHaveAmount_Double, IHaveFrequency
        {
            /// <summary>
            /// Amount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-reservedinstances-recurringcharge.html#cfn-ec2-reservedinstances-recurringcharge-amount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Amount { get; set; }
            /// <summary>
            /// Frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-reservedinstances-recurringcharge.html#cfn-ec2-reservedinstances-recurringcharge-frequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Frequency { get; set; }
        }
    }
}