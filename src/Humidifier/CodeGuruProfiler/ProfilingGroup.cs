namespace Humidifier.CodeGuruProfiler
{
    using System.Collections.Generic;
    using ProfilingGroupTypes;

    public class ProfilingGroup : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CodeGuruProfiler::ProfilingGroup";
            }
        }

        /// <summary>
        /// AnomalyDetectionNotificationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeguruprofiler-profilinggroup.html#cfn-codeguruprofiler-profilinggroup-anomalydetectionnotificationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Channel
        /// </summary>
        public List<Channel> AnomalyDetectionNotificationConfiguration { get; set; }
        /// <summary>
        /// AgentPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeguruprofiler-profilinggroup.html#cfn-codeguruprofiler-profilinggroup-agentpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AgentPermissions
        /// </summary>
        public AgentPermissions AgentPermissions { get; set; }
        /// <summary>
        /// ComputePlatform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeguruprofiler-profilinggroup.html#cfn-codeguruprofiler-profilinggroup-computeplatform
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ComputePlatform { get; set; }
        /// <summary>
        /// ProfilingGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeguruprofiler-profilinggroup.html#cfn-codeguruprofiler-profilinggroup-profilinggroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProfilingGroupName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeguruprofiler-profilinggroup.html#cfn-codeguruprofiler-profilinggroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ProfilingGroupTypes
    {
        public class AgentPermissions
        {
            /// <summary>
            /// Principals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-agentpermissions.html#cfn-codeguruprofiler-profilinggroup-agentpermissions-principals
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Principals { get; set; }
        }

        public class Channel
        {
            /// <summary>
            /// channelUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html#cfn-codeguruprofiler-profilinggroup-channel-channeluri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic channelUri { get; set; }
            /// <summary>
            /// channelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html#cfn-codeguruprofiler-profilinggroup-channel-channelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic channelId { get; set; }
        }
    }
}