namespace Humidifier.MGN
{
    using global::System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Type =  "Type" ;
            public static string ParticipatingServers =  "ParticipatingServers" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string EndDateTime =  "EndDateTime" ;
            public static string InitiatedBy =  "InitiatedBy" ;
            public static string Arn =  "Arn" ;
            public static string JobId =  "JobId" ;
        }

        public override string AWSTypeName { get => AWS.MGN.Job; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-job.html#cfn-mgn-job-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace JobTypes
    {
        public class ParticipatingServer : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LaunchedEc2InstanceID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-job-participatingserver.html#cfn-mgn-job-participatingserver-launchedec2instanceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LaunchedEc2InstanceID { get; set; }
            /// <summary>
            /// LaunchStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-job-participatingserver.html#cfn-mgn-job-participatingserver-launchstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LaunchStatus { get; set; }
            /// <summary>
            /// SourceServerID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-job-participatingserver.html#cfn-mgn-job-participatingserver-sourceserverid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceServerID { get; set; }
        }
    }
}