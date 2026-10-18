namespace Humidifier.Budgets
{
    using global::System.Collections.Generic;
    using BudgetsActionTypes;

    public class BudgetsAction : Humidifier.Base.BaseResource, IHaveExecutionRoleArn, IHaveActionType, IHaveListOfBudgetsBudgetsActionTypesResourceTagResourceTags, IHaveNotificationType, IHaveBudgetsBudgetsActionTypesActionThresholdActionThreshold, IHaveBudgetsBudgetsActionTypesDefinitionDefinition, IHaveApprovalModel, IHaveListOfBudgetsBudgetsActionTypesSubscriberSubscribers, IHaveBudgetName
    {
        public class Attributes
        {
            public static string ActionId =  "ActionId" ;
        }

        public override string AWSTypeName { get => AWS.Budgets.BudgetsAction; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budgetsaction.html#cfn-budgets-budgetsaction-executionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }

        /// <summary>
        /// ActionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budgetsaction.html#cfn-budgets-budgetsaction-actiontype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ActionType { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budgetsaction.html#cfn-budgets-budgetsaction-resourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Budgets.BudgetsActionTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.Budgets.BudgetsActionTypes.ResourceTag, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }

        /// <summary>
        /// NotificationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budgetsaction.html#cfn-budgets-budgetsaction-notificationtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NotificationType { get; set; }

        /// <summary>
        /// ActionThreshold
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budgetsaction.html#cfn-budgets-budgetsaction-actionthreshold
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ActionThreshold
        /// </summary>
        [Required]
        public Union<Humidifier.Budgets.BudgetsActionTypes.ActionThreshold, BaseFunction>? ActionThreshold { get; set; }

        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budgetsaction.html#cfn-budgets-budgetsaction-definition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Definition
        /// </summary>
        [Required]
        public Union<Humidifier.Budgets.BudgetsActionTypes.Definition, BaseFunction>? Definition { get; set; }
        /// <summary>
        /// ApprovalModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budgetsaction.html#cfn-budgets-budgetsaction-approvalmodel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApprovalModel { get; set; }

        /// <summary>
        /// Subscribers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budgetsaction.html#cfn-budgets-budgetsaction-subscribers
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Subscriber
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Budgets.BudgetsActionTypes.Subscriber>, IReadOnlyList<Union<Humidifier.Budgets.BudgetsActionTypes.Subscriber, BaseFunction>>, BaseFunction>? Subscribers { get; set; }

        /// <summary>
        /// BudgetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budgetsaction.html#cfn-budgets-budgetsaction-budgetname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BudgetName { get; set; }
    }

    namespace BudgetsActionTypes
    {
        public class ActionThreshold : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue_Double
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-actionthreshold.html#cfn-budgets-budgetsaction-actionthreshold-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-actionthreshold.html#cfn-budgets-budgetsaction-actionthreshold-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
        }

        public class Definition : Humidifier.Base.BaseSubResource, IHaveBudgetsBudgetsActionTypesSsmActionDefinitionSsmActionDefinition, IHaveBudgetsBudgetsActionTypesIamActionDefinitionIamActionDefinition, IHaveBudgetsBudgetsActionTypesScpActionDefinitionScpActionDefinition
        {
            /// <summary>
            /// SsmActionDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-definition.html#cfn-budgets-budgetsaction-definition-ssmactiondefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SsmActionDefinition
            /// </summary>
            public Union<Humidifier.Budgets.BudgetsActionTypes.SsmActionDefinition, BaseFunction>? SsmActionDefinition { get; set; }
            /// <summary>
            /// IamActionDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-definition.html#cfn-budgets-budgetsaction-definition-iamactiondefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamActionDefinition
            /// </summary>
            public Union<Humidifier.Budgets.BudgetsActionTypes.IamActionDefinition, BaseFunction>? IamActionDefinition { get; set; }
            /// <summary>
            /// ScpActionDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-definition.html#cfn-budgets-budgetsaction-definition-scpactiondefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScpActionDefinition
            /// </summary>
            public Union<Humidifier.Budgets.BudgetsActionTypes.ScpActionDefinition, BaseFunction>? ScpActionDefinition { get; set; }
        }

        public class IamActionDefinition : Humidifier.Base.BaseSubResource, IHavePolicyArn, IHaveStringListOfGroups, IHaveStringListOfRoles, IHaveStringListOfUsers
        {
            /// <summary>
            /// PolicyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-iamactiondefinition.html#cfn-budgets-budgetsaction-iamactiondefinition-policyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyArn { get; set; }
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-iamactiondefinition.html#cfn-budgets-budgetsaction-iamactiondefinition-groups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Groups { get; set; }
            /// <summary>
            /// Roles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-iamactiondefinition.html#cfn-budgets-budgetsaction-iamactiondefinition-roles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Roles { get; set; }
            /// <summary>
            /// Users
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-iamactiondefinition.html#cfn-budgets-budgetsaction-iamactiondefinition-users
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Users { get; set; }
        }

        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-resourcetag.html#cfn-budgets-budgetsaction-resourcetag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-resourcetag.html#cfn-budgets-budgetsaction-resourcetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ScpActionDefinition : Humidifier.Base.BaseSubResource, IHaveStringListOfTargetIds, IHavePolicyId
        {
            /// <summary>
            /// TargetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-scpactiondefinition.html#cfn-budgets-budgetsaction-scpactiondefinition-targetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetIds { get; set; }
            /// <summary>
            /// PolicyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-scpactiondefinition.html#cfn-budgets-budgetsaction-scpactiondefinition-policyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyId { get; set; }
        }

        public class SsmActionDefinition : Humidifier.Base.BaseSubResource, IHaveRegion, IHaveStringListOfInstanceIds, IHaveSubtype
        {
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-ssmactiondefinition.html#cfn-budgets-budgetsaction-ssmactiondefinition-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// InstanceIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-ssmactiondefinition.html#cfn-budgets-budgetsaction-ssmactiondefinition-instanceids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceIds { get; set; }
            /// <summary>
            /// Subtype
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-ssmactiondefinition.html#cfn-budgets-budgetsaction-ssmactiondefinition-subtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Subtype { get; set; }
        }

        public class Subscriber : Humidifier.Base.BaseSubResource, IHaveType, IHaveAddress
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-subscriber.html#cfn-budgets-budgetsaction-subscriber-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-subscriber.html#cfn-budgets-budgetsaction-subscriber-address
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address { get; set; }
        }
    }
}