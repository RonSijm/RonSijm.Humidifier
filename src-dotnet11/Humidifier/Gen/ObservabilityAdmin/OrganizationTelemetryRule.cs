namespace Humidifier.ObservabilityAdmin
{
    using global::System.Collections.Generic;
    using OrganizationTelemetryRuleTypes;

    public class OrganizationTelemetryRule : Humidifier.Base.BaseResource, IHaveTags, IHaveObservabilityAdminOrganizationTelemetryRuleTypesTelemetryRuleRule, IHaveRuleName
    {
        public class Attributes
        {
            public static string RegionStatuses =  "RegionStatuses" ;
            public static string RuleArn =  "RuleArn" ;
        }

        public override string AWSTypeName { get => AWS.ObservabilityAdmin.OrganizationTelemetryRule; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-organizationtelemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TelemetryRule
        /// </summary>
        [Required]
        public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule, BaseFunction>? Rule { get; set; }

        /// <summary>
        /// RuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-organizationtelemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-rulename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-organizationtelemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace OrganizationTelemetryRuleTypes
    {
        public class ActionCondition : Humidifier.Base.BaseSubResource, IHaveAction
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-actioncondition.html#cfn-observabilityadmin-organizationtelemetryrule-actioncondition-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
        }

        public class AdvancedEventSelector : Humidifier.Base.BaseSubResource, IHaveListOfObservabilityAdminOrganizationTelemetryRuleTypesAdvancedFieldSelectorFieldSelectors, IHaveName
        {
            /// <summary>
            /// FieldSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-advancedeventselector.html#cfn-observabilityadmin-organizationtelemetryrule-advancedeventselector-fieldselectors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdvancedFieldSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.AdvancedFieldSelector>, IReadOnlyList<Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.AdvancedFieldSelector, BaseFunction>>, BaseFunction>? FieldSelectors { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-advancedeventselector.html#cfn-observabilityadmin-organizationtelemetryrule-advancedeventselector-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-advancedfieldselector.html#cfn-observabilityadmin-organizationtelemetryrule-advancedfieldselector-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Equals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-advancedfieldselector.html#cfn-observabilityadmin-organizationtelemetryrule-advancedfieldselector-equals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Equals { get; set; }
            /// <summary>
            /// NotStartsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-advancedfieldselector.html#cfn-observabilityadmin-organizationtelemetryrule-advancedfieldselector-notstartswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotStartsWith { get; set; }
            /// <summary>
            /// NotEndsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-advancedfieldselector.html#cfn-observabilityadmin-organizationtelemetryrule-advancedfieldselector-notendswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotEndsWith { get; set; }
            /// <summary>
            /// StartsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-advancedfieldselector.html#cfn-observabilityadmin-organizationtelemetryrule-advancedfieldselector-startswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StartsWith { get; set; }
            /// <summary>
            /// EndsWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-advancedfieldselector.html#cfn-observabilityadmin-organizationtelemetryrule-advancedfieldselector-endswith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EndsWith { get; set; }
            /// <summary>
            /// NotEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-advancedfieldselector.html#cfn-observabilityadmin-organizationtelemetryrule-advancedfieldselector-notequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotEquals { get; set; }
        }

        public class CloudtrailParameters : Humidifier.Base.BaseSubResource, IHaveListOfObservabilityAdminOrganizationTelemetryRuleTypesAdvancedEventSelectorAdvancedEventSelectors
        {
            /// <summary>
            /// AdvancedEventSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-cloudtrailparameters.html#cfn-observabilityadmin-organizationtelemetryrule-cloudtrailparameters-advancedeventselectors
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdvancedEventSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.AdvancedEventSelector>, IReadOnlyList<Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.AdvancedEventSelector, BaseFunction>>, BaseFunction>? AdvancedEventSelectors { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource, IHaveObservabilityAdminOrganizationTelemetryRuleTypesLabelNameConditionLabelNameCondition, IHaveObservabilityAdminOrganizationTelemetryRuleTypesActionConditionActionCondition
        {
            /// <summary>
            /// LabelNameCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-condition.html#cfn-observabilityadmin-organizationtelemetryrule-condition-labelnamecondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LabelNameCondition
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LabelNameCondition, BaseFunction>? LabelNameCondition { get; set; }
            /// <summary>
            /// ActionCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-condition.html#cfn-observabilityadmin-organizationtelemetryrule-condition-actioncondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActionCondition
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.ActionCondition, BaseFunction>? ActionCondition { get; set; }
        }

        public class ELBLoadBalancerLoggingParameters : Humidifier.Base.BaseSubResource, IHaveFieldDelimiter, IHaveOutputFormat
        {
            /// <summary>
            /// FieldDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-elbloadbalancerloggingparameters.html#cfn-observabilityadmin-organizationtelemetryrule-elbloadbalancerloggingparameters-fielddelimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldDelimiter { get; set; }
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-elbloadbalancerloggingparameters.html#cfn-observabilityadmin-organizationtelemetryrule-elbloadbalancerloggingparameters-outputformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputFormat { get; set; }
        }

        public class FieldToMatch : Humidifier.Base.BaseSubResource, IHaveUriPath, IHaveQueryString, IHaveMethod, IHaveObservabilityAdminOrganizationTelemetryRuleTypesSingleHeaderSingleHeader
        {
            /// <summary>
            /// UriPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-fieldtomatch.html#cfn-observabilityadmin-organizationtelemetryrule-fieldtomatch-uripath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UriPath { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-fieldtomatch.html#cfn-observabilityadmin-organizationtelemetryrule-fieldtomatch-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-fieldtomatch.html#cfn-observabilityadmin-organizationtelemetryrule-fieldtomatch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Method { get; set; }
            /// <summary>
            /// SingleHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-fieldtomatch.html#cfn-observabilityadmin-organizationtelemetryrule-fieldtomatch-singleheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingleHeader
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.SingleHeader, BaseFunction>? SingleHeader { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveRequirement, IHaveBehavior, IHaveListOfObservabilityAdminOrganizationTelemetryRuleTypesConditionConditions
        {
            /// <summary>
            /// Requirement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-filter.html#cfn-observabilityadmin-organizationtelemetryrule-filter-requirement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Requirement { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-filter.html#cfn-observabilityadmin-organizationtelemetryrule-filter-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Behavior { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-filter.html#cfn-observabilityadmin-organizationtelemetryrule-filter-conditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Condition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.Condition>, IReadOnlyList<Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.Condition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }

        public class LabelNameCondition : Humidifier.Base.BaseSubResource, IHaveLabelName
        {
            /// <summary>
            /// LabelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-labelnamecondition.html#cfn-observabilityadmin-organizationtelemetryrule-labelnamecondition-labelname
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-logdeliveryparameters.html#cfn-observabilityadmin-organizationtelemetryrule-logdeliveryparameters-logtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogTypes { get; set; }
        }

        public class LoggingFilter : Humidifier.Base.BaseSubResource, IHaveListOfObservabilityAdminOrganizationTelemetryRuleTypesFilterFilters, IHaveDefaultBehavior
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-loggingfilter.html#cfn-observabilityadmin-organizationtelemetryrule-loggingfilter-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.Filter>, IReadOnlyList<Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.Filter, BaseFunction>>, BaseFunction>? Filters { get; set; }
            /// <summary>
            /// DefaultBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-loggingfilter.html#cfn-observabilityadmin-organizationtelemetryrule-loggingfilter-defaultbehavior
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-mskmonitoringparameters.html#cfn-observabilityadmin-organizationtelemetryrule-mskmonitoringparameters-enhancedmonitoring
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-regionstatus.html#cfn-observabilityadmin-organizationtelemetryrule-regionstatus-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// RuleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-regionstatus.html#cfn-observabilityadmin-organizationtelemetryrule-regionstatus-rulearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleArn { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-regionstatus.html#cfn-observabilityadmin-organizationtelemetryrule-regionstatus-region
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-singleheader.html#cfn-observabilityadmin-organizationtelemetryrule-singleheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TelemetryDestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveRetentionInDays_Integer, IHaveObservabilityAdminOrganizationTelemetryRuleTypesMskMonitoringParametersMskMonitoringParameters, IHaveKmsKeyArn, IHaveDestinationPattern, IHaveObservabilityAdminOrganizationTelemetryRuleTypesELBLoadBalancerLoggingParametersELBLoadBalancerLoggingParameters, IHaveObservabilityAdminOrganizationTelemetryRuleTypesVPCFlowLogParametersVPCFlowLogParameters, IHaveObservabilityAdminOrganizationTelemetryRuleTypesCloudtrailParametersCloudtrailParameters, IHaveObservabilityAdminOrganizationTelemetryRuleTypesWAFLoggingParametersWAFLoggingParameters, IHaveObservabilityAdminOrganizationTelemetryRuleTypesLogDeliveryParametersLogDeliveryParameters, IHaveDestinationType
        {
            /// <summary>
            /// RetentionInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration-retentionindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetentionInDays { get; set; }
            /// <summary>
            /// MskMonitoringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration-mskmonitoringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MskMonitoringParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.MskMonitoringParameters, BaseFunction>? MskMonitoringParameters { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// DestinationPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration-destinationpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPattern { get; set; }
            /// <summary>
            /// ELBLoadBalancerLoggingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration-elbloadbalancerloggingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ELBLoadBalancerLoggingParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.ELBLoadBalancerLoggingParameters, BaseFunction>? ELBLoadBalancerLoggingParameters { get; set; }
            /// <summary>
            /// VPCFlowLogParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration-vpcflowlogparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VPCFlowLogParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.VPCFlowLogParameters, BaseFunction>? VPCFlowLogParameters { get; set; }
            /// <summary>
            /// CloudtrailParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration-cloudtrailparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudtrailParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.CloudtrailParameters, BaseFunction>? CloudtrailParameters { get; set; }
            /// <summary>
            /// WAFLoggingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration-wafloggingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WAFLoggingParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.WAFLoggingParameters, BaseFunction>? WAFLoggingParameters { get; set; }
            /// <summary>
            /// LogDeliveryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration-logdeliveryparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogDeliveryParameters
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LogDeliveryParameters, BaseFunction>? LogDeliveryParameters { get; set; }
            /// <summary>
            /// DestinationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration.html#cfn-observabilityadmin-organizationtelemetryrule-telemetrydestinationconfiguration-destinationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationType { get; set; }
        }

        public class TelemetryRule : Humidifier.Base.BaseSubResource, IHaveStringListOfTelemetrySourceTypes, IHaveObservabilityAdminOrganizationTelemetryRuleTypesTelemetryDestinationConfigurationDestinationConfiguration, IHaveScope, IHaveAllowFieldUpdates_Boolean, IHaveAllRegions_Boolean, IHaveSelectionCriteria, IHaveResourceType, IHaveStringListOfRegions, IHaveTelemetryType
        {
            /// <summary>
            /// TelemetrySourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-telemetryrule-telemetrysourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TelemetrySourceTypes { get; set; }
            /// <summary>
            /// DestinationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-telemetryrule-destinationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TelemetryDestinationConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration, BaseFunction>? DestinationConfiguration { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-telemetryrule-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// AllowFieldUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-telemetryrule-allowfieldupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowFieldUpdates { get; set; }
            /// <summary>
            /// AllRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-telemetryrule-allregions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllRegions { get; set; }
            /// <summary>
            /// SelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-telemetryrule-selectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelectionCriteria { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-telemetryrule-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-telemetryrule-regions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
            /// <summary>
            /// TelemetryType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-telemetryrule.html#cfn-observabilityadmin-organizationtelemetryrule-telemetryrule-telemetrytype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-vpcflowlogparameters.html#cfn-observabilityadmin-organizationtelemetryrule-vpcflowlogparameters-logformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogFormat { get; set; }
            /// <summary>
            /// MaxAggregationInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-vpcflowlogparameters.html#cfn-observabilityadmin-organizationtelemetryrule-vpcflowlogparameters-maxaggregationinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAggregationInterval { get; set; }
            /// <summary>
            /// TrafficType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-vpcflowlogparameters.html#cfn-observabilityadmin-organizationtelemetryrule-vpcflowlogparameters-traffictype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrafficType { get; set; }
        }

        public class WAFLoggingParameters : Humidifier.Base.BaseSubResource, IHaveListOfObservabilityAdminOrganizationTelemetryRuleTypesFieldToMatchRedactedFields, IHaveObservabilityAdminOrganizationTelemetryRuleTypesLoggingFilterLoggingFilter, IHaveLogType
        {
            /// <summary>
            /// RedactedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-wafloggingparameters.html#cfn-observabilityadmin-organizationtelemetryrule-wafloggingparameters-redactedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldToMatch
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.FieldToMatch>, IReadOnlyList<Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.FieldToMatch, BaseFunction>>, BaseFunction>? RedactedFields { get; set; }
            /// <summary>
            /// LoggingFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-wafloggingparameters.html#cfn-observabilityadmin-organizationtelemetryrule-wafloggingparameters-loggingfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoggingFilter
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter, BaseFunction>? LoggingFilter { get; set; }
            /// <summary>
            /// LogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationtelemetryrule-wafloggingparameters.html#cfn-observabilityadmin-organizationtelemetryrule-wafloggingparameters-logtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogType { get; set; }
        }
    }
}