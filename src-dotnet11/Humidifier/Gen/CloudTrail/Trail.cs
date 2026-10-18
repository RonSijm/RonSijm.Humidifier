namespace Humidifier.CloudTrail
{
    using global::System.Collections.Generic;
    using TrailTypes;

    public class Trail : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIncludeGlobalServiceEvents_Boolean, IHaveListOfCloudTrailTrailTypesEventSelectorEventSelectors, IHaveKMSKeyId, IHaveListOfCloudTrailTrailTypesAggregationConfigurationAggregationConfigurations, IHaveCloudWatchLogsRoleArn, IHaveS3KeyPrefix, IHaveListOfCloudTrailTrailTypesAdvancedEventSelectorAdvancedEventSelectors, IHaveTrailName, IHaveIsOrganizationTrail_Boolean, IHaveListOfCloudTrailTrailTypesInsightSelectorInsightSelectors, IHaveCloudWatchLogsLogGroupArn, IHaveSnsTopicName, IHaveIsMultiRegionTrail_Boolean, IHaveS3BucketName, IHaveEnableLogFileValidation_Boolean, IHaveIsLogging_Boolean
    {
        public class Attributes
        {
            public static string SnsTopicArn =  "SnsTopicArn" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudTrail.Trail; }
        /// <summary>
        /// IncludeGlobalServiceEvents
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-includeglobalserviceevents
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IncludeGlobalServiceEvents { get; set; }
        /// <summary>
        /// EventSelectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-eventselectors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EventSelector
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudTrail.TrailTypes.EventSelector>, IReadOnlyList<Union<Humidifier.CloudTrail.TrailTypes.EventSelector, BaseFunction>>, BaseFunction>? EventSelectors { get; set; }
        /// <summary>
        /// KMSKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-kmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KMSKeyId { get; set; }
        /// <summary>
        /// AggregationConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-aggregationconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AggregationConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudTrail.TrailTypes.AggregationConfiguration>, IReadOnlyList<Union<Humidifier.CloudTrail.TrailTypes.AggregationConfiguration, BaseFunction>>, BaseFunction>? AggregationConfigurations { get; set; }
        /// <summary>
        /// CloudWatchLogsRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-cloudwatchlogsrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CloudWatchLogsRoleArn { get; set; }
        /// <summary>
        /// S3KeyPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-s3keyprefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? S3KeyPrefix { get; set; }
        /// <summary>
        /// AdvancedEventSelectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-advancedeventselectors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AdvancedEventSelector
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector>, IReadOnlyList<Union<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector, BaseFunction>>, BaseFunction>? AdvancedEventSelectors { get; set; }
        public Union<string, BaseFunction>? TrailName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// IsOrganizationTrail
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-isorganizationtrail
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsOrganizationTrail { get; set; }
        /// <summary>
        /// InsightSelectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-insightselectors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InsightSelector
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudTrail.TrailTypes.InsightSelector>, IReadOnlyList<Union<Humidifier.CloudTrail.TrailTypes.InsightSelector, BaseFunction>>, BaseFunction>? InsightSelectors { get; set; }
        /// <summary>
        /// CloudWatchLogsLogGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-cloudwatchlogsloggrouparn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CloudWatchLogsLogGroupArn { get; set; }
        /// <summary>
        /// SnsTopicName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-snstopicname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnsTopicName { get; set; }
        /// <summary>
        /// IsMultiRegionTrail
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-ismultiregiontrail
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsMultiRegionTrail { get; set; }

        /// <summary>
        /// S3BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-s3bucketname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? S3BucketName { get; set; }
        /// <summary>
        /// EnableLogFileValidation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-enablelogfilevalidation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableLogFileValidation { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// IsLogging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-islogging
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? IsLogging { get; set; }
    }

    namespace TrailTypes
    {
        public class AdvancedEventSelector : Humidifier.Base.BaseSubResource, IHaveListOfCloudTrailTrailTypesAdvancedFieldSelectorFieldSelectors, IHaveName
        {
            /// <summary>
            /// FieldSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-advancedeventselector.html#cfn-cloudtrail-trail-advancedeventselector-fieldselectors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdvancedFieldSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudTrail.TrailTypes.AdvancedFieldSelector>, IReadOnlyList<Union<Humidifier.CloudTrail.TrailTypes.AdvancedFieldSelector, BaseFunction>>, BaseFunction>? FieldSelectors { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-advancedeventselector.html#cfn-cloudtrail-trail-advancedeventselector-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class AdvancedFieldSelector : Humidifier.Base.BaseSubResource, IHaveField, IHaveStringListOfEquals, IHaveStringListOfNotStartsWith, IHaveStringListOfNotEndsWith, IHaveStringListOfStartsWith, IHaveStringListOfEndsWith, IHaveStringListOfNotEquals
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-advancedfieldselector.html#cfn-cloudtrail-trail-advancedfieldselector-field
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Equals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-advancedfieldselector.html#cfn-cloudtrail-trail-advancedfieldselector-equals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Equals { get; set; }
            /// <summary>
            /// NotStartsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-advancedfieldselector.html#cfn-cloudtrail-trail-advancedfieldselector-notstartswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotStartsWith { get; set; }
            /// <summary>
            /// NotEndsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-advancedfieldselector.html#cfn-cloudtrail-trail-advancedfieldselector-notendswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotEndsWith { get; set; }
            /// <summary>
            /// StartsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-advancedfieldselector.html#cfn-cloudtrail-trail-advancedfieldselector-startswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StartsWith { get; set; }
            /// <summary>
            /// EndsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-advancedfieldselector.html#cfn-cloudtrail-trail-advancedfieldselector-endswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EndsWith { get; set; }
            /// <summary>
            /// NotEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-advancedfieldselector.html#cfn-cloudtrail-trail-advancedfieldselector-notequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotEquals { get; set; }
        }

        public class AggregationConfiguration : Humidifier.Base.BaseSubResource, IHaveEventCategory, IHaveStringListOfTemplates
        {
            /// <summary>
            /// EventCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-aggregationconfiguration.html#cfn-cloudtrail-trail-aggregationconfiguration-eventcategory
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventCategory { get; set; }
            /// <summary>
            /// Templates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-aggregationconfiguration.html#cfn-cloudtrail-trail-aggregationconfiguration-templates
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Templates { get; set; }
        }

        public class DataResource : Humidifier.Base.BaseSubResource, IHaveType, IHaveStringListOfValues
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-dataresource.html#cfn-cloudtrail-trail-dataresource-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-dataresource.html#cfn-cloudtrail-trail-dataresource-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class EventSelector : Humidifier.Base.BaseSubResource, IHaveIncludeManagementEvents_Boolean, IHaveReadWriteType, IHaveStringListOfExcludeManagementEventSources, IHaveListOfCloudTrailTrailTypesDataResourceDataResources
        {
            /// <summary>
            /// IncludeManagementEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html#cfn-cloudtrail-trail-eventselector-includemanagementevents
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeManagementEvents { get; set; }
            /// <summary>
            /// ReadWriteType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html#cfn-cloudtrail-trail-eventselector-readwritetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReadWriteType { get; set; }
            /// <summary>
            /// ExcludeManagementEventSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html#cfn-cloudtrail-trail-eventselector-excludemanagementeventsources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludeManagementEventSources { get; set; }
            /// <summary>
            /// DataResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html#cfn-cloudtrail-trail-eventselector-dataresources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataResource
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudTrail.TrailTypes.DataResource>, IReadOnlyList<Union<Humidifier.CloudTrail.TrailTypes.DataResource, BaseFunction>>, BaseFunction>? DataResources { get; set; }
        }

        public class InsightSelector : Humidifier.Base.BaseSubResource, IHaveInsightType, IHaveStringListOfEventCategories
        {
            /// <summary>
            /// InsightType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-insightselector.html#cfn-cloudtrail-trail-insightselector-insighttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InsightType { get; set; }
            /// <summary>
            /// EventCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-insightselector.html#cfn-cloudtrail-trail-insightselector-eventcategories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EventCategories { get; set; }
        }
    }
}