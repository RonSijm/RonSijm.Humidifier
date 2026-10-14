namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;

    public class ReservedCapacity : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DurationHours =  "DurationHours" ;
            public static string ReservedCapacityType =  "ReservedCapacityType" ;
            public static string EndTime =  "EndTime" ;
            public static string DurationMinutes =  "DurationMinutes" ;
            public static string StartTime =  "StartTime" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string TotalInstanceCount =  "TotalInstanceCount" ;
            public static string AvailableInstanceCount =  "AvailableInstanceCount" ;
            public static string InUseInstanceCount =  "InUseInstanceCount" ;
            public static string InstanceType =  "InstanceType" ;
            public static string ReservedCapacityId =  "ReservedCapacityId" ;
            public static string Tags =  "Tags" ;
            public static string ReservedCapacityArn =  "ReservedCapacityArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.ReservedCapacity; }
    }
}