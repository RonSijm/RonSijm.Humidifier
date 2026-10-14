namespace Humidifier.NetworkFlowMonitor
{
    using global::System.Collections.Generic;
    using MonitorTypes;

    public class Monitor : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMonitorName
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string MonitorStatus =  "MonitorStatus" ;
        }

        public override string AWSTypeName { get => AWS.NetworkFlowMonitor.Monitor; }
        /// <summary>
        /// ScopeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkflowmonitor-monitor.html#cfn-networkflowmonitor-monitor-scopearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ScopeArn { get; set; }

        /// <summary>
        /// LocalResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkflowmonitor-monitor.html#cfn-networkflowmonitor-monitor-localresources
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MonitorLocalResource
        /// </summary>
        [Required]
        public List<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> LocalResources { get; set; }
        public dynamic MonitorName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RemoteResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkflowmonitor-monitor.html#cfn-networkflowmonitor-monitor-remoteresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MonitorRemoteResource
        /// </summary>
        public List<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> RemoteResources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkflowmonitor-monitor.html#cfn-networkflowmonitor-monitor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace MonitorTypes
    {
        public class MonitorLocalResource : Humidifier.Base.BaseSubResource, IHaveType, IHaveIdentifier
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkflowmonitor-monitor-monitorlocalresource.html#cfn-networkflowmonitor-monitor-monitorlocalresource-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkflowmonitor-monitor-monitorlocalresource.html#cfn-networkflowmonitor-monitor-monitorlocalresource-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
        }

        public class MonitorRemoteResource : Humidifier.Base.BaseSubResource, IHaveType, IHaveIdentifier
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkflowmonitor-monitor-monitorremoteresource.html#cfn-networkflowmonitor-monitor-monitorremoteresource-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkflowmonitor-monitor-monitorremoteresource.html#cfn-networkflowmonitor-monitor-monitorremoteresource-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
        }
    }
}