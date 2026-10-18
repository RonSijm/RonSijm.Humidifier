namespace Humidifier.CE
{
    using global::System.Collections.Generic;
    using AnomalyMonitorTypes;

    public class AnomalyMonitor : Humidifier.Base.BaseResource, IHaveMonitorType, IHaveListOfCEAnomalyMonitorTypesResourceTagResourceTags, IHaveMonitorName, IHaveMonitorSpecification, IHaveMonitorDimension
    {
        public class Attributes
        {
            public static string LastUpdatedDate =  "LastUpdatedDate" ;
            public static string CreationDate =  "CreationDate" ;
            public static string LastEvaluatedDate =  "LastEvaluatedDate" ;
            public static string MonitorArn =  "MonitorArn" ;
            public static string DimensionalValueCount =  "DimensionalValueCount" ;
        }

        public override string AWSTypeName { get => AWS.CE.AnomalyMonitor; }

        /// <summary>
        /// MonitorType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalymonitor.html#cfn-ce-anomalymonitor-monitortype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MonitorType { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalymonitor.html#cfn-ce-anomalymonitor-resourcetags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CE.AnomalyMonitorTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.CE.AnomalyMonitorTypes.ResourceTag, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }

        /// <summary>
        /// MonitorName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalymonitor.html#cfn-ce-anomalymonitor-monitorname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MonitorName { get; set; }
        /// <summary>
        /// MonitorSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalymonitor.html#cfn-ce-anomalymonitor-monitorspecification
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MonitorSpecification { get; set; }
        /// <summary>
        /// MonitorDimension
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalymonitor.html#cfn-ce-anomalymonitor-monitordimension
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MonitorDimension { get; set; }
    }

    namespace AnomalyMonitorTypes
    {
        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-anomalymonitor-resourcetag.html#cfn-ce-anomalymonitor-resourcetag-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-anomalymonitor-resourcetag.html#cfn-ce-anomalymonitor-resourcetag-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}