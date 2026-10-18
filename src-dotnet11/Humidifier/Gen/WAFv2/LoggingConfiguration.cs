namespace Humidifier.WAFv2
{
    using global::System.Collections.Generic;
    using LoggingConfigurationTypes;

    public class LoggingConfiguration : Humidifier.Base.BaseResource, IHaveResourceArn, IHaveStringListOfLogDestinationConfigs, IHaveListOfWAFv2LoggingConfigurationTypesFieldToMatchRedactedFields, IHaveWAFv2LoggingConfigurationTypesLoggingFilterLoggingFilter
    {
        public class Attributes
        {
            public static string ManagedByFirewallManager =  "ManagedByFirewallManager" ;
        }

        public override string AWSTypeName { get => AWS.WAFv2.LoggingConfiguration; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-loggingconfiguration.html#cfn-wafv2-loggingconfiguration-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceArn { get; set; }

        /// <summary>
        /// LogDestinationConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-loggingconfiguration.html#cfn-wafv2-loggingconfiguration-logdestinationconfigs
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogDestinationConfigs { get; set; }
        /// <summary>
        /// RedactedFields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-loggingconfiguration.html#cfn-wafv2-loggingconfiguration-redactedfields
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FieldToMatch
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch>, IReadOnlyList<Union<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch, BaseFunction>>, BaseFunction>? RedactedFields { get; set; }
        /// <summary>
        /// LoggingFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-loggingconfiguration.html#cfn-wafv2-loggingconfiguration-loggingfilter
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingFilter
        /// </summary>
        public Union<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter, BaseFunction>? LoggingFilter { get; set; }
    }

    namespace LoggingConfigurationTypes
    {
        public class ActionCondition : Humidifier.Base.BaseSubResource, IHaveAction
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-actioncondition.html#cfn-wafv2-loggingconfiguration-actioncondition-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource, IHaveWAFv2LoggingConfigurationTypesLabelNameConditionLabelNameCondition, IHaveWAFv2LoggingConfigurationTypesActionConditionActionCondition
        {
            /// <summary>
            /// LabelNameCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-condition.html#cfn-wafv2-loggingconfiguration-condition-labelnamecondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelNameCondition
            /// </summary>
            public Union<Humidifier.WAFv2.LoggingConfigurationTypes.LabelNameCondition, BaseFunction>? LabelNameCondition { get; set; }
            /// <summary>
            /// ActionCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-condition.html#cfn-wafv2-loggingconfiguration-condition-actioncondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActionCondition
            /// </summary>
            public Union<Humidifier.WAFv2.LoggingConfigurationTypes.ActionCondition, BaseFunction>? ActionCondition { get; set; }
        }

        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveQueryString_Json, IHaveUriPath_Json, IHaveMethod_Json, IHaveWAFv2LoggingConfigurationTypesSingleHeaderSingleHeader
        {
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-fieldtomatch.html#cfn-wafv2-loggingconfiguration-fieldtomatch-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-fieldtomatch.html#cfn-wafv2-loggingconfiguration-fieldtomatch-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? UriPath { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-fieldtomatch.html#cfn-wafv2-loggingconfiguration-fieldtomatch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Method { get; set; }
            /// <summary>
            /// SingleHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-fieldtomatch.html#cfn-wafv2-loggingconfiguration-fieldtomatch-singleheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeader
            /// </summary>
            public Union<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader, BaseFunction>? SingleHeader { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveRequirement, IHaveBehavior, IHaveListOfWAFv2LoggingConfigurationTypesConditionConditions
        {
            /// <summary>
            /// Requirement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-filter.html#cfn-wafv2-loggingconfiguration-filter-requirement
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Requirement { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-filter.html#cfn-wafv2-loggingconfiguration-filter-behavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Behavior { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-filter.html#cfn-wafv2-loggingconfiguration-filter-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Condition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.LoggingConfigurationTypes.Condition>, IReadOnlyList<Union<Humidifier.WAFv2.LoggingConfigurationTypes.Condition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }

        public class LabelNameCondition : Humidifier.Base.BaseSubResource, IHaveLabelName
        {
            /// <summary>
            /// LabelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-labelnamecondition.html#cfn-wafv2-loggingconfiguration-labelnamecondition-labelname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LabelName { get; set; }
        }

        public class LoggingFilter : Humidifier.Base.BaseSubResource, IHaveListOfWAFv2LoggingConfigurationTypesFilterFilters, IHaveDefaultBehavior
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-loggingfilter.html#cfn-wafv2-loggingconfiguration-loggingfilter-filters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WAFv2.LoggingConfigurationTypes.Filter>, IReadOnlyList<Union<Humidifier.WAFv2.LoggingConfigurationTypes.Filter, BaseFunction>>, BaseFunction>? Filters { get; set; }
            /// <summary>
            /// DefaultBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-loggingfilter.html#cfn-wafv2-loggingconfiguration-loggingfilter-defaultbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultBehavior { get; set; }
        }

        public class SingleHeader : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-singleheader.html#cfn-wafv2-loggingconfiguration-singleheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}