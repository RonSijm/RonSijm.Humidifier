namespace Humidifier.WAFv2
{
    using System.Collections.Generic;
    using LoggingConfigurationTypes;

    public class LoggingConfiguration : Humidifier.Base.BaseResource, IHaveResourceArn
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
        public dynamic ResourceArn { get; set; }

        /// <summary>
        /// LogDestinationConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-loggingconfiguration.html#cfn-wafv2-loggingconfiguration-logdestinationconfigs
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic LogDestinationConfigs { get; set; }
        /// <summary>
        /// RedactedFields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-loggingconfiguration.html#cfn-wafv2-loggingconfiguration-redactedfields
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FieldToMatch
        /// </summary>
        public List<Humidifier.WAFv2.LoggingConfigurationTypes.FieldToMatch> RedactedFields { get; set; }
        /// <summary>
        /// LoggingFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-loggingconfiguration.html#cfn-wafv2-loggingconfiguration-loggingfilter
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingFilter
        /// </summary>
        public Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter LoggingFilter { get; set; }
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
            public dynamic Action { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LabelNameCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-condition.html#cfn-wafv2-loggingconfiguration-condition-labelnamecondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelNameCondition
            /// </summary>
            public Humidifier.WAFv2.LoggingConfigurationTypes.LabelNameCondition LabelNameCondition { get; set; }
            /// <summary>
            /// ActionCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-condition.html#cfn-wafv2-loggingconfiguration-condition-actioncondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActionCondition
            /// </summary>
            public Humidifier.WAFv2.LoggingConfigurationTypes.ActionCondition ActionCondition { get; set; }
        }

        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveQueryString, IHaveMethod, IHaveUriPath
        {
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-fieldtomatch.html#cfn-wafv2-loggingconfiguration-fieldtomatch-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic QueryString { get; set; }
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-fieldtomatch.html#cfn-wafv2-loggingconfiguration-fieldtomatch-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic UriPath { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-fieldtomatch.html#cfn-wafv2-loggingconfiguration-fieldtomatch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Method { get; set; }
            /// <summary>
            /// SingleHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-fieldtomatch.html#cfn-wafv2-loggingconfiguration-fieldtomatch-singleheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeader
            /// </summary>
            public Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader SingleHeader { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveBehavior
        {
            /// <summary>
            /// Requirement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-filter.html#cfn-wafv2-loggingconfiguration-filter-requirement
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Requirement { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-filter.html#cfn-wafv2-loggingconfiguration-filter-behavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Behavior { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-filter.html#cfn-wafv2-loggingconfiguration-filter-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Condition
            /// </summary>
            public List<Humidifier.WAFv2.LoggingConfigurationTypes.Condition> Conditions { get; set; }
        }

        public class LabelNameCondition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LabelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-labelnamecondition.html#cfn-wafv2-loggingconfiguration-labelnamecondition-labelname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelName { get; set; }
        }

        public class LoggingFilter : Humidifier.Base.BaseSubResource, IHaveDefaultBehavior
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-loggingfilter.html#cfn-wafv2-loggingconfiguration-loggingfilter-filters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public List<Humidifier.WAFv2.LoggingConfigurationTypes.Filter> Filters { get; set; }
            /// <summary>
            /// DefaultBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-loggingfilter.html#cfn-wafv2-loggingconfiguration-loggingfilter-defaultbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultBehavior { get; set; }
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
            public dynamic Name { get; set; }
        }
    }
}