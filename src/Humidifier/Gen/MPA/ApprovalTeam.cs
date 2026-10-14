namespace Humidifier.MPA
{
    using global::System.Collections.Generic;
    using ApprovalTeamTypes;

    public class ApprovalTeam : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy ApprovalStrategy { get; set; }

        /// <summary>
        /// Policies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-approvalteam.html#cfn-mpa-approvalteam-policies
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Policy
        /// </summary>
        [Required]
        public List<Humidifier.MPA.ApprovalTeamTypes.Policy> Policies { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-approvalteam.html#cfn-mpa-approvalteam-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Description { get; set; }

        /// <summary>
        /// Approvers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-approvalteam.html#cfn-mpa-approvalteam-approvers
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Approver
        /// </summary>
        [Required]
        public List<Humidifier.MPA.ApprovalTeamTypes.Approver> Approvers { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-approvalteam.html#cfn-mpa-approvalteam-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ApprovalTeamTypes
    {
        public class ApprovalStrategy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MofN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approvalstrategy.html#cfn-mpa-approvalteam-approvalstrategy-mofn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MofNApprovalStrategy
            /// </summary>
            public Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy MofN { get; set; }
        }

        public class Approver : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrimaryIdentityStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approver.html#cfn-mpa-approvalteam-approver-primaryidentitystatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryIdentityStatus { get; set; }
            /// <summary>
            /// PrimaryIdentitySourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approver.html#cfn-mpa-approvalteam-approver-primaryidentitysourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryIdentitySourceArn { get; set; }
            /// <summary>
            /// ApproverId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approver.html#cfn-mpa-approvalteam-approver-approverid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApproverId { get; set; }
            /// <summary>
            /// PrimaryIdentityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approver.html#cfn-mpa-approvalteam-approver-primaryidentityid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryIdentityId { get; set; }
            /// <summary>
            /// ResponseTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-approver.html#cfn-mpa-approvalteam-approver-responsetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResponseTime { get; set; }
        }

        public class MofNApprovalStrategy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MinApprovalsRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-approvalteam-mofnapprovalstrategy.html#cfn-mpa-approvalteam-mofnapprovalstrategy-minapprovalsrequired
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinApprovalsRequired { get; set; }
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
            public dynamic PolicyArn { get; set; }
        }
    }
}