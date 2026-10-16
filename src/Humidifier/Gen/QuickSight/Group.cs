namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;

    public class Group : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveNamespace_, IHaveGroupName
    {
        public class Attributes
        {
            public static string PrincipalId =  "PrincipalId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Group; }
        public dynamic GroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-group.html#cfn-quicksight-group-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-group.html#cfn-quicksight-group-namespace
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Namespace_ { get; set; }
    }
}