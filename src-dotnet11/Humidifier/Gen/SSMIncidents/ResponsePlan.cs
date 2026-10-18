namespace Humidifier.SSMIncidents
{
    using global::System.Collections.Generic;
    using ResponsePlanTypes;

    public class ResponsePlan : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSSMIncidentsResponsePlanTypesChatChannelChatChannel, IHaveListOfSSMIncidentsResponsePlanTypesIntegrationIntegrations, IHaveListOfSSMIncidentsResponsePlanTypesActionActions, IHaveDisplayName, IHaveSSMIncidentsResponsePlanTypesIncidentTemplateIncidentTemplate, IHaveStringListOfEngagements, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SSMIncidents.ResponsePlan; }
        /// <summary>
        /// ChatChannel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-responseplan.html#cfn-ssmincidents-responseplan-chatchannel
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ChatChannel
        /// </summary>
        public Union<Humidifier.SSMIncidents.ResponsePlanTypes.ChatChannel, BaseFunction>? ChatChannel { get; set; }
        /// <summary>
        /// Integrations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-responseplan.html#cfn-ssmincidents-responseplan-integrations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Integration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSMIncidents.ResponsePlanTypes.Integration>, IReadOnlyList<Union<Humidifier.SSMIncidents.ResponsePlanTypes.Integration, BaseFunction>>, BaseFunction>? Integrations { get; set; }
        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-responseplan.html#cfn-ssmincidents-responseplan-actions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Action
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSMIncidents.ResponsePlanTypes.Action>, IReadOnlyList<Union<Humidifier.SSMIncidents.ResponsePlanTypes.Action, BaseFunction>>, BaseFunction>? Actions { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-responseplan.html#cfn-ssmincidents-responseplan-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// IncidentTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-responseplan.html#cfn-ssmincidents-responseplan-incidenttemplate
        /// Required: True
        /// UpdateType: Mutable
        /// Type: IncidentTemplate
        /// </summary>
        [Required]
        public Union<Humidifier.SSMIncidents.ResponsePlanTypes.IncidentTemplate, BaseFunction>? IncidentTemplate { get; set; }
        /// <summary>
        /// Engagements
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-responseplan.html#cfn-ssmincidents-responseplan-engagements
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Engagements { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-responseplan.html#cfn-ssmincidents-responseplan-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ResponsePlanTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveSSMIncidentsResponsePlanTypesSsmAutomationSsmAutomation
        {
            /// <summary>
            /// SsmAutomation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-action.html#cfn-ssmincidents-responseplan-action-ssmautomation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SsmAutomation
            /// </summary>
            public Union<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation, BaseFunction>? SsmAutomation { get; set; }
        }

        public class ChatChannel : Humidifier.Base.BaseSubResource, IHaveStringListOfChatbotSns
        {
            /// <summary>
            /// ChatbotSns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-chatchannel.html#cfn-ssmincidents-responseplan-chatchannel-chatbotsns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ChatbotSns { get; set; }
        }

        public class DynamicSsmParameter : Humidifier.Base.BaseSubResource, IHaveSSMIncidentsResponsePlanTypesDynamicSsmParameterValueValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-dynamicssmparameter.html#cfn-ssmincidents-responseplan-dynamicssmparameter-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DynamicSsmParameterValue
            /// </summary>
            public Union<Humidifier.SSMIncidents.ResponsePlanTypes.DynamicSsmParameterValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-dynamicssmparameter.html#cfn-ssmincidents-responseplan-dynamicssmparameter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class DynamicSsmParameterValue : Humidifier.Base.BaseSubResource, IHaveVariable
        {
            /// <summary>
            /// Variable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-dynamicssmparametervalue.html#cfn-ssmincidents-responseplan-dynamicssmparametervalue-variable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Variable { get; set; }
        }

        public class IncidentTemplate : Humidifier.Base.BaseSubResource, IHaveImpact_Integer, IHaveTagListOfIncidentTags, IHaveSummary, IHaveTitle, IHaveListOfSSMIncidentsResponsePlanTypesNotificationTargetItemNotificationTargets, IHaveDedupeString
        {
            /// <summary>
            /// Impact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-incidenttemplate.html#cfn-ssmincidents-responseplan-incidenttemplate-impact
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Impact { get; set; }
            /// <summary>
            /// IncidentTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-incidenttemplate.html#cfn-ssmincidents-responseplan-incidenttemplate-incidenttags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? IncidentTags { get; set; }
            /// <summary>
            /// Summary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-incidenttemplate.html#cfn-ssmincidents-responseplan-incidenttemplate-summary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Summary { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-incidenttemplate.html#cfn-ssmincidents-responseplan-incidenttemplate-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// NotificationTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-incidenttemplate.html#cfn-ssmincidents-responseplan-incidenttemplate-notificationtargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NotificationTargetItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSMIncidents.ResponsePlanTypes.NotificationTargetItem>, IReadOnlyList<Union<Humidifier.SSMIncidents.ResponsePlanTypes.NotificationTargetItem, BaseFunction>>, BaseFunction>? NotificationTargets { get; set; }
            /// <summary>
            /// DedupeString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-incidenttemplate.html#cfn-ssmincidents-responseplan-incidenttemplate-dedupestring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DedupeString { get; set; }
        }

        public class Integration : Humidifier.Base.BaseSubResource, IHaveSSMIncidentsResponsePlanTypesPagerDutyConfigurationPagerDutyConfiguration
        {
            /// <summary>
            /// PagerDutyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-integration.html#cfn-ssmincidents-responseplan-integration-pagerdutyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PagerDutyConfiguration
            /// </summary>
            public Union<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyConfiguration, BaseFunction>? PagerDutyConfiguration { get; set; }
        }

        public class NotificationTargetItem : Humidifier.Base.BaseSubResource, IHaveSnsTopicArn
        {
            /// <summary>
            /// SnsTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-notificationtargetitem.html#cfn-ssmincidents-responseplan-notificationtargetitem-snstopicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnsTopicArn { get; set; }
        }

        public class PagerDutyConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretId, IHaveSSMIncidentsResponsePlanTypesPagerDutyIncidentConfigurationPagerDutyIncidentConfiguration, IHaveName
        {
            /// <summary>
            /// SecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-pagerdutyconfiguration.html#cfn-ssmincidents-responseplan-pagerdutyconfiguration-secretid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretId { get; set; }
            /// <summary>
            /// PagerDutyIncidentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-pagerdutyconfiguration.html#cfn-ssmincidents-responseplan-pagerdutyconfiguration-pagerdutyincidentconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PagerDutyIncidentConfiguration
            /// </summary>
            public Union<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration, BaseFunction>? PagerDutyIncidentConfiguration { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-pagerdutyconfiguration.html#cfn-ssmincidents-responseplan-pagerdutyconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PagerDutyIncidentConfiguration : Humidifier.Base.BaseSubResource, IHaveServiceId
        {
            /// <summary>
            /// ServiceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-pagerdutyincidentconfiguration.html#cfn-ssmincidents-responseplan-pagerdutyincidentconfiguration-serviceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceId { get; set; }
        }

        public class SsmAutomation : Humidifier.Base.BaseSubResource, IHaveListOfSSMIncidentsResponsePlanTypesSsmParameterParameters, IHaveTargetAccount, IHaveListOfSSMIncidentsResponsePlanTypesDynamicSsmParameterDynamicParameters, IHaveDocumentVersion, IHaveRoleArn, IHaveDocumentName
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-ssmautomation.html#cfn-ssmincidents-responseplan-ssmautomation-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SsmParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSMIncidents.ResponsePlanTypes.SsmParameter>, IReadOnlyList<Union<Humidifier.SSMIncidents.ResponsePlanTypes.SsmParameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// TargetAccount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-ssmautomation.html#cfn-ssmincidents-responseplan-ssmautomation-targetaccount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetAccount { get; set; }
            /// <summary>
            /// DynamicParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-ssmautomation.html#cfn-ssmincidents-responseplan-ssmautomation-dynamicparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DynamicSsmParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSMIncidents.ResponsePlanTypes.DynamicSsmParameter>, IReadOnlyList<Union<Humidifier.SSMIncidents.ResponsePlanTypes.DynamicSsmParameter, BaseFunction>>, BaseFunction>? DynamicParameters { get; set; }
            /// <summary>
            /// DocumentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-ssmautomation.html#cfn-ssmincidents-responseplan-ssmautomation-documentversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentVersion { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-ssmautomation.html#cfn-ssmincidents-responseplan-ssmautomation-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// DocumentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-ssmautomation.html#cfn-ssmincidents-responseplan-ssmautomation-documentname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentName { get; set; }
        }

        public class SsmParameter : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-ssmparameter.html#cfn-ssmincidents-responseplan-ssmparameter-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-ssmparameter.html#cfn-ssmincidents-responseplan-ssmparameter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}