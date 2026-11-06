namespace Humidifier.CustomerProfiles
{
    using global::System.Collections.Generic;
    using EventTriggerTypes;

    public class EventTrigger : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveDomainName, IHaveObjectTypeName
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
        public Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits EventTriggerLimits { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }

        /// <summary>
        /// ObjectTypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-objecttypename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ObjectTypeName { get; set; }
        /// <summary>
        /// SegmentFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-segmentfilter
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SegmentFilter { get; set; }

        /// <summary>
        /// EventTriggerConditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-eventtriggerconditions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EventTriggerCondition
        /// </summary>
        [Required]
        public List<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> EventTriggerConditions { get; set; }
        public dynamic EventTriggerName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// IntentFilterDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-intentfilterdefinition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IntentFilterDefinition
        /// </summary>
        public Humidifier.CustomerProfiles.EventTriggerTypes.IntentFilterDefinition IntentFilterDefinition { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-eventtrigger.html#cfn-customerprofiles-eventtrigger-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace EventTriggerTypes
    {
        public class EventTriggerCondition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EventTriggerDimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-eventtriggercondition.html#cfn-customerprofiles-eventtrigger-eventtriggercondition-eventtriggerdimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EventTriggerDimension
            /// </summary>
            public List<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerDimension> EventTriggerDimensions { get; set; }
            /// <summary>
            /// LogicalOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-eventtriggercondition.html#cfn-customerprofiles-eventtrigger-eventtriggercondition-logicaloperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogicalOperator { get; set; }
        }

        public class EventTriggerDimension : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ObjectAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-eventtriggerdimension.html#cfn-customerprofiles-eventtrigger-eventtriggerdimension-objectattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ObjectAttribute
            /// </summary>
            public List<Humidifier.CustomerProfiles.EventTriggerTypes.ObjectAttribute> ObjectAttributes { get; set; }
        }

        public class EventTriggerLimits : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Periods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-eventtriggerlimits.html#cfn-customerprofiles-eventtrigger-eventtriggerlimits-periods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Period
            /// </summary>
            public List<Humidifier.CustomerProfiles.EventTriggerTypes.Period> Periods { get; set; }
            /// <summary>
            /// EventExpiration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-eventtriggerlimits.html#cfn-customerprofiles-eventtrigger-eventtriggerlimits-eventexpiration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic EventExpiration { get; set; }
        }

        public class Intent : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// IntentDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intent.html#cfn-customerprofiles-eventtrigger-intent-intentdomain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IntentDomain { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intent.html#cfn-customerprofiles-eventtrigger-intent-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class IntentFilterCondition : Humidifier.Base.BaseSubResource, IHaveValues, IHaveComparisonOperator
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfiltercondition.html#cfn-customerprofiles-eventtrigger-intentfiltercondition-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonOperator { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfiltercondition.html#cfn-customerprofiles-eventtrigger-intentfiltercondition-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Intent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfiltercondition.html#cfn-customerprofiles-eventtrigger-intentfiltercondition-intent
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Intent
            /// </summary>
            public Humidifier.CustomerProfiles.EventTriggerTypes.Intent Intent { get; set; }
        }

        public class IntentFilterDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfilterdefinition.html#cfn-customerprofiles-eventtrigger-intentfilterdefinition-groups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntentFilterGroup
            /// </summary>
            public List<Humidifier.CustomerProfiles.EventTriggerTypes.IntentFilterGroup> Groups { get; set; }
            /// <summary>
            /// LogicalOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfilterdefinition.html#cfn-customerprofiles-eventtrigger-intentfilterdefinition-logicaloperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogicalOperator { get; set; }
        }

        public class IntentFilterGroup : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LogicalOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfiltergroup.html#cfn-customerprofiles-eventtrigger-intentfiltergroup-logicaloperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogicalOperator { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-intentfiltergroup.html#cfn-customerprofiles-eventtrigger-intentfiltergroup-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntentFilterCondition
            /// </summary>
            public List<Humidifier.CustomerProfiles.EventTriggerTypes.IntentFilterCondition> Conditions { get; set; }
        }

        public class ObjectAttribute : Humidifier.Base.BaseSubResource, IHaveValues, IHaveSource, IHaveComparisonOperator, IHaveFieldName
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-objectattribute.html#cfn-customerprofiles-eventtrigger-objectattribute-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonOperator { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-objectattribute.html#cfn-customerprofiles-eventtrigger-objectattribute-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-objectattribute.html#cfn-customerprofiles-eventtrigger-objectattribute-fieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldName { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-objectattribute.html#cfn-customerprofiles-eventtrigger-objectattribute-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class Period : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit, IHaveUnlimited
        {
            /// <summary>
            /// MaxInvocationsPerProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-period.html#cfn-customerprofiles-eventtrigger-period-maxinvocationsperprofile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxInvocationsPerProfile { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-period.html#cfn-customerprofiles-eventtrigger-period-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unlimited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-period.html#cfn-customerprofiles-eventtrigger-period-unlimited
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Unlimited { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-eventtrigger-period.html#cfn-customerprofiles-eventtrigger-period-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }
    }
}