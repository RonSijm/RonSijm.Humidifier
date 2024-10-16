namespace Humidifier.CodeGuruProfiler
{
    using System.Collections.Generic;
    using ProfilingGroupTypes;

    public class ProfilingGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveComputePlatform
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CodeGuruProfiler.ProfilingGroup; }
        /// <summary>
        /// AnomalyDetectionNotificationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeguruprofiler-profilinggroup.html#cfn-codeguruprofiler-profilinggroup-anomalydetectionnotificationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Channel
        /// </summary>
        public List<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> AnomalyDetectionNotificationConfiguration { get; set; }
        /// <summary>
        /// AgentPermissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeguruprofiler-profilinggroup.html#cfn-codeguruprofiler-profilinggroup-agentpermissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AgentPermissions
        /// </summary>
        public Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions AgentPermissions { get; set; }
        /// <summary>
        /// ComputePlatform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeguruprofiler-profilinggroup.html#cfn-codeguruprofiler-profilinggroup-computeplatform
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ComputePlatform { get; set; }
        public dynamic ProfilingGroupName { get => GivenName; set => GivenName = value; }
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
        public class AgentPermissions : Humidifier.Base.BaseSubResource, IHavePrincipals
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

        public class Channel : Humidifier.Base.BaseSubResource
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