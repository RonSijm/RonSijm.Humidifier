namespace Humidifier.IAM
{
    using global::System.Collections.Generic;
    using GroupTypes;

    public class Group : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGroupName, IHavePath, IHaveStringListOfManagedPolicyArns, IHaveListOfIAMGroupTypesPolicyPolicies
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IAM.Group; }
        public Union<string, BaseFunction>? GroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-group.html#cfn-iam-group-path
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Path { get; set; }
        /// <summary>
        /// ManagedPolicyArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-group.html#cfn-iam-group-managedpolicyarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ManagedPolicyArns { get; set; }
        /// <summary>
        /// Policies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-group.html#cfn-iam-group-policies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Policy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IAM.GroupTypes.Policy>, IReadOnlyList<Union<Humidifier.IAM.GroupTypes.Policy, BaseFunction>>, BaseFunction>? Policies { get; set; }
    }

    namespace GroupTypes
    {
        public class Policy : Humidifier.Base.BaseSubResource, IHavePolicyName, IHavePolicyDocument_Json
        {
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group-policy.html#cfn-iam-group-policy-policyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyName { get; set; }
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group-policy.html#cfn-iam-group-policy-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? PolicyDocument { get; set; }
        }
    }
}