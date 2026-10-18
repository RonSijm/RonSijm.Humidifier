namespace Humidifier.CloudTrail
{
    using global::System.Collections.Generic;
    using EventDataStoreTypes;

    public class EventDataStore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMaxEventSize, IHaveKmsKeyId, IHaveListOfCloudTrailEventDataStoreTypesAdvancedEventSelectorAdvancedEventSelectors, IHaveTerminationProtectionEnabled_Boolean, IHaveMultiRegionEnabled_Boolean, IHaveRetentionPeriod_Integer, IHaveFederationEnabled_Boolean, IHaveIngestionEnabled_Boolean, IHaveName, IHaveListOfCloudTrailEventDataStoreTypesInsightSelectorInsightSelectors, IHaveOrganizationEnabled_Boolean, IHaveFederationRoleArn, IHaveInsightsDestination, IHaveBillingMode, IHaveListOfCloudTrailEventDataStoreTypesContextKeySelectorContextKeySelectors
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string EventDataStoreArn =  "EventDataStoreArn" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
        }

        public override string AWSTypeName { get => AWS.CloudTrail.EventDataStore; }
        /// <summary>
        /// MaxEventSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-maxeventsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MaxEventSize { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-kmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// AdvancedEventSelectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-advancedeventselectors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AdvancedEventSelector
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector>, IReadOnlyList<Union<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector, BaseFunction>>, BaseFunction>? AdvancedEventSelectors { get; set; }
        /// <summary>
        /// TerminationProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-terminationprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? TerminationProtectionEnabled { get; set; }
        /// <summary>
        /// MultiRegionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-multiregionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? MultiRegionEnabled { get; set; }
        /// <summary>
        /// RetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-retentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? RetentionPeriod { get; set; }
        /// <summary>
        /// FederationEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-federationenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? FederationEnabled { get; set; }
        /// <summary>
        /// IngestionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-ingestionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IngestionEnabled { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// InsightSelectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-insightselectors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InsightSelector
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector>, IReadOnlyList<Union<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector, BaseFunction>>, BaseFunction>? InsightSelectors { get; set; }
        /// <summary>
        /// OrganizationEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-organizationenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? OrganizationEnabled { get; set; }
        /// <summary>
        /// FederationRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-federationrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FederationRoleArn { get; set; }
        /// <summary>
        /// InsightsDestination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-insightsdestination
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InsightsDestination { get; set; }
        /// <summary>
        /// BillingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-billingmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BillingMode { get; set; }
        /// <summary>
        /// ContextKeySelectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-contextkeyselectors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ContextKeySelector
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudTrail.EventDataStoreTypes.ContextKeySelector>, IReadOnlyList<Union<Humidifier.CloudTrail.EventDataStoreTypes.ContextKeySelector, BaseFunction>>, BaseFunction>? ContextKeySelectors { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-eventdatastore.html#cfn-cloudtrail-eventdatastore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EventDataStoreTypes
    {
        public class AdvancedEventSelector : Humidifier.Base.BaseSubResource, IHaveListOfCloudTrailEventDataStoreTypesAdvancedFieldSelectorFieldSelectors, IHaveName
        {
            /// <summary>
            /// FieldSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-advancedeventselector.html#cfn-cloudtrail-eventdatastore-advancedeventselector-fieldselectors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdvancedFieldSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedFieldSelector>, IReadOnlyList<Union<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedFieldSelector, BaseFunction>>, BaseFunction>? FieldSelectors { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-advancedeventselector.html#cfn-cloudtrail-eventdatastore-advancedeventselector-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-advancedfieldselector.html#cfn-cloudtrail-eventdatastore-advancedfieldselector-field
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Equals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-advancedfieldselector.html#cfn-cloudtrail-eventdatastore-advancedfieldselector-equals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Equals { get; set; }
            /// <summary>
            /// NotStartsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-advancedfieldselector.html#cfn-cloudtrail-eventdatastore-advancedfieldselector-notstartswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotStartsWith { get; set; }
            /// <summary>
            /// NotEndsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-advancedfieldselector.html#cfn-cloudtrail-eventdatastore-advancedfieldselector-notendswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotEndsWith { get; set; }
            /// <summary>
            /// StartsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-advancedfieldselector.html#cfn-cloudtrail-eventdatastore-advancedfieldselector-startswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StartsWith { get; set; }
            /// <summary>
            /// EndsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-advancedfieldselector.html#cfn-cloudtrail-eventdatastore-advancedfieldselector-endswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EndsWith { get; set; }
            /// <summary>
            /// NotEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-advancedfieldselector.html#cfn-cloudtrail-eventdatastore-advancedfieldselector-notequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotEquals { get; set; }
        }

        public class ContextKeySelector : Humidifier.Base.BaseSubResource, IHaveType, IHaveStringListOfEquals
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-contextkeyselector.html#cfn-cloudtrail-eventdatastore-contextkeyselector-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Equals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-contextkeyselector.html#cfn-cloudtrail-eventdatastore-contextkeyselector-equals
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Equals { get; set; }
        }

        public class InsightSelector : Humidifier.Base.BaseSubResource, IHaveInsightType
        {
            /// <summary>
            /// InsightType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-eventdatastore-insightselector.html#cfn-cloudtrail-eventdatastore-insightselector-insighttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InsightType { get; set; }
        }
    }
}