namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using FlowTypes;

    public class Flow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveAwsAccountId, IHaveListOfQuickSightFlowTypesPermissionPermissions, IHaveFlowDefinition_Json, IHaveName
    {
        public class Attributes
        {
            public static string FlowId =  "FlowId" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string StepAliases =  "StepAliases" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Arn =  "Arn" ;
            public static string PublishState =  "PublishState" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Flow; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-flow.html#cfn-quicksight-flow-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-flow.html#cfn-quicksight-flow-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-flow.html#cfn-quicksight-flow-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Permission
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.FlowTypes.Permission>, IReadOnlyList<Union<Humidifier.QuickSight.FlowTypes.Permission, BaseFunction>>, BaseFunction>? Permissions { get; set; }

        /// <summary>
        /// FlowDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-flow.html#cfn-quicksight-flow-flowdefinition
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? FlowDefinition { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FlowTypes
    {
        public class Permission : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHavePrincipal
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-flow-permission.html#cfn-quicksight-flow-permission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-flow-permission.html#cfn-quicksight-flow-permission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Principal { get; set; }
        }

        public class StepAliasMapping : Humidifier.Base.BaseSubResource, IHaveStepId, IHaveStepAlias
        {
            /// <summary>
            /// StepId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-flow-stepaliasmapping.html#cfn-quicksight-flow-stepaliasmapping-stepid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StepId { get; set; }
            /// <summary>
            /// StepAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-flow-stepaliasmapping.html#cfn-quicksight-flow-stepaliasmapping-stepalias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StepAlias { get; set; }
        }
    }
}