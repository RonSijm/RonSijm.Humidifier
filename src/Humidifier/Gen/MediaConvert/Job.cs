namespace Humidifier.MediaConvert
{
    using global::System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource, IHaveTags, IHavePriority, IHaveRole, IHaveQueue, IHaveSettingsJson
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Messages =  "Messages" ;
            public static string AccelerationStatus =  "AccelerationStatus" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ShareStatus =  "ShareStatus" ;
            public static string OutputGroupDetails =  "OutputGroupDetails" ;
            public static string Id =  "Id" ;
            public static string Timing =  "Timing" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaConvert.Job; }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-role
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Role { get; set; }
        /// <summary>
        /// AccelerationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-accelerationsettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AccelerationSettings
        /// </summary>
        public Humidifier.MediaConvert.JobTypes.AccelerationSettings AccelerationSettings { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-priority
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Priority { get; set; }
        /// <summary>
        /// BillingTagsSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-billingtagssource
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BillingTagsSource { get; set; }
        /// <summary>
        /// UserMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-usermetadata
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> UserMetadata { get; set; }

        /// <summary>
        /// SettingsJson
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-settingsjson
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic SettingsJson { get; set; }
        /// <summary>
        /// StatusUpdateInterval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-statusupdateinterval
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StatusUpdateInterval { get; set; }
        /// <summary>
        /// JobTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-jobtemplate
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobTemplate { get; set; }
        /// <summary>
        /// Queue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-queue
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Queue { get; set; }
        /// <summary>
        /// HopDestinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-hopdestinations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: HopDestination
        /// </summary>
        public List<Humidifier.MediaConvert.JobTypes.HopDestination> HopDestinations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// SimulateReservedQueue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-simulatereservedqueue
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SimulateReservedQueue { get; set; }
    }

    namespace JobTypes
    {
        public class AccelerationSettings : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-accelerationsettings.html#cfn-mediaconvert-job-accelerationsettings-mode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
        }

        public class HopDestination : Humidifier.Base.BaseSubResource, IHavePriority, IHaveQueue
        {
            /// <summary>
            /// WaitMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-hopdestination.html#cfn-mediaconvert-job-hopdestination-waitminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WaitMinutes { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-hopdestination.html#cfn-mediaconvert-job-hopdestination-priority
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// Queue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-hopdestination.html#cfn-mediaconvert-job-hopdestination-queue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Queue { get; set; }
        }

        public class JobMessages : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Warning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-jobmessages.html#cfn-mediaconvert-job-jobmessages-warning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Warning { get; set; }
            /// <summary>
            /// Info
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-jobmessages.html#cfn-mediaconvert-job-jobmessages-info
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Info { get; set; }
        }

        public class OutputDetail : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DurationInMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-outputdetail.html#cfn-mediaconvert-job-outputdetail-durationinms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInMs { get; set; }
            /// <summary>
            /// VideoDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-outputdetail.html#cfn-mediaconvert-job-outputdetail-videodetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoDetail
            /// </summary>
            public Humidifier.MediaConvert.JobTypes.VideoDetail VideoDetails { get; set; }
        }

        public class OutputGroupDetail : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OutputDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-outputgroupdetail.html#cfn-mediaconvert-job-outputgroupdetail-outputdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputDetail
            /// </summary>
            public List<Humidifier.MediaConvert.JobTypes.OutputDetail> OutputDetails { get; set; }
        }

        public class Timing : Humidifier.Base.BaseSubResource, IHaveStartTime
        {
            /// <summary>
            /// FinishTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-timing.html#cfn-mediaconvert-job-timing-finishtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FinishTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-timing.html#cfn-mediaconvert-job-timing-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime { get; set; }
            /// <summary>
            /// SubmitTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-timing.html#cfn-mediaconvert-job-timing-submittime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubmitTime { get; set; }
        }

        public class VideoDetail : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeightInPx
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-videodetail.html#cfn-mediaconvert-job-videodetail-heightinpx
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HeightInPx { get; set; }
            /// <summary>
            /// WidthInPx
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-videodetail.html#cfn-mediaconvert-job-videodetail-widthinpx
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WidthInPx { get; set; }
        }
    }
}