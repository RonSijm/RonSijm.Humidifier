namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using FlowTypes;

    public class Flow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveAwsAccountId
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
        public dynamic Description { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-flow.html#cfn-quicksight-flow-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-flow.html#cfn-quicksight-flow-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Permission
        /// </summary>
        public List<Humidifier.QuickSight.FlowTypes.Permission> Permissions { get; set; }

        /// <summary>
        /// FlowDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-flow.html#cfn-quicksight-flow-flowdefinition
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic FlowDefinition { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace FlowTypes
    {
        public class Permission : Humidifier.Base.BaseSubResource, IHavePrincipal, IHaveActions
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-flow-permission.html#cfn-quicksight-flow-permission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-flow-permission.html#cfn-quicksight-flow-permission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Principal { get; set; }
        }

        public class StepAliasMapping : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StepId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-flow-stepaliasmapping.html#cfn-quicksight-flow-stepaliasmapping-stepid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StepId { get; set; }
            /// <summary>
            /// StepAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-flow-stepaliasmapping.html#cfn-quicksight-flow-stepaliasmapping-stepalias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StepAlias { get; set; }
        }
    }
}