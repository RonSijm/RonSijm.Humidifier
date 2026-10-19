namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;

    public class Assignment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAssignmentName, IHavePolicyArn, IHaveAssignmentStatus, IHaveIdentities_Json, IHaveNamespace_
    {
        public class Attributes
        {
            public static string AssignmentId =  "AssignmentId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Assignment; }
        public Union<string, BaseFunction>? AssignmentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PolicyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assignment.html#cfn-quicksight-assignment-policyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PolicyArn { get; set; }

        /// <summary>
        /// AssignmentStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assignment.html#cfn-quicksight-assignment-assignmentstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AssignmentStatus { get; set; }
        /// <summary>
        /// Identities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assignment.html#cfn-quicksight-assignment-identities
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Identities { get; set; }

        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assignment.html#cfn-quicksight-assignment-namespace
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Namespace_ { get; set; }
    }
}