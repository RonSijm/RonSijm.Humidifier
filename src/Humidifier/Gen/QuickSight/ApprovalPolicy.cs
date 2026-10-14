namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using ApprovalPolicyTypes;

    public class ApprovalPolicy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
    {
        public class Attributes
        {
            public static string PolicyArn =  "PolicyArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.ApprovalPolicy; }

        /// <summary>
        /// ApplicableTo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-approvalpolicy.html#cfn-quicksight-approvalpolicy-applicableto
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ApplicableTo
        /// </summary>
        [Required]
        public Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo ApplicableTo { get; set; }

        /// <summary>
        /// AssetTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-approvalpolicy.html#cfn-quicksight-approvalpolicy-assettypes
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: Json
        /// </summary>
        [Required]
        public List<dynamic> AssetTypes { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-approvalpolicy.html#cfn-quicksight-approvalpolicy-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-approvalpolicy.html#cfn-quicksight-approvalpolicy-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: Json
        /// </summary>
        [Required]
        public List<dynamic> Actions { get; set; }

        /// <summary>
        /// ApprovalGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-approvalpolicy.html#cfn-quicksight-approvalpolicy-approvalgroups
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic ApprovalGroups { get; set; }

        /// <summary>
        /// PolicyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-approvalpolicy.html#cfn-quicksight-approvalpolicy-policyid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PolicyId { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ApprovalPolicyTypes
    {
        public class ApplicableTo : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// GroupArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-approvalpolicy-applicableto.html#cfn-quicksight-approvalpolicy-applicableto-grouparns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic GroupArns { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-approvalpolicy-applicableto.html#cfn-quicksight-approvalpolicy-applicableto-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Type { get; set; }
        }
    }
}