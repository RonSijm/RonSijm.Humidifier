namespace Humidifier.NetworkFlowMonitor
{
    using global::System.Collections.Generic;
    using PerformanceMonitorTypes;

    public class PerformanceMonitor : Humidifier.Base.BaseResource, IHaveTags, IHaveScopeArn, IHaveMonitorName, IHaveListOfNetworkFlowMonitorPerformanceMonitorTypesPerformanceMonitorTargetTargets
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string MonitorType =  "MonitorType" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string MonitorStatus =  "MonitorStatus" ;
        }

        public override string AWSTypeName { get => AWS.NetworkFlowMonitor.PerformanceMonitor; }
        /// <summary>
        /// ScopeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkflowmonitor-performancemonitor.html#cfn-networkflowmonitor-performancemonitor-scopearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ScopeArn { get; set; }

        /// <summary>
        /// MonitorName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkflowmonitor-performancemonitor.html#cfn-networkflowmonitor-performancemonitor-monitorname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MonitorName { get; set; }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkflowmonitor-performancemonitor.html#cfn-networkflowmonitor-performancemonitor-targets
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PerformanceMonitorTarget
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.NetworkFlowMonitor.PerformanceMonitorTypes.PerformanceMonitorTarget>, IReadOnlyList<Union<Humidifier.NetworkFlowMonitor.PerformanceMonitorTypes.PerformanceMonitorTarget, BaseFunction>>, BaseFunction>? Targets { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkflowmonitor-performancemonitor.html#cfn-networkflowmonitor-performancemonitor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PerformanceMonitorTypes
    {
        public class PerformanceMonitorTarget : Humidifier.Base.BaseSubResource, IHaveType, IHaveIdentifier
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkflowmonitor-performancemonitor-performancemonitortarget.html#cfn-networkflowmonitor-performancemonitor-performancemonitortarget-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkflowmonitor-performancemonitor-performancemonitortarget.html#cfn-networkflowmonitor-performancemonitor-performancemonitortarget-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
        }
    }
}