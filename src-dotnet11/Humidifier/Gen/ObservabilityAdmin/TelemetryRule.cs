namespace Humidifier.ObservabilityAdmin
{
    using global::System.Collections.Generic;
    using TelemetryRuleTypes;

    public class TelemetryRule : Humidifier.Base.BaseResource, IHaveTags, IHaveObservabilityAdminTelemetryRuleTypesTelemetryRuleRule, IHaveRuleName
    {
        public class Attributes
        {
            public static string RegionStatuses =  "RegionStatuses" ;
            public static string RuleArn =  "RuleArn" ;
        }

        public override string AWSTypeName { get => AWS.ObservabilityAdmin.TelemetryRule; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-telemetryrule.html#cfn-observabilityadmin-telemetryrule-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TelemetryRule
        /// </summary>
        [Required]
        public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule, BaseFunction>? Rule { get; set; }

        /// <summary>
        /// RuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-telemetryrule.html#cfn-observabilityadmin-telemetryrule-rulename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-telemetryrule.html#cfn-observabilityadmin-telemetryrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TelemetryRuleTypes
    {
        public class ActionCondition : Humidifier.Base.BaseSubResource, IHaveAction
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-actioncondition.html#cfn-observabilityadmin-telemetryrule-actioncondition-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
        }

        public class AdvancedEventSelector : Humidifier.Base.BaseSubResource, IHaveListOfObservabilityAdminTelemetryRuleTypesAdvancedFieldSelectorFieldSelectors, IHaveName
        {
            /// <summary>
            /// FieldSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-advancedeventselector.html#cfn-observabilityadmin-telemetryrule-advancedeventselector-fieldselectors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdvancedFieldSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.AdvancedFieldSelector>, IReadOnlyList<Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.AdvancedFieldSelector, BaseFunction>>, BaseFunction>? FieldSelectors { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-advancedeventselector.html#cfn-observabilityadmin-telemetryrule-advancedeventselector-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-advancedfieldselector.html#cfn-observabilityadmin-telemetryrule-advancedfieldselector-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Equals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-advancedfieldselector.html#cfn-observabilityadmin-telemetryrule-advancedfieldselector-equals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Equals { get; set; }
            /// <summary>
            /// NotStartsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-advancedfieldselector.html#cfn-observabilityadmin-telemetryrule-advancedfieldselector-notstartswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotStartsWith { get; set; }
            /// <summary>
            /// NotEndsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-advancedfieldselector.html#cfn-observabilityadmin-telemetryrule-advancedfieldselector-notendswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotEndsWith { get; set; }
            /// <summary>
            /// StartsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-advancedfieldselector.html#cfn-observabilityadmin-telemetryrule-advancedfieldselector-startswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StartsWith { get; set; }
            /// <summary>
            /// EndsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-advancedfieldselector.html#cfn-observabilityadmin-telemetryrule-advancedfieldselector-endswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EndsWith { get; set; }
            /// <summary>
            /// NotEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-advancedfieldselector.html#cfn-observabilityadmin-telemetryrule-advancedfieldselector-notequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotEquals { get; set; }
        }

        public class CloudtrailParameters : Humidifier.Base.BaseSubResource, IHaveListOfObservabilityAdminTelemetryRuleTypesAdvancedEventSelectorAdvancedEventSelectors
        {
            /// <summary>
            /// AdvancedEventSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-cloudtrailparameters.html#cfn-observabilityadmin-telemetryrule-cloudtrailparameters-advancedeventselectors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdvancedEventSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.AdvancedEventSelector>, IReadOnlyList<Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.AdvancedEventSelector, BaseFunction>>, BaseFunction>? AdvancedEventSelectors { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource, IHaveObservabilityAdminTelemetryRuleTypesLabelNameConditionLabelNameCondition, IHaveObservabilityAdminTelemetryRuleTypesActionConditionActionCondition
        {
            /// <summary>
            /// LabelNameCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-condition.html#cfn-observabilityadmin-telemetryrule-condition-labelnamecondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelNameCondition
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LabelNameCondition, BaseFunction>? LabelNameCondition { get; set; }
            /// <summary>
            /// ActionCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-condition.html#cfn-observabilityadmin-telemetryrule-condition-actioncondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActionCondition
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.ActionCondition, BaseFunction>? ActionCondition { get; set; }
        }

        public class ELBLoadBalancerLoggingParameters : Humidifier.Base.BaseSubResource, IHaveFieldDelimiter, IHaveOutputFormat
        {
            /// <summary>
            /// FieldDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-elbloadbalancerloggingparameters.html#cfn-observabilityadmin-telemetryrule-elbloadbalancerloggingparameters-fielddelimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldDelimiter { get; set; }
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-elbloadbalancerloggingparameters.html#cfn-observabilityadmin-telemetryrule-elbloadbalancerloggingparameters-outputformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputFormat { get; set; }
        }

        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveUriPath, IHaveQueryString, IHaveMethod, IHaveObservabilityAdminTelemetryRuleTypesSingleHeaderSingleHeader
        {
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-fieldtomatch.html#cfn-observabilityadmin-telemetryrule-fieldtomatch-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UriPath { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-fieldtomatch.html#cfn-observabilityadmin-telemetryrule-fieldtomatch-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-fieldtomatch.html#cfn-observabilityadmin-telemetryrule-fieldtomatch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Method { get; set; }
            /// <summary>
            /// SingleHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-fieldtomatch.html#cfn-observabilityadmin-telemetryrule-fieldtomatch-singleheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeader
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.SingleHeader, BaseFunction>? SingleHeader { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveRequirement, IHaveBehavior, IHaveListOfObservabilityAdminTelemetryRuleTypesConditionConditions
        {
            /// <summary>
            /// Requirement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-filter.html#cfn-observabilityadmin-telemetryrule-filter-requirement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Requirement { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-filter.html#cfn-observabilityadmin-telemetryrule-filter-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Behavior { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-filter.html#cfn-observabilityadmin-telemetryrule-filter-conditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Condition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.Condition>, IReadOnlyList<Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.Condition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }

        public class LabelNameCondition : Humidifier.Base.BaseSubResource, IHaveLabelName
        {
            /// <summary>
            /// LabelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-labelnamecondition.html#cfn-observabilityadmin-telemetryrule-labelnamecondition-labelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LabelName { get; set; }
        }

        public class LogDeliveryParameters : Humidifier.Base.BaseSubResource, IHaveStringListOfLogTypes
        {
            /// <summary>
            /// LogTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-logdeliveryparameters.html#cfn-observabilityadmin-telemetryrule-logdeliveryparameters-logtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogTypes { get; set; }
        }

        public class LoggingFilter : Humidifier.Base.BaseSubResource, IHaveListOfObservabilityAdminTelemetryRuleTypesFilterFilters, IHaveDefaultBehavior
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-loggingfilter.html#cfn-observabilityadmin-telemetryrule-loggingfilter-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.Filter>, IReadOnlyList<Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.Filter, BaseFunction>>, BaseFunction>? Filters { get; set; }
            /// <summary>
            /// DefaultBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-loggingfilter.html#cfn-observabilityadmin-telemetryrule-loggingfilter-defaultbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultBehavior { get; set; }
        }

        public class MskMonitoringParameters : Humidifier.Base.BaseSubResource, IHaveEnhancedMonitoring
        {
            /// <summary>
            /// EnhancedMonitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-mskmonitoringparameters.html#cfn-observabilityadmin-telemetryrule-mskmonitoringparameters-enhancedmonitoring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnhancedMonitoring { get; set; }
        }

        public class RegionStatus : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveRuleArn, IHaveRegion
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-regionstatus.html#cfn-observabilityadmin-telemetryrule-regionstatus-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// RuleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-regionstatus.html#cfn-observabilityadmin-telemetryrule-regionstatus-rulearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleArn { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-regionstatus.html#cfn-observabilityadmin-telemetryrule-regionstatus-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }

        public class SingleHeader : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-singleheader.html#cfn-observabilityadmin-telemetryrule-singleheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TelemetryDestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveRetentionInDays_Integer, IHaveObservabilityAdminTelemetryRuleTypesMskMonitoringParametersMskMonitoringParameters, IHaveKmsKeyArn, IHaveDestinationPattern, IHaveObservabilityAdminTelemetryRuleTypesELBLoadBalancerLoggingParametersELBLoadBalancerLoggingParameters, IHaveObservabilityAdminTelemetryRuleTypesVPCFlowLogParametersVPCFlowLogParameters, IHaveObservabilityAdminTelemetryRuleTypesCloudtrailParametersCloudtrailParameters, IHaveObservabilityAdminTelemetryRuleTypesWAFLoggingParametersWAFLoggingParameters, IHaveObservabilityAdminTelemetryRuleTypesLogDeliveryParametersLogDeliveryParameters, IHaveDestinationType
        {
            /// <summary>
            /// RetentionInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-telemetryrule-telemetrydestinationconfiguration-retentionindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetentionInDays { get; set; }
            /// <summary>
            /// MskMonitoringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-telemetryrule-telemetrydestinationconfiguration-mskmonitoringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MskMonitoringParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.MskMonitoringParameters, BaseFunction>? MskMonitoringParameters { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-telemetryrule-telemetrydestinationconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// DestinationPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-telemetryrule-telemetrydestinationconfiguration-destinationpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPattern { get; set; }
            /// <summary>
            /// ELBLoadBalancerLoggingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-telemetryrule-telemetrydestinationconfiguration-elbloadbalancerloggingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ELBLoadBalancerLoggingParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.ELBLoadBalancerLoggingParameters, BaseFunction>? ELBLoadBalancerLoggingParameters { get; set; }
            /// <summary>
            /// VPCFlowLogParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-telemetryrule-telemetrydestinationconfiguration-vpcflowlogparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VPCFlowLogParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.VPCFlowLogParameters, BaseFunction>? VPCFlowLogParameters { get; set; }
            /// <summary>
            /// CloudtrailParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-telemetryrule-telemetrydestinationconfiguration-cloudtrailparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudtrailParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.CloudtrailParameters, BaseFunction>? CloudtrailParameters { get; set; }
            /// <summary>
            /// WAFLoggingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-telemetryrule-telemetrydestinationconfiguration-wafloggingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WAFLoggingParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.WAFLoggingParameters, BaseFunction>? WAFLoggingParameters { get; set; }
            /// <summary>
            /// LogDeliveryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-telemetryrule-telemetrydestinationconfiguration-logdeliveryparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogDeliveryParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LogDeliveryParameters, BaseFunction>? LogDeliveryParameters { get; set; }
            /// <summary>
            /// DestinationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-telemetryrule-telemetrydestinationconfiguration-destinationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationType { get; set; }
        }

        public class TelemetryRule : Humidifier.Base.BaseSubResource, IHaveStringListOfTelemetrySourceTypes, IHaveObservabilityAdminTelemetryRuleTypesTelemetryDestinationConfigurationDestinationConfiguration, IHaveAllowFieldUpdates_Boolean, IHaveAllRegions_Boolean, IHaveSelectionCriteria, IHaveResourceType, IHaveStringListOfRegions, IHaveTelemetryType
        {
            /// <summary>
            /// TelemetrySourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetryrule.html#cfn-observabilityadmin-telemetryrule-telemetryrule-telemetrysourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TelemetrySourceTypes { get; set; }
            /// <summary>
            /// DestinationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetryrule.html#cfn-observabilityadmin-telemetryrule-telemetryrule-destinationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TelemetryDestinationConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration, BaseFunction>? DestinationConfiguration { get; set; }
            /// <summary>
            /// AllowFieldUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetryrule.html#cfn-observabilityadmin-telemetryrule-telemetryrule-allowfieldupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowFieldUpdates { get; set; }
            /// <summary>
            /// AllRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetryrule.html#cfn-observabilityadmin-telemetryrule-telemetryrule-allregions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllRegions { get; set; }
            /// <summary>
            /// SelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetryrule.html#cfn-observabilityadmin-telemetryrule-telemetryrule-selectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelectionCriteria { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetryrule.html#cfn-observabilityadmin-telemetryrule-telemetryrule-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetryrule.html#cfn-observabilityadmin-telemetryrule-telemetryrule-regions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
            /// <summary>
            /// TelemetryType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-telemetryrule.html#cfn-observabilityadmin-telemetryrule-telemetryrule-telemetrytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TelemetryType { get; set; }
        }

        public class VPCFlowLogParameters : Humidifier.Base.BaseSubResource, IHaveLogFormat, IHaveMaxAggregationInterval_Integer, IHaveTrafficType
        {
            /// <summary>
            /// LogFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-vpcflowlogparameters.html#cfn-observabilityadmin-telemetryrule-vpcflowlogparameters-logformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogFormat { get; set; }
            /// <summary>
            /// MaxAggregationInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-vpcflowlogparameters.html#cfn-observabilityadmin-telemetryrule-vpcflowlogparameters-maxaggregationinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAggregationInterval { get; set; }
            /// <summary>
            /// TrafficType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-vpcflowlogparameters.html#cfn-observabilityadmin-telemetryrule-vpcflowlogparameters-traffictype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrafficType { get; set; }
        }

        public class WAFLoggingParameters : Humidifier.Base.BaseSubResource, IHaveListOfObservabilityAdminTelemetryRuleTypesFieldToMatchRedactedFields, IHaveObservabilityAdminTelemetryRuleTypesLoggingFilterLoggingFilter, IHaveLogType
        {
            /// <summary>
            /// RedactedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-wafloggingparameters.html#cfn-observabilityadmin-telemetryrule-wafloggingparameters-redactedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldToMatch
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.FieldToMatch>, IReadOnlyList<Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.FieldToMatch, BaseFunction>>, BaseFunction>? RedactedFields { get; set; }
            /// <summary>
            /// LoggingFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-wafloggingparameters.html#cfn-observabilityadmin-telemetryrule-wafloggingparameters-loggingfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoggingFilter
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter, BaseFunction>? LoggingFilter { get; set; }
            /// <summary>
            /// LogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-telemetryrule-wafloggingparameters.html#cfn-observabilityadmin-telemetryrule-wafloggingparameters-logtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogType { get; set; }
        }
    }
}