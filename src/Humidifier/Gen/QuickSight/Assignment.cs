namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;

    public class Assignment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveNamespace_, IHavePolicyArn
    {
        public class Attributes
        {
            public static string AssignmentId =  "AssignmentId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Assignment; }
        public dynamic AssignmentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PolicyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assignment.html#cfn-quicksight-assignment-policyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PolicyArn { get; set; }

        /// <summary>
        /// AssignmentStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assignment.html#cfn-quicksight-assignment-assignmentstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssignmentStatus { get; set; }
        /// <summary>
        /// Identities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assignment.html#cfn-quicksight-assignment-identities
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Identities { get; set; }

        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-assignment.html#cfn-quicksight-assignment-namespace
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Namespace_ { get; set; }
    }
}