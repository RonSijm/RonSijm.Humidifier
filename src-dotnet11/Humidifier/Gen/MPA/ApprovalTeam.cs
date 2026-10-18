namespace Humidifier.MPA
{
    using global::System.Collections.Generic;
    using ApprovalTeamTypes;

    public class ApprovalTeam : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMPAApprovalTeamTypesApprovalStrategyApprovalStrategy, IHaveListOfMPAApprovalTeamTypesPolicyPolicies, IHaveDescription, IHaveListOfMPAApprovalTeamTypesApproverApprovers, IHaveName
    {
        public class Attributes
        {
            public static string VersionId =  "VersionId" ;
            public static string Status =  "Status" ;
            public static string NumberOfApprovers =  "NumberOfApprovers" ;
            public static string LastUpdateTime =  "LastUpdateTime" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
            public static string StatusCode =  "StatusCode" ;
            public static string UpdateSessionArn =  "UpdateSessionArn" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.MPA.ApprovalTeam; }

        /// <summary>
        /// ApprovalStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-approvalteam.html#cfn-mpa-approvalteam-approvalstrategy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ApprovalStrategy
        /// </summary>
        [Required]
        public Union<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy, BaseFunction>? ApprovalStrategy { get; set; }

        /// <summary>
        /// Policies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-approvalteam.html#cfn-mpa-approvalteam-policies
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Policy
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.MPA.ApprovalTeamTypes.Policy>, IReadOnlyList<Union<Humidifier.MPA.ApprovalTeamTypes.Policy, BaseFunction>>, BaseFunction>? Policies { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-approvalteam.html#cfn-mpa-approvalteam-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Approvers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-approvalteam.html#cfn-mpa-approvalteam-approvers
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Approver
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.MPA.ApprovalTeamTypes.Approver>, IReadOnlyList<Union<Humidifier.MPA.ApprovalTeamTypes.Approver, BaseFunction>>, BaseFunction>? Approvers { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-approvalteam.html#cfn-mpa-approvalteam-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ApprovalTeamTypes
    {
        public class ApprovalStrategy : Humidifier.Base.BaseSubResource, IHaveMPAApprovalTeamTypesMofNApprovalStrategyMofN
        {
            /// <summary>
            /// MofN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approvalstrategy.html#cfn-mpa-approvalteam-approvalstrategy-mofn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MofNApprovalStrategy
            /// </summary>
            public Union<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy, BaseFunction>? MofN { get; set; }
        }

        public class Approver : Humidifier.Base.BaseSubResource, IHavePrimaryIdentityStatus, IHavePrimaryIdentitySourceArn, IHaveApproverId, IHavePrimaryIdentityId, IHaveResponseTime
        {
            /// <summary>
            /// PrimaryIdentityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approver.html#cfn-mpa-approvalteam-approver-primaryidentitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryIdentityStatus { get; set; }
            /// <summary>
            /// PrimaryIdentitySourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approver.html#cfn-mpa-approvalteam-approver-primaryidentitysourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryIdentitySourceArn { get; set; }
            /// <summary>
            /// ApproverId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approver.html#cfn-mpa-approvalteam-approver-approverid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApproverId { get; set; }
            /// <summary>
            /// PrimaryIdentityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approver.html#cfn-mpa-approvalteam-approver-primaryidentityid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryIdentityId { get; set; }
            /// <summary>
            /// ResponseTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approver.html#cfn-mpa-approvalteam-approver-responsetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResponseTime { get; set; }
        }

        public class MofNApprovalStrategy : Humidifier.Base.BaseSubResource, IHaveMinApprovalsRequired_Integer
        {
            /// <summary>
            /// MinApprovalsRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-mofnapprovalstrategy.html#cfn-mpa-approvalteam-mofnapprovalstrategy-minapprovalsrequired
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinApprovalsRequired { get; set; }
        }

        public class Policy : Humidifier.Base.BaseSubResource, IHavePolicyArn
        {
            /// <summary>
            /// PolicyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-policy.html#cfn-mpa-approvalteam-policy-policyarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyArn { get; set; }
        }
    }
}