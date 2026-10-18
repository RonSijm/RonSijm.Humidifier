namespace Humidifier.QBusiness
{
    using global::System.Collections.Generic;
    using PermissionTypes;

    public class Permission : Humidifier.Base.BaseResource, IHaveStringListOfActions, IHaveStatementId, IHaveApplicationId, IHaveListOfQBusinessPermissionTypesConditionConditions, IHavePrincipal
    {
        public override string AWSTypeName { get => AWS.QBusiness.Permission; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-permission.html#cfn-qbusiness-permission-actions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }

        /// <summary>
        /// StatementId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-permission.html#cfn-qbusiness-permission-statementid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StatementId { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-permission.html#cfn-qbusiness-permission-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// Conditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-permission.html#cfn-qbusiness-permission-conditions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Condition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QBusiness.PermissionTypes.Condition>, IReadOnlyList<Union<Humidifier.QBusiness.PermissionTypes.Condition, BaseFunction>>, BaseFunction>? Conditions { get; set; }

        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-permission.html#cfn-qbusiness-permission-principal
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Principal { get; set; }
    }

    namespace PermissionTypes
    {
        public class Condition : Humidifier.Base.BaseSubResource, IHaveConditionOperator, IHaveStringListOfConditionValues, IHaveConditionKey
        {
            /// <summary>
            /// ConditionOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-permission-condition.html#cfn-qbusiness-permission-condition-conditionoperator
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConditionOperator { get; set; }
            /// <summary>
            /// ConditionValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-permission-condition.html#cfn-qbusiness-permission-condition-conditionvalues
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ConditionValues { get; set; }
            /// <summary>
            /// ConditionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-permission-condition.html#cfn-qbusiness-permission-condition-conditionkey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConditionKey { get; set; }
        }
    }
}