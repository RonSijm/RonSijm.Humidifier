namespace Humidifier.Macie2
{
    using global::System.Collections.Generic;
    using ClassificationJobTypes;

    public class ClassificationJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string JobArn =  "JobArn" ;
            public static string JobStatus =  "JobStatus" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string JobId =  "JobId" ;
        }

        public override string AWSTypeName { get => AWS.Macie2.ClassificationJob; }

        /// <summary>
        /// S3JobDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie2-classificationjob.html#cfn-macie2-classificationjob-s3jobdefinition
        /// Required: True
        /// UpdateType: Immutable
        /// Type: S3JobDefinition
        /// </summary>
        [Required]
        public Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition S3JobDefinition { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie2-classificationjob.html#cfn-macie2-classificationjob-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// JobType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie2-classificationjob.html#cfn-macie2-classificationjob-jobtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic JobType { get; set; }
        /// <summary>
        /// ManagedDataIdentifierSelector
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie2-classificationjob.html#cfn-macie2-classificationjob-manageddataidentifierselector
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ManagedDataIdentifierSelector { get; set; }
        /// <summary>
        /// InitialRun
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie2-classificationjob.html#cfn-macie2-classificationjob-initialrun
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic InitialRun { get; set; }
        /// <summary>
        /// SamplingPercentage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie2-classificationjob.html#cfn-macie2-classificationjob-samplingpercentage
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic SamplingPercentage { get; set; }
        /// <summary>
        /// ScheduleFrequency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie2-classificationjob.html#cfn-macie2-classificationjob-schedulefrequency
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobScheduleFrequency
        /// </summary>
        public Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency ScheduleFrequency { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie2-classificationjob.html#cfn-macie2-classificationjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ClassificationJobTypes
    {
        public class JobScheduleFrequency : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WeeklySchedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie2-classificationjob-jobschedulefrequency.html#cfn-macie2-classificationjob-jobschedulefrequency-weeklyschedule
            /// Required: False
            /// UpdateType: Immutable
            /// Type: WeeklySchedule
            /// </summary>
            public Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule WeeklySchedule { get; set; }
        }

        public class S3BucketDefinitionForJob : Humidifier.Base.BaseSubResource, IHaveAccountId
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie2-classificationjob-s3bucketdefinitionforjob.html#cfn-macie2-classificationjob-s3bucketdefinitionforjob-accountid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountId { get; set; }
            /// <summary>
            /// Buckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie2-classificationjob-s3bucketdefinitionforjob.html#cfn-macie2-classificationjob-s3bucketdefinitionforjob-buckets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Buckets { get; set; }
        }

        public class S3JobDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Scoping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie2-classificationjob-s3jobdefinition.html#cfn-macie2-classificationjob-s3jobdefinition-scoping
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Scoping { get; set; }
            /// <summary>
            /// BucketDefinitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie2-classificationjob-s3jobdefinition.html#cfn-macie2-classificationjob-s3jobdefinition-bucketdefinitions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: S3BucketDefinitionForJob
            /// </summary>
            public List<Humidifier.Macie2.ClassificationJobTypes.S3BucketDefinitionForJob> BucketDefinitions { get; set; }
        }

        public class WeeklySchedule : Humidifier.Base.BaseSubResource, IHaveDayOfWeek
        {
            /// <summary>
            /// DayOfWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-macie2-classificationjob-weeklyschedule.html#cfn-macie2-classificationjob-weeklyschedule-dayofweek
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DayOfWeek { get; set; }
        }
    }
}