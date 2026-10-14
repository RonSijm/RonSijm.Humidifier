namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using TrainingPlanTypes;

    public class TrainingPlan : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DurationHours =  "DurationHours" ;
            public static string TrainingPlanName =  "TrainingPlanName" ;
            public static string EndTime =  "EndTime" ;
            public static string DurationMinutes =  "DurationMinutes" ;
            public static string UpfrontFee =  "UpfrontFee" ;
            public static string StartTime =  "StartTime" ;
            public static string TotalUltraServerCount =  "TotalUltraServerCount" ;
            public static string TrainingPlanArn =  "TrainingPlanArn" ;
            public static string TotalInstanceCount =  "TotalInstanceCount" ;
            public static string TargetResources =  "TargetResources" ;
            public static string CurrencyCode =  "CurrencyCode" ;
            public static string UnhealthyInstanceCount =  "UnhealthyInstanceCount" ;
            public static string AvailableInstanceCount =  "AvailableInstanceCount" ;
            public static string AvailableSpareInstanceCount =  "AvailableSpareInstanceCount" ;
            public static string ReservedCapacitySummaries =  "ReservedCapacitySummaries" ;
            public static string InUseInstanceCount =  "InUseInstanceCount" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.TrainingPlan; }
    }

    namespace TrainingPlanTypes
    {
        public class ReservedCapacitySummary : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveInstanceType, IHaveAvailabilityZone, IHaveStartTime, IHaveEndTime
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// DurationHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-durationhours
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationHours { get; set; }
            /// <summary>
            /// ReservedCapacityType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-reservedcapacitytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReservedCapacityType { get; set; }
            /// <summary>
            /// UltraServerType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-ultraservertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UltraServerType { get; set; }
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-endtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndTime { get; set; }
            /// <summary>
            /// DurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-durationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationMinutes { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZone { get; set; }
            /// <summary>
            /// TotalInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-totalinstancecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TotalInstanceCount { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// UltraServerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-ultraservercount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic UltraServerCount { get; set; }
            /// <summary>
            /// ReservedCapacityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingplan-reservedcapacitysummary.html#cfn-sagemaker-trainingplan-reservedcapacitysummary-reservedcapacityarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReservedCapacityArn { get; set; }
        }
    }
}