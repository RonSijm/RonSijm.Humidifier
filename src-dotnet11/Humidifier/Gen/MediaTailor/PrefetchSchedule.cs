namespace Humidifier.MediaTailor
{
    using global::System.Collections.Generic;
    using PrefetchScheduleTypes;

    public class PrefetchSchedule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMediaTailorPrefetchScheduleTypesPrefetchConsumptionConsumption, IHaveMediaTailorPrefetchScheduleTypesPrefetchRetrievalRetrieval, IHaveScheduleType, IHaveStreamId, IHavePlaybackConfigurationName, IHaveMediaTailorPrefetchScheduleTypesRecurringPrefetchConfigurationRecurringPrefetchConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaTailor.PrefetchSchedule; }
        /// <summary>
        /// Consumption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-prefetchschedule.html#cfn-mediatailor-prefetchschedule-consumption
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PrefetchConsumption
        /// </summary>
        public Union<Humidifier.MediaTailor.PrefetchScheduleTypes.PrefetchConsumption, BaseFunction>? Consumption { get; set; }
        /// <summary>
        /// Retrieval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-prefetchschedule.html#cfn-mediatailor-prefetchschedule-retrieval
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PrefetchRetrieval
        /// </summary>
        public Union<Humidifier.MediaTailor.PrefetchScheduleTypes.PrefetchRetrieval, BaseFunction>? Retrieval { get; set; }
        /// <summary>
        /// ScheduleType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-prefetchschedule.html#cfn-mediatailor-prefetchschedule-scheduletype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ScheduleType { get; set; }
        /// <summary>
        /// StreamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-prefetchschedule.html#cfn-mediatailor-prefetchschedule-streamid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StreamId { get; set; }

        /// <summary>
        /// PlaybackConfigurationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-prefetchschedule.html#cfn-mediatailor-prefetchschedule-playbackconfigurationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PlaybackConfigurationName { get; set; }
        /// <summary>
        /// RecurringPrefetchConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-prefetchschedule.html#cfn-mediatailor-prefetchschedule-recurringprefetchconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RecurringPrefetchConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.PrefetchScheduleTypes.RecurringPrefetchConfiguration, BaseFunction>? RecurringPrefetchConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-prefetchschedule.html#cfn-mediatailor-prefetchschedule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PrefetchScheduleTypes
    {
        public class AvailMatchingCriteria : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveDynamicVariable
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-availmatchingcriteria.html#cfn-mediatailor-prefetchschedule-availmatchingcriteria-operator
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// DynamicVariable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-availmatchingcriteria.html#cfn-mediatailor-prefetchschedule-availmatchingcriteria-dynamicvariable
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DynamicVariable { get; set; }
        }

        public class PrefetchConsumption : Humidifier.Base.BaseSubResource, IHaveListOfMediaTailorPrefetchScheduleTypesAvailMatchingCriteriaAvailMatchingCriteria, IHaveEndTime, IHaveStartTime
        {
            /// <summary>
            /// AvailMatchingCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-prefetchconsumption.html#cfn-mediatailor-prefetchschedule-prefetchconsumption-availmatchingcriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AvailMatchingCriteria
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaTailor.PrefetchScheduleTypes.AvailMatchingCriteria>, IReadOnlyList<Union<Humidifier.MediaTailor.PrefetchScheduleTypes.AvailMatchingCriteria, BaseFunction>>, BaseFunction>? AvailMatchingCriteria { get; set; }
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-prefetchconsumption.html#cfn-mediatailor-prefetchschedule-prefetchconsumption-endtime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-prefetchconsumption.html#cfn-mediatailor-prefetchschedule-prefetchconsumption-starttime
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }

        public class PrefetchRetrieval : Humidifier.Base.BaseSubResource, IHaveMediaTailorPrefetchScheduleTypesTrafficShapingRetrievalWindowTrafficShapingRetrievalWindow, IHaveMediaTailorPrefetchScheduleTypesTrafficShapingTpsConfigurationTrafficShapingTpsConfiguration, IHaveEndTime, IHaveStartTime, IHaveTrafficShapingType, IHaveStringDictionaryOfDynamicVariables
        {
            /// <summary>
            /// TrafficShapingRetrievalWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-prefetchretrieval.html#cfn-mediatailor-prefetchschedule-prefetchretrieval-trafficshapingretrievalwindow
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrafficShapingRetrievalWindow
            /// </summary>
            public Union<Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingRetrievalWindow, BaseFunction>? TrafficShapingRetrievalWindow { get; set; }
            /// <summary>
            /// TrafficShapingTpsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-prefetchretrieval.html#cfn-mediatailor-prefetchschedule-prefetchretrieval-trafficshapingtpsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrafficShapingTpsConfiguration
            /// </summary>
            public Union<Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingTpsConfiguration, BaseFunction>? TrafficShapingTpsConfiguration { get; set; }
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-prefetchretrieval.html#cfn-mediatailor-prefetchschedule-prefetchretrieval-endtime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-prefetchretrieval.html#cfn-mediatailor-prefetchschedule-prefetchretrieval-starttime
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// TrafficShapingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-prefetchretrieval.html#cfn-mediatailor-prefetchschedule-prefetchretrieval-trafficshapingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrafficShapingType { get; set; }
            /// <summary>
            /// DynamicVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-prefetchretrieval.html#cfn-mediatailor-prefetchschedule-prefetchretrieval-dynamicvariables
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DynamicVariables { get; set; }
        }

        public class RecurringConsumption : Humidifier.Base.BaseSubResource, IHaveListOfMediaTailorPrefetchScheduleTypesAvailMatchingCriteriaAvailMatchingCriteria, IHaveRetrievedAdExpirationSeconds_Integer
        {
            /// <summary>
            /// AvailMatchingCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-recurringconsumption.html#cfn-mediatailor-prefetchschedule-recurringconsumption-availmatchingcriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AvailMatchingCriteria
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaTailor.PrefetchScheduleTypes.AvailMatchingCriteria>, IReadOnlyList<Union<Humidifier.MediaTailor.PrefetchScheduleTypes.AvailMatchingCriteria, BaseFunction>>, BaseFunction>? AvailMatchingCriteria { get; set; }
            /// <summary>
            /// RetrievedAdExpirationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-recurringconsumption.html#cfn-mediatailor-prefetchschedule-recurringconsumption-retrievedadexpirationseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetrievedAdExpirationSeconds { get; set; }
        }

        public class RecurringPrefetchConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaTailorPrefetchScheduleTypesRecurringConsumptionRecurringConsumption, IHaveEndTime, IHaveStartTime, IHaveMediaTailorPrefetchScheduleTypesRecurringRetrievalRecurringRetrieval
        {
            /// <summary>
            /// RecurringConsumption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-recurringprefetchconfiguration.html#cfn-mediatailor-prefetchschedule-recurringprefetchconfiguration-recurringconsumption
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RecurringConsumption
            /// </summary>
            public Union<Humidifier.MediaTailor.PrefetchScheduleTypes.RecurringConsumption, BaseFunction>? RecurringConsumption { get; set; }
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-recurringprefetchconfiguration.html#cfn-mediatailor-prefetchschedule-recurringprefetchconfiguration-endtime
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-recurringprefetchconfiguration.html#cfn-mediatailor-prefetchschedule-recurringprefetchconfiguration-starttime
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// RecurringRetrieval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-recurringprefetchconfiguration.html#cfn-mediatailor-prefetchschedule-recurringprefetchconfiguration-recurringretrieval
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RecurringRetrieval
            /// </summary>
            public Union<Humidifier.MediaTailor.PrefetchScheduleTypes.RecurringRetrieval, BaseFunction>? RecurringRetrieval { get; set; }
        }

        public class RecurringRetrieval : Humidifier.Base.BaseSubResource, IHaveMediaTailorPrefetchScheduleTypesTrafficShapingRetrievalWindowTrafficShapingRetrievalWindow, IHaveMediaTailorPrefetchScheduleTypesTrafficShapingTpsConfigurationTrafficShapingTpsConfiguration, IHaveDelayAfterAvailEndSeconds_Integer, IHaveTrafficShapingType, IHaveStringDictionaryOfDynamicVariables
        {
            /// <summary>
            /// TrafficShapingRetrievalWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-recurringretrieval.html#cfn-mediatailor-prefetchschedule-recurringretrieval-trafficshapingretrievalwindow
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrafficShapingRetrievalWindow
            /// </summary>
            public Union<Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingRetrievalWindow, BaseFunction>? TrafficShapingRetrievalWindow { get; set; }
            /// <summary>
            /// TrafficShapingTpsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-recurringretrieval.html#cfn-mediatailor-prefetchschedule-recurringretrieval-trafficshapingtpsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrafficShapingTpsConfiguration
            /// </summary>
            public Union<Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingTpsConfiguration, BaseFunction>? TrafficShapingTpsConfiguration { get; set; }
            /// <summary>
            /// DelayAfterAvailEndSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-recurringretrieval.html#cfn-mediatailor-prefetchschedule-recurringretrieval-delayafteravailendseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DelayAfterAvailEndSeconds { get; set; }
            /// <summary>
            /// TrafficShapingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-recurringretrieval.html#cfn-mediatailor-prefetchschedule-recurringretrieval-trafficshapingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrafficShapingType { get; set; }
            /// <summary>
            /// DynamicVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-recurringretrieval.html#cfn-mediatailor-prefetchschedule-recurringretrieval-dynamicvariables
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DynamicVariables { get; set; }
        }

        public class TrafficShapingRetrievalWindow : Humidifier.Base.BaseSubResource, IHaveRetrievalWindowDurationSeconds_Integer
        {
            /// <summary>
            /// RetrievalWindowDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-trafficshapingretrievalwindow.html#cfn-mediatailor-prefetchschedule-trafficshapingretrievalwindow-retrievalwindowdurationseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetrievalWindowDurationSeconds { get; set; }
        }

        public class TrafficShapingTpsConfiguration : Humidifier.Base.BaseSubResource, IHavePeakConcurrentUsers_Integer, IHavePeakTps_Integer
        {
            /// <summary>
            /// PeakConcurrentUsers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-trafficshapingtpsconfiguration.html#cfn-mediatailor-prefetchschedule-trafficshapingtpsconfiguration-peakconcurrentusers
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PeakConcurrentUsers { get; set; }
            /// <summary>
            /// PeakTps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-prefetchschedule-trafficshapingtpsconfiguration.html#cfn-mediatailor-prefetchschedule-trafficshapingtpsconfiguration-peaktps
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PeakTps { get; set; }
        }
    }
}