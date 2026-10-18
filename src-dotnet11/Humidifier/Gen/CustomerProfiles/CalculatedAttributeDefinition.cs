namespace Humidifier.CustomerProfiles
{
    using global::System.Collections.Generic;
    using CalculatedAttributeDefinitionTypes;

    public class CalculatedAttributeDefinition : Humidifier.Base.BaseResource, IHaveTags, IHaveUseHistoricalData_Boolean, IHaveDescription, IHaveCustomerProfilesCalculatedAttributeDefinitionTypesAttributeDetailsAttributeDetails, IHaveStatistic, IHaveDomainName, IHaveDisplayName, IHaveCalculatedAttributeName, IHaveCustomerProfilesCalculatedAttributeDefinitionTypesConditionsConditions
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string Readiness =  "Readiness" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CustomerProfiles.CalculatedAttributeDefinition; }
        /// <summary>
        /// UseHistoricalData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-calculatedattributedefinition.html#cfn-customerprofiles-calculatedattributedefinition-usehistoricaldata
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UseHistoricalData { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-calculatedattributedefinition.html#cfn-customerprofiles-calculatedattributedefinition-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// AttributeDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-calculatedattributedefinition.html#cfn-customerprofiles-calculatedattributedefinition-attributedetails
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AttributeDetails
        /// </summary>
        [Required]
        public Union<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails, BaseFunction>? AttributeDetails { get; set; }

        /// <summary>
        /// Statistic
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-calculatedattributedefinition.html#cfn-customerprofiles-calculatedattributedefinition-statistic
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Statistic { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-calculatedattributedefinition.html#cfn-customerprofiles-calculatedattributedefinition-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-calculatedattributedefinition.html#cfn-customerprofiles-calculatedattributedefinition-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// CalculatedAttributeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-calculatedattributedefinition.html#cfn-customerprofiles-calculatedattributedefinition-calculatedattributename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CalculatedAttributeName { get; set; }
        /// <summary>
        /// Conditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-calculatedattributedefinition.html#cfn-customerprofiles-calculatedattributedefinition-conditions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Conditions
        /// </summary>
        public Union<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions, BaseFunction>? Conditions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-calculatedattributedefinition.html#cfn-customerprofiles-calculatedattributedefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CalculatedAttributeDefinitionTypes
    {
        public class AttributeDetails : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveListOfCustomerProfilesCalculatedAttributeDefinitionTypesAttributeItemAttributes_
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-attributedetails.html#cfn-customerprofiles-calculatedattributedefinition-attributedetails-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-attributedetails.html#cfn-customerprofiles-calculatedattributedefinition-attributedetails-attributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AttributeItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeItem>, IReadOnlyList<Union<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeItem, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
        }

        public class AttributeItem : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-attributeitem.html#cfn-customerprofiles-calculatedattributedefinition-attributeitem-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Conditions : Humidifier.Base.BaseSubResource, IHaveCustomerProfilesCalculatedAttributeDefinitionTypesRangeRange, IHaveObjectCount_Integer, IHaveCustomerProfilesCalculatedAttributeDefinitionTypesThresholdThreshold
        {
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-conditions.html#cfn-customerprofiles-calculatedattributedefinition-conditions-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Range
            /// </summary>
            public Union<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range, BaseFunction>? Range { get; set; }
            /// <summary>
            /// ObjectCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-conditions.html#cfn-customerprofiles-calculatedattributedefinition-conditions-objectcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ObjectCount { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-conditions.html#cfn-customerprofiles-calculatedattributedefinition-conditions-threshold
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Threshold
            /// </summary>
            public Union<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Threshold, BaseFunction>? Threshold { get; set; }
        }

        public class Range : Humidifier.Base.BaseSubResource, IHaveCustomerProfilesCalculatedAttributeDefinitionTypesValueRangeValueRange, IHaveTimestampSource, IHaveValue_Integer, IHaveTimestampFormat, IHaveUnit
        {
            /// <summary>
            /// ValueRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-range.html#cfn-customerprofiles-calculatedattributedefinition-range-valuerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ValueRange
            /// </summary>
            public Union<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange, BaseFunction>? ValueRange { get; set; }
            /// <summary>
            /// TimestampSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-range.html#cfn-customerprofiles-calculatedattributedefinition-range-timestampsource
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimestampSource { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-range.html#cfn-customerprofiles-calculatedattributedefinition-range-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// TimestampFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-range.html#cfn-customerprofiles-calculatedattributedefinition-range-timestampformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimestampFormat { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-range.html#cfn-customerprofiles-calculatedattributedefinition-range-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class Readiness : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveProgressPercentage_Integer
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-readiness.html#cfn-customerprofiles-calculatedattributedefinition-readiness-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// ProgressPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-readiness.html#cfn-customerprofiles-calculatedattributedefinition-readiness-progresspercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProgressPercentage { get; set; }
        }

        public class Threshold : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveValue
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-threshold.html#cfn-customerprofiles-calculatedattributedefinition-threshold-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-threshold.html#cfn-customerprofiles-calculatedattributedefinition-threshold-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class ValueRange : Humidifier.Base.BaseSubResource, IHaveStart_Integer, IHaveEnd_Integer
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-valuerange.html#cfn-customerprofiles-calculatedattributedefinition-valuerange-start
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-calculatedattributedefinition-valuerange.html#cfn-customerprofiles-calculatedattributedefinition-valuerange-end
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? End { get; set; }
        }
    }
}