namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using GatewayRuleTypes;

    public class GatewayRule : Humidifier.Base.BaseResource, IHaveDescription, IHaveGatewayIdentifier, IHaveListOfBedrockAgentCoreGatewayRuleTypesActionActions, IHavePriority_Double, IHaveListOfBedrockAgentCoreGatewayRuleTypesConditionConditions
    {
        public class Attributes
        {
            public static string GatewayArn =  "GatewayArn" ;
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string RuleId =  "RuleId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string System =  "System" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.GatewayRule; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayrule.html#cfn-bedrockagentcore-gatewayrule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// GatewayIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayrule.html#cfn-bedrockagentcore-gatewayrule-gatewayidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GatewayIdentifier { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayrule.html#cfn-bedrockagentcore-gatewayrule-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Action
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action, BaseFunction>>, BaseFunction>? Actions { get; set; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayrule.html#cfn-bedrockagentcore-gatewayrule-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// Conditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayrule.html#cfn-bedrockagentcore-gatewayrule-conditions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Condition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
    }

    namespace GatewayRuleTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayRuleTypesRouteToTargetActionRouteToTarget, IHaveBedrockAgentCoreGatewayRuleTypesConfigurationBundleActionConfigurationBundle
        {
            /// <summary>
            /// RouteToTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-action.html#cfn-bedrockagentcore-gatewayrule-action-routetotarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RouteToTargetAction
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction, BaseFunction>? RouteToTarget { get; set; }
            /// <summary>
            /// ConfigurationBundle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-action.html#cfn-bedrockagentcore-gatewayrule-action-configurationbundle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfigurationBundleAction
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction, BaseFunction>? ConfigurationBundle { get; set; }
        }

        public class CircuitBreakerConfiguration : Humidifier.Base.BaseSubResource, IHaveMode_Json
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-circuitbreakerconfiguration.html#cfn-bedrockagentcore-gatewayrule-circuitbreakerconfiguration-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Mode { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayRuleTypesMatchModelsMatchModels, IHaveBedrockAgentCoreGatewayRuleTypesMatchPathsMatchPaths, IHaveBedrockAgentCoreGatewayRuleTypesMatchPrincipalsMatchPrincipals
        {
            /// <summary>
            /// MatchModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-condition.html#cfn-bedrockagentcore-gatewayrule-condition-matchmodels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchModels
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchModels, BaseFunction>? MatchModels { get; set; }
            /// <summary>
            /// MatchPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-condition.html#cfn-bedrockagentcore-gatewayrule-condition-matchpaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchPaths
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths, BaseFunction>? MatchPaths { get; set; }
            /// <summary>
            /// MatchPrincipals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-condition.html#cfn-bedrockagentcore-gatewayrule-condition-matchprincipals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchPrincipals
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals, BaseFunction>? MatchPrincipals { get; set; }
        }

        public class ConfigurationBundleAction : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayRuleTypesStaticOverrideStaticOverride, IHaveBedrockAgentCoreGatewayRuleTypesWeightedOverrideWeightedOverride
        {
            /// <summary>
            /// StaticOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-configurationbundleaction.html#cfn-bedrockagentcore-gatewayrule-configurationbundleaction-staticoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticOverride
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticOverride, BaseFunction>? StaticOverride { get; set; }
            /// <summary>
            /// WeightedOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-configurationbundleaction.html#cfn-bedrockagentcore-gatewayrule-configurationbundleaction-weightedoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WeightedOverride
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedOverride, BaseFunction>? WeightedOverride { get; set; }
        }

        public class ConfigurationBundleReference : Humidifier.Base.BaseSubResource, IHaveBundleVersion, IHaveBundleArn
        {
            /// <summary>
            /// BundleVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-configurationbundlereference.html#cfn-bedrockagentcore-gatewayrule-configurationbundlereference-bundleversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BundleVersion { get; set; }
            /// <summary>
            /// BundleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-configurationbundlereference.html#cfn-bedrockagentcore-gatewayrule-configurationbundlereference-bundlearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BundleArn { get; set; }
        }

        public class Fallback : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayRuleTypesFallbackTriggersTriggerOn, IHaveFirstByteTimeoutMilliseconds_Integer, IHaveBedrockAgentCoreGatewayRuleTypesCircuitBreakerConfigurationCircuitBreaker, IHaveListOfBedrockAgentCoreGatewayRuleTypesFallbackTargetTargetFallback
        {
            /// <summary>
            /// TriggerOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-fallback.html#cfn-bedrockagentcore-gatewayrule-fallback-triggeron
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FallbackTriggers
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers, BaseFunction>? TriggerOn { get; set; }
            /// <summary>
            /// FirstByteTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-fallback.html#cfn-bedrockagentcore-gatewayrule-fallback-firstbytetimeoutmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FirstByteTimeoutMilliseconds { get; set; }
            /// <summary>
            /// CircuitBreaker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-fallback.html#cfn-bedrockagentcore-gatewayrule-fallback-circuitbreaker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CircuitBreakerConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration, BaseFunction>? CircuitBreaker { get; set; }
            /// <summary>
            /// TargetFallback
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-fallback.html#cfn-bedrockagentcore-gatewayrule-fallback-targetfallback
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FallbackTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTarget>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTarget, BaseFunction>>, BaseFunction>? TargetFallback { get; set; }
        }

        public class FallbackTarget : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayRuleTypesFallbackTriggersTriggerOn, IHaveFirstByteTimeoutMilliseconds_Integer, IHaveModel, IHaveTargetName
        {
            /// <summary>
            /// TriggerOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-fallbacktarget.html#cfn-bedrockagentcore-gatewayrule-fallbacktarget-triggeron
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FallbackTriggers
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers, BaseFunction>? TriggerOn { get; set; }
            /// <summary>
            /// FirstByteTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-fallbacktarget.html#cfn-bedrockagentcore-gatewayrule-fallbacktarget-firstbytetimeoutmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FirstByteTimeoutMilliseconds { get; set; }
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-fallbacktarget.html#cfn-bedrockagentcore-gatewayrule-fallbacktarget-model
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Model { get; set; }
            /// <summary>
            /// TargetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-fallbacktarget.html#cfn-bedrockagentcore-gatewayrule-fallbacktarget-targetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetName { get; set; }
        }

        public class FallbackTriggers : Humidifier.Base.BaseSubResource, IHaveStringListOfErrors, IHaveStringListOfStatusCodes
        {
            /// <summary>
            /// Errors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-fallbacktriggers.html#cfn-bedrockagentcore-gatewayrule-fallbacktriggers-errors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Errors { get; set; }
            /// <summary>
            /// StatusCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-fallbacktriggers.html#cfn-bedrockagentcore-gatewayrule-fallbacktriggers-statuscodes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StatusCodes { get; set; }
        }

        public class IamPrincipal : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveArn
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-iamprincipal.html#cfn-bedrockagentcore-gatewayrule-iamprincipal-operator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-iamprincipal.html#cfn-bedrockagentcore-gatewayrule-iamprincipal-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class MatchModelEntry : Humidifier.Base.BaseSubResource, IHaveOperator_Json, IHaveValue
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-matchmodelentry.html#cfn-bedrockagentcore-gatewayrule-matchmodelentry-operator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-matchmodelentry.html#cfn-bedrockagentcore-gatewayrule-matchmodelentry-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class MatchModels : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreGatewayRuleTypesMatchModelEntryAnyOf
        {
            /// <summary>
            /// AnyOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-matchmodels.html#cfn-bedrockagentcore-gatewayrule-matchmodels-anyof
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MatchModelEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchModelEntry>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchModelEntry, BaseFunction>>, BaseFunction>? AnyOf { get; set; }
        }

        public class MatchPaths : Humidifier.Base.BaseSubResource, IHaveStringListOfAnyOf
        {
            /// <summary>
            /// AnyOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-matchpaths.html#cfn-bedrockagentcore-gatewayrule-matchpaths-anyof
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AnyOf { get; set; }
        }

        public class MatchPrincipalEntry : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayRuleTypesIamPrincipalIamPrincipal
        {
            /// <summary>
            /// IamPrincipal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-matchprincipalentry.html#cfn-bedrockagentcore-gatewayrule-matchprincipalentry-iamprincipal
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IamPrincipal
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.IamPrincipal, BaseFunction>? IamPrincipal { get; set; }
        }

        public class MatchPrincipals : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreGatewayRuleTypesMatchPrincipalEntryAnyOf
        {
            /// <summary>
            /// AnyOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-matchprincipals.html#cfn-bedrockagentcore-gatewayrule-matchprincipals-anyof
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MatchPrincipalEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipalEntry>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipalEntry, BaseFunction>>, BaseFunction>? AnyOf { get; set; }
        }

        public class RouteToTargetAction : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayRuleTypesStaticRouteStaticRoute, IHaveBedrockAgentCoreGatewayRuleTypesWeightedRouteWeightedRoute
        {
            /// <summary>
            /// StaticRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-routetotargetaction.html#cfn-bedrockagentcore-gatewayrule-routetotargetaction-staticroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticRoute
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute, BaseFunction>? StaticRoute { get; set; }
            /// <summary>
            /// WeightedRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-routetotargetaction.html#cfn-bedrockagentcore-gatewayrule-routetotargetaction-weightedroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WeightedRoute
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute, BaseFunction>? WeightedRoute { get; set; }
        }

        public class StaticOverride : Humidifier.Base.BaseSubResource, IHaveBundleVersion, IHaveBundleArn
        {
            /// <summary>
            /// BundleVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-staticoverride.html#cfn-bedrockagentcore-gatewayrule-staticoverride-bundleversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BundleVersion { get; set; }
            /// <summary>
            /// BundleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-staticoverride.html#cfn-bedrockagentcore-gatewayrule-staticoverride-bundlearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BundleArn { get; set; }
        }

        public class StaticRoute : Humidifier.Base.BaseSubResource, IHaveModel, IHaveBedrockAgentCoreGatewayRuleTypesFallbackFallback, IHaveTargetName
        {
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-staticroute.html#cfn-bedrockagentcore-gatewayrule-staticroute-model
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Model { get; set; }
            /// <summary>
            /// Fallback
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-staticroute.html#cfn-bedrockagentcore-gatewayrule-staticroute-fallback
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Fallback
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback, BaseFunction>? Fallback { get; set; }
            /// <summary>
            /// TargetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-staticroute.html#cfn-bedrockagentcore-gatewayrule-staticroute-targetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetName { get; set; }
        }

        public class SystemManagedBlock : Humidifier.Base.BaseSubResource, IHaveManagedBy
        {
            /// <summary>
            /// ManagedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-systemmanagedblock.html#cfn-bedrockagentcore-gatewayrule-systemmanagedblock-managedby
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagedBy { get; set; }
        }

        public class TargetTrafficSplitEntry : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveModel, IHaveBedrockAgentCoreGatewayRuleTypesFallbackFallback, IHaveStringDictionaryOfMetadata, IHaveTargetName, IHaveWeight_Double, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-model
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Model { get; set; }
            /// <summary>
            /// Fallback
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-fallback
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Fallback
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback, BaseFunction>? Fallback { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Metadata { get; set; }
            /// <summary>
            /// TargetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-targetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetName { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TrafficSplitEntry : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveStringDictionaryOfMetadata, IHaveBedrockAgentCoreGatewayRuleTypesConfigurationBundleReferenceConfigurationBundle, IHaveWeight_Double, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-trafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-trafficsplitentry-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-trafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-trafficsplitentry-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Metadata { get; set; }
            /// <summary>
            /// ConfigurationBundle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-trafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-trafficsplitentry-configurationbundle
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConfigurationBundleReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleReference, BaseFunction>? ConfigurationBundle { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-trafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-trafficsplitentry-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-trafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-trafficsplitentry-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class WeightedOverride : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreGatewayRuleTypesTrafficSplitEntryTrafficSplit
        {
            /// <summary>
            /// TrafficSplit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-weightedoverride.html#cfn-bedrockagentcore-gatewayrule-weightedoverride-trafficsplit
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TrafficSplitEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayRuleTypes.TrafficSplitEntry>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.TrafficSplitEntry, BaseFunction>>, BaseFunction>? TrafficSplit { get; set; }
        }

        public class WeightedRoute : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreGatewayRuleTypesTargetTrafficSplitEntryTrafficSplit
        {
            /// <summary>
            /// TrafficSplit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-weightedroute.html#cfn-bedrockagentcore-gatewayrule-weightedroute-trafficsplit
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetTrafficSplitEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayRuleTypes.TargetTrafficSplitEntry>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayRuleTypes.TargetTrafficSplitEntry, BaseFunction>>, BaseFunction>? TrafficSplit { get; set; }
        }
    }
}