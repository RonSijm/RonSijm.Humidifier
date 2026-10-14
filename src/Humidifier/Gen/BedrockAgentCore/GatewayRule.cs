namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using GatewayRuleTypes;

    public class GatewayRule : Humidifier.Base.BaseResource, IHaveDescription, IHavePriority
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
        public dynamic Description { get; set; }
        /// <summary>
        /// GatewayIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayrule.html#cfn-bedrockagentcore-gatewayrule-gatewayidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GatewayIdentifier { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayrule.html#cfn-bedrockagentcore-gatewayrule-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Action
        /// </summary>
        [Required]
        public List<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> Actions { get; set; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayrule.html#cfn-bedrockagentcore-gatewayrule-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public dynamic Priority { get; set; }
        /// <summary>
        /// Conditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewayrule.html#cfn-bedrockagentcore-gatewayrule-conditions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Condition
        /// </summary>
        public List<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> Conditions { get; set; }
    }

    namespace GatewayRuleTypes
    {
        public class Action : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RouteToTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-action.html#cfn-bedrockagentcore-gatewayrule-action-routetotarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RouteToTargetAction
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction RouteToTarget { get; set; }
            /// <summary>
            /// ConfigurationBundle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-action.html#cfn-bedrockagentcore-gatewayrule-action-configurationbundle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfigurationBundleAction
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction ConfigurationBundle { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MatchPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-condition.html#cfn-bedrockagentcore-gatewayrule-condition-matchpaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchPaths
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths MatchPaths { get; set; }
            /// <summary>
            /// MatchPrincipals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-condition.html#cfn-bedrockagentcore-gatewayrule-condition-matchprincipals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchPrincipals
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals MatchPrincipals { get; set; }
        }

        public class ConfigurationBundleAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-configurationbundleaction.html#cfn-bedrockagentcore-gatewayrule-configurationbundleaction-staticoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticOverride
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticOverride StaticOverride { get; set; }
            /// <summary>
            /// WeightedOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-configurationbundleaction.html#cfn-bedrockagentcore-gatewayrule-configurationbundleaction-weightedoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WeightedOverride
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedOverride WeightedOverride { get; set; }
        }

        public class ConfigurationBundleReference : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BundleVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-configurationbundlereference.html#cfn-bedrockagentcore-gatewayrule-configurationbundlereference-bundleversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BundleVersion { get; set; }
            /// <summary>
            /// BundleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-configurationbundlereference.html#cfn-bedrockagentcore-gatewayrule-configurationbundlereference-bundlearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BundleArn { get; set; }
        }

        public class IamPrincipal : Humidifier.Base.BaseSubResource, IHaveArn, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-iamprincipal.html#cfn-bedrockagentcore-gatewayrule-iamprincipal-operator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-iamprincipal.html#cfn-bedrockagentcore-gatewayrule-iamprincipal-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class MatchPaths : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AnyOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-matchpaths.html#cfn-bedrockagentcore-gatewayrule-matchpaths-anyof
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AnyOf { get; set; }
        }

        public class MatchPrincipalEntry : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IamPrincipal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-matchprincipalentry.html#cfn-bedrockagentcore-gatewayrule-matchprincipalentry-iamprincipal
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IamPrincipal
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayRuleTypes.IamPrincipal IamPrincipal { get; set; }
        }

        public class MatchPrincipals : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AnyOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-matchprincipals.html#cfn-bedrockagentcore-gatewayrule-matchprincipals-anyof
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MatchPrincipalEntry
            /// </summary>
            public List<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipalEntry> AnyOf { get; set; }
        }

        public class RouteToTargetAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-routetotargetaction.html#cfn-bedrockagentcore-gatewayrule-routetotargetaction-staticroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticRoute
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute StaticRoute { get; set; }
            /// <summary>
            /// WeightedRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-routetotargetaction.html#cfn-bedrockagentcore-gatewayrule-routetotargetaction-weightedroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WeightedRoute
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute WeightedRoute { get; set; }
        }

        public class StaticOverride : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BundleVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-staticoverride.html#cfn-bedrockagentcore-gatewayrule-staticoverride-bundleversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BundleVersion { get; set; }
            /// <summary>
            /// BundleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-staticoverride.html#cfn-bedrockagentcore-gatewayrule-staticoverride-bundlearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BundleArn { get; set; }
        }

        public class StaticRoute : Humidifier.Base.BaseSubResource, IHaveTargetName
        {
            /// <summary>
            /// TargetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-staticroute.html#cfn-bedrockagentcore-gatewayrule-staticroute-targetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetName { get; set; }
        }

        public class SystemManagedBlock : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ManagedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-systemmanagedblock.html#cfn-bedrockagentcore-gatewayrule-systemmanagedblock-managedby
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManagedBy { get; set; }
        }

        public class TargetTrafficSplitEntry : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveWeight, IHaveTargetName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Metadata { get; set; }
            /// <summary>
            /// TargetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-targetname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetName { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Weight { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-targettrafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-targettrafficsplitentry-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TrafficSplitEntry : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveWeight
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-trafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-trafficsplitentry-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-trafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-trafficsplitentry-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Metadata { get; set; }
            /// <summary>
            /// ConfigurationBundle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-trafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-trafficsplitentry-configurationbundle
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConfigurationBundleReference
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleReference ConfigurationBundle { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-trafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-trafficsplitentry-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Weight { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-trafficsplitentry.html#cfn-bedrockagentcore-gatewayrule-trafficsplitentry-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class WeightedOverride : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrafficSplit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-weightedoverride.html#cfn-bedrockagentcore-gatewayrule-weightedoverride-trafficsplit
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TrafficSplitEntry
            /// </summary>
            public List<Humidifier.BedrockAgentCore.GatewayRuleTypes.TrafficSplitEntry> TrafficSplit { get; set; }
        }

        public class WeightedRoute : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrafficSplit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewayrule-weightedroute.html#cfn-bedrockagentcore-gatewayrule-weightedroute-trafficsplit
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetTrafficSplitEntry
            /// </summary>
            public List<Humidifier.BedrockAgentCore.GatewayRuleTypes.TargetTrafficSplitEntry> TrafficSplit { get; set; }
        }
    }
}