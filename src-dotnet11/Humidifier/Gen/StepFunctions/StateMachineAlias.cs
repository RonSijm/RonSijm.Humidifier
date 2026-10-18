namespace Humidifier.StepFunctions
{
    using global::System.Collections.Generic;
    using StateMachineAliasTypes;

    public class StateMachineAlias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveListOfStepFunctionsStateMachineAliasTypesRoutingConfigurationVersionRoutingConfiguration, IHaveStateMachineArn, IHaveStepFunctionsStateMachineAliasTypesDeploymentPreferenceDeploymentPreference, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.StepFunctions.StateMachineAlias; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachinealias.html#cfn-stepfunctions-statemachinealias-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// RoutingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachinealias.html#cfn-stepfunctions-statemachinealias-routingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RoutingConfigurationVersion
        /// </summary>
        public Union<IReadOnlyList<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion>, IReadOnlyList<Union<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion, BaseFunction>>, BaseFunction>? RoutingConfiguration { get; set; }
        /// <summary>
        /// StateMachineArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachinealias.html#cfn-stepfunctions-statemachinealias-statemachinearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StateMachineArn { get; set; }
        /// <summary>
        /// DeploymentPreference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachinealias.html#cfn-stepfunctions-statemachinealias-deploymentpreference
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeploymentPreference
        /// </summary>
        public Union<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference, BaseFunction>? DeploymentPreference { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace StateMachineAliasTypes
    {
        public class DeploymentPreference : Humidifier.Base.BaseSubResource, IHaveType, IHaveStateMachineVersionArn, IHavePercentage_Integer, IHaveStringListOfAlarms, IHaveInterval_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachinealias-deploymentpreference.html#cfn-stepfunctions-statemachinealias-deploymentpreference-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// StateMachineVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachinealias-deploymentpreference.html#cfn-stepfunctions-statemachinealias-deploymentpreference-statemachineversionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StateMachineVersionArn { get; set; }
            /// <summary>
            /// Percentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachinealias-deploymentpreference.html#cfn-stepfunctions-statemachinealias-deploymentpreference-percentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Percentage { get; set; }
            /// <summary>
            /// Alarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachinealias-deploymentpreference.html#cfn-stepfunctions-statemachinealias-deploymentpreference-alarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Alarms { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachinealias-deploymentpreference.html#cfn-stepfunctions-statemachinealias-deploymentpreference-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
        }

        public class RoutingConfigurationVersion : Humidifier.Base.BaseSubResource, IHaveStateMachineVersionArn, IHaveWeight_Integer
        {
            /// <summary>
            /// StateMachineVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachinealias-routingconfigurationversion.html#cfn-stepfunctions-statemachinealias-routingconfigurationversion-statemachineversionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StateMachineVersionArn { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachinealias-routingconfigurationversion.html#cfn-stepfunctions-statemachinealias-routingconfigurationversion-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
        }
    }
}