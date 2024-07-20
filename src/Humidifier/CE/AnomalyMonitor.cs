namespace Humidifier.CE
{
    using System.Collections.Generic;
    using AnomalyMonitorTypes;

    public class AnomalyMonitor : Humidifier.Resource
    {
        public class Attributes
        {
            public static string LastUpdatedDate =  "LastUpdatedDate" ;
            public static string CreationDate =  "CreationDate" ;
            public static string LastEvaluatedDate =  "LastEvaluatedDate" ;
            public static string MonitorArn =  "MonitorArn" ;
            public static string DimensionalValueCount =  "DimensionalValueCount" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CE::AnomalyMonitor";
            }
        }

        /// <summary>
        /// MonitorType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalymonitor.html#cfn-ce-anomalymonitor-monitortype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MonitorType { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalymonitor.html#cfn-ce-anomalymonitor-resourcetags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public List<ResourceTag> ResourceTags { get; set; }
        /// <summary>
        /// MonitorName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalymonitor.html#cfn-ce-anomalymonitor-monitorname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MonitorName { get; set; }
        /// <summary>
        /// MonitorSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalymonitor.html#cfn-ce-anomalymonitor-monitorspecification
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MonitorSpecification { get; set; }
        /// <summary>
        /// MonitorDimension
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalymonitor.html#cfn-ce-anomalymonitor-monitordimension
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MonitorDimension { get; set; }
    }

    namespace AnomalyMonitorTypes
    {
        public class ResourceTag
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-anomalymonitor-resourcetag.html#cfn-ce-anomalymonitor-resourcetag-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-anomalymonitor-resourcetag.html#cfn-ce-anomalymonitor-resourcetag-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}