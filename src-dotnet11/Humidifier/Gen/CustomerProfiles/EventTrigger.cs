namespace Humidifier.CustomerProfiles
{
    using global::System.Collections.Generic;
    using EventTriggerTypes;

    public class EventTrigger : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCustomerProfilesEventTriggerTypesEventTriggerLimitsEventTriggerLimits, IHaveDescription, IHaveDomainName, IHaveObjectTypeName, IHaveSegmentFilter, IHaveListOfCustomerProfilesEventTriggerTypesEventTriggerConditionEventTriggerConditions, IHaveEventTriggerName, IHaveCustomerProfilesEventTriggerTypesIntentFilterDefinitionIntentFilterDefinition
    {
        public class Attributes
        {
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CustomerProfiles.EventTrigger; }
        /// <summary>
        /// EventTriggerLimits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-eventtriggerlimits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EventTriggerLimits
        /// </summary>
        public Union<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits, BaseFunction>? EventTriggerLimits { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName { get; set; }

        /// <summary>
        /// ObjectTypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-objecttypename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ObjectTypeName { get; set; }
        /// <summary>
        /// SegmentFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-segmentfilter
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SegmentFilter { get; set; }

        /// <summary>
        /// EventTriggerConditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-eventtriggerconditions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EventTriggerCondition
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition>, IReadOnlyList<Union<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition, BaseFunction>>, BaseFunction>? EventTriggerConditions { get; set; }
        public Union<string, BaseFunction>? EventTriggerName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// IntentFilterDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-intentfilterdefinition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IntentFilterDefinition
        /// </summary>
        public Union<Humidifier.CustomerProfiles.EventTriggerTypes.IntentFilterDefinition, BaseFunction>? IntentFilterDefinition { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EventTriggerTypes
    {
        public class EventTriggerCondition : Humidifier.Base.BaseSubResource, IHaveListOfCustomerProfilesEventTriggerTypesEventTriggerDimensionEventTriggerDimensions, IHaveLogicalOperator
        {
            /// <summary>
            /// EventTriggerDimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-eventtriggercondition.html#cfn-customerprofiles-eventtrigger-eventtriggercondition-eventtriggerdimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EventTriggerDimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerDimension>, IReadOnlyList<Union<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerDimension, BaseFunction>>, BaseFunction>? EventTriggerDimensions { get; set; }
            /// <summary>
            /// LogicalOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-eventtriggercondition.html#cfn-customerprofiles-eventtrigger-eventtriggercondition-logicaloperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogicalOperator { get; set; }
        }

        public class EventTriggerDimension : Humidifier.Base.BaseSubResource, IHaveListOfCustomerProfilesEventTriggerTypesObjectAttributeObjectAttributes
        {
            /// <summary>
            /// ObjectAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-eventtriggerdimension.html#cfn-customerprofiles-eventtrigger-eventtriggerdimension-objectattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ObjectAttribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CustomerProfiles.EventTriggerTypes.ObjectAttribute>, IReadOnlyList<Union<Humidifier.CustomerProfiles.EventTriggerTypes.ObjectAttribute, BaseFunction>>, BaseFunction>? ObjectAttributes { get; set; }
        }

        public class EventTriggerLimits : Humidifier.Base.BaseSubResource, IHaveListOfCustomerProfilesEventTriggerTypesPeriodPeriods, IHaveEventExpiration_Long
        {
            /// <summary>
            /// Periods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-eventtriggerlimits.html#cfn-customerprofiles-eventtrigger-eventtriggerlimits-periods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Period
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CustomerProfiles.EventTriggerTypes.Period>, IReadOnlyList<Union<Humidifier.CustomerProfiles.EventTriggerTypes.Period, BaseFunction>>, BaseFunction>? Periods { get; set; }
            /// <summary>
            /// EventExpiration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-eventtriggerlimits.html#cfn-customerprofiles-eventtrigger-eventtriggerlimits-eventexpiration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? EventExpiration { get; set; }
        }

        public class Intent : Humidifier.Base.BaseSubResource, IHaveIntentDomain, IHaveType
        {
            /// <summary>
            /// IntentDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intent.html#cfn-customerprofiles-eventtrigger-intent-intentdomain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntentDomain { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intent.html#cfn-customerprofiles-eventtrigger-intent-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class IntentFilterCondition : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveStringListOfValues, IHaveCustomerProfilesEventTriggerTypesIntentIntent
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfiltercondition.html#cfn-customerprofiles-eventtrigger-intentfiltercondition-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfiltercondition.html#cfn-customerprofiles-eventtrigger-intentfiltercondition-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Intent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfiltercondition.html#cfn-customerprofiles-eventtrigger-intentfiltercondition-intent
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Intent
            /// </summary>
            public Union<Humidifier.CustomerProfiles.EventTriggerTypes.Intent, BaseFunction>? Intent { get; set; }
        }

        public class IntentFilterDefinition : Humidifier.Base.BaseSubResource, IHaveListOfCustomerProfilesEventTriggerTypesIntentFilterGroupGroups, IHaveLogicalOperator
        {
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfilterdefinition.html#cfn-customerprofiles-eventtrigger-intentfilterdefinition-groups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntentFilterGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CustomerProfiles.EventTriggerTypes.IntentFilterGroup>, IReadOnlyList<Union<Humidifier.CustomerProfiles.EventTriggerTypes.IntentFilterGroup, BaseFunction>>, BaseFunction>? Groups { get; set; }
            /// <summary>
            /// LogicalOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfilterdefinition.html#cfn-customerprofiles-eventtrigger-intentfilterdefinition-logicaloperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogicalOperator { get; set; }
        }

        public class IntentFilterGroup : Humidifier.Base.BaseSubResource, IHaveLogicalOperator, IHaveListOfCustomerProfilesEventTriggerTypesIntentFilterConditionConditions
        {
            /// <summary>
            /// LogicalOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfiltergroup.html#cfn-customerprofiles-eventtrigger-intentfiltergroup-logicaloperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogicalOperator { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfiltergroup.html#cfn-customerprofiles-eventtrigger-intentfiltergroup-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntentFilterCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CustomerProfiles.EventTriggerTypes.IntentFilterCondition>, IReadOnlyList<Union<Humidifier.CustomerProfiles.EventTriggerTypes.IntentFilterCondition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }

        public class ObjectAttribute : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveStringListOfValues, IHaveFieldName, IHaveSource
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-objectattribute.html#cfn-customerprofiles-eventtrigger-objectattribute-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-objectattribute.html#cfn-customerprofiles-eventtrigger-objectattribute-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-objectattribute.html#cfn-customerprofiles-eventtrigger-objectattribute-fieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldName { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-objectattribute.html#cfn-customerprofiles-eventtrigger-objectattribute-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class Period : Humidifier.Base.BaseSubResource, IHaveMaxInvocationsPerProfile_Integer, IHaveValue_Integer, IHaveUnlimited_Boolean, IHaveUnit
        {
            /// <summary>
            /// MaxInvocationsPerProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-period.html#cfn-customerprofiles-eventtrigger-period-maxinvocationsperprofile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxInvocationsPerProfile { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-period.html#cfn-customerprofiles-eventtrigger-period-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unlimited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-period.html#cfn-customerprofiles-eventtrigger-period-unlimited
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Unlimited { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-period.html#cfn-customerprofiles-eventtrigger-period-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }
    }
}