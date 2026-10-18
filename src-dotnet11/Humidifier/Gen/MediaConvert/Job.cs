namespace Humidifier.MediaConvert
{
    using global::System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource, IHaveTags, IHaveRole, IHaveMediaConvertJobTypesAccelerationSettingsAccelerationSettings, IHavePriority_Integer, IHaveBillingTagsSource, IHaveStringDictionaryOfUserMetadata, IHaveSettingsJson_Json, IHaveStatusUpdateInterval, IHaveJobTemplate, IHaveQueue, IHaveListOfMediaConvertJobTypesHopDestinationHopDestinations, IHaveSimulateReservedQueue
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
        public Union<string, BaseFunction>? Role { get; set; }
        /// <summary>
        /// AccelerationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-accelerationsettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AccelerationSettings
        /// </summary>
        public Union<Humidifier.MediaConvert.JobTypes.AccelerationSettings, BaseFunction>? AccelerationSettings { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-priority
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// BillingTagsSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-billingtagssource
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BillingTagsSource { get; set; }
        /// <summary>
        /// UserMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-usermetadata
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? UserMetadata { get; set; }

        /// <summary>
        /// SettingsJson
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-settingsjson
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? SettingsJson { get; set; }
        /// <summary>
        /// StatusUpdateInterval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-statusupdateinterval
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StatusUpdateInterval { get; set; }
        /// <summary>
        /// JobTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-jobtemplate
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobTemplate { get; set; }
        /// <summary>
        /// Queue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-queue
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Queue { get; set; }
        /// <summary>
        /// HopDestinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-hopdestinations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: HopDestination
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaConvert.JobTypes.HopDestination>, IReadOnlyList<Union<Humidifier.MediaConvert.JobTypes.HopDestination, BaseFunction>>, BaseFunction>? HopDestinations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// SimulateReservedQueue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-job.html#cfn-mediaconvert-job-simulatereservedqueue
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SimulateReservedQueue { get; set; }
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
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class HopDestination : Humidifier.Base.BaseSubResource, IHaveWaitMinutes_Integer, IHavePriority_Integer, IHaveQueue
        {
            /// <summary>
            /// WaitMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-hopdestination.html#cfn-mediaconvert-job-hopdestination-waitminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WaitMinutes { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-hopdestination.html#cfn-mediaconvert-job-hopdestination-priority
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// Queue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-hopdestination.html#cfn-mediaconvert-job-hopdestination-queue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Queue { get; set; }
        }

        public class JobMessages : Humidifier.Base.BaseSubResource, IHaveStringListOfWarning, IHaveStringListOfInfo
        {
            /// <summary>
            /// Warning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-jobmessages.html#cfn-mediaconvert-job-jobmessages-warning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Warning { get; set; }
            /// <summary>
            /// Info
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-jobmessages.html#cfn-mediaconvert-job-jobmessages-info
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Info { get; set; }
        }

        public class OutputDetail : Humidifier.Base.BaseSubResource, IHaveDurationInMs_Integer, IHaveMediaConvertJobTypesVideoDetailVideoDetails
        {
            /// <summary>
            /// DurationInMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-outputdetail.html#cfn-mediaconvert-job-outputdetail-durationinms
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationInMs { get; set; }
            /// <summary>
            /// VideoDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-outputdetail.html#cfn-mediaconvert-job-outputdetail-videodetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoDetail
            /// </summary>
            public Union<Humidifier.MediaConvert.JobTypes.VideoDetail, BaseFunction>? VideoDetails { get; set; }
        }

        public class OutputGroupDetail : Humidifier.Base.BaseSubResource, IHaveListOfMediaConvertJobTypesOutputDetailOutputDetails
        {
            /// <summary>
            /// OutputDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-outputgroupdetail.html#cfn-mediaconvert-job-outputgroupdetail-outputdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputDetail
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaConvert.JobTypes.OutputDetail>, IReadOnlyList<Union<Humidifier.MediaConvert.JobTypes.OutputDetail, BaseFunction>>, BaseFunction>? OutputDetails { get; set; }
        }

        public class Timing : Humidifier.Base.BaseSubResource, IHaveFinishTime, IHaveStartTime, IHaveSubmitTime
        {
            /// <summary>
            /// FinishTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-timing.html#cfn-mediaconvert-job-timing-finishtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FinishTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-timing.html#cfn-mediaconvert-job-timing-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// SubmitTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-timing.html#cfn-mediaconvert-job-timing-submittime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubmitTime { get; set; }
        }

        public class VideoDetail : Humidifier.Base.BaseSubResource, IHaveHeightInPx_Integer, IHaveWidthInPx_Integer
        {
            /// <summary>
            /// HeightInPx
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-videodetail.html#cfn-mediaconvert-job-videodetail-heightinpx
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HeightInPx { get; set; }
            /// <summary>
            /// WidthInPx
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-job-videodetail.html#cfn-mediaconvert-job-videodetail-widthinpx
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WidthInPx { get; set; }
        }
    }
}