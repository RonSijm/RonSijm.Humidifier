namespace Humidifier.ManagedBlockchain
{
    using global::System.Collections.Generic;
    using MemberTypes;

    public class Member : Humidifier.Base.BaseResource, IHaveManagedBlockchainMemberTypesMemberConfigurationMemberConfiguration, IHaveManagedBlockchainMemberTypesNetworkConfigurationNetworkConfiguration, IHaveNetworkId, IHaveInvitationId
    {
        public class Attributes
        {
            public static string MemberId =  "MemberId" ;
            public static string NetworkId =  "NetworkId" ;
        }

        public override string AWSTypeName { get => AWS.ManagedBlockchain.Member; }

        /// <summary>
        /// MemberConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-member.html#cfn-managedblockchain-member-memberconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MemberConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration, BaseFunction>? MemberConfiguration { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-member.html#cfn-managedblockchain-member-networkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NetworkConfiguration
        /// </summary>
        public Union<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
        /// <summary>
        /// NetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-member.html#cfn-managedblockchain-member-networkid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkId { get; set; }
        /// <summary>
        /// InvitationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-member.html#cfn-managedblockchain-member-invitationid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InvitationId { get; set; }
    }

    namespace MemberTypes
    {
        public class ApprovalThresholdPolicy : Humidifier.Base.BaseSubResource, IHaveThresholdComparator, IHaveThresholdPercentage_Integer, IHaveProposalDurationInHours_Integer
        {
            /// <summary>
            /// ThresholdComparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-approvalthresholdpolicy.html#cfn-managedblockchain-member-approvalthresholdpolicy-thresholdcomparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThresholdComparator { get; set; }
            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-approvalthresholdpolicy.html#cfn-managedblockchain-member-approvalthresholdpolicy-thresholdpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThresholdPercentage { get; set; }
            /// <summary>
            /// ProposalDurationInHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-approvalthresholdpolicy.html#cfn-managedblockchain-member-approvalthresholdpolicy-proposaldurationinhours
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProposalDurationInHours { get; set; }
        }

        public class MemberConfiguration : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveManagedBlockchainMemberTypesMemberFrameworkConfigurationMemberFrameworkConfiguration, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberconfiguration.html#cfn-managedblockchain-member-memberconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// MemberFrameworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberconfiguration.html#cfn-managedblockchain-member-memberconfiguration-memberframeworkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemberFrameworkConfiguration
            /// </summary>
            public Union<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration, BaseFunction>? MemberFrameworkConfiguration { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberconfiguration.html#cfn-managedblockchain-member-memberconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MemberFabricConfiguration : Humidifier.Base.BaseSubResource, IHaveAdminUsername, IHaveAdminPassword
        {
            /// <summary>
            /// AdminUsername
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberfabricconfiguration.html#cfn-managedblockchain-member-memberfabricconfiguration-adminusername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdminUsername { get; set; }
            /// <summary>
            /// AdminPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberfabricconfiguration.html#cfn-managedblockchain-member-memberfabricconfiguration-adminpassword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdminPassword { get; set; }
        }

        public class MemberFrameworkConfiguration : Humidifier.Base.BaseSubResource, IHaveManagedBlockchainMemberTypesMemberFabricConfigurationMemberFabricConfiguration
        {
            /// <summary>
            /// MemberFabricConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberframeworkconfiguration.html#cfn-managedblockchain-member-memberframeworkconfiguration-memberfabricconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemberFabricConfiguration
            /// </summary>
            public Union<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration, BaseFunction>? MemberFabricConfiguration { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveFrameworkVersion, IHaveManagedBlockchainMemberTypesVotingPolicyVotingPolicy, IHaveFramework, IHaveName, IHaveManagedBlockchainMemberTypesNetworkFrameworkConfigurationNetworkFrameworkConfiguration
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// FrameworkVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-frameworkversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FrameworkVersion { get; set; }
            /// <summary>
            /// VotingPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-votingpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VotingPolicy
            /// </summary>
            public Union<Humidifier.ManagedBlockchain.MemberTypes.VotingPolicy, BaseFunction>? VotingPolicy { get; set; }
            /// <summary>
            /// Framework
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-framework
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Framework { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// NetworkFrameworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-networkframeworkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkFrameworkConfiguration
            /// </summary>
            public Union<Humidifier.ManagedBlockchain.MemberTypes.NetworkFrameworkConfiguration, BaseFunction>? NetworkFrameworkConfiguration { get; set; }
        }

        public class NetworkFabricConfiguration : Humidifier.Base.BaseSubResource, IHaveEdition
        {
            /// <summary>
            /// Edition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkfabricconfiguration.html#cfn-managedblockchain-member-networkfabricconfiguration-edition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Edition { get; set; }
        }

        public class NetworkFrameworkConfiguration : Humidifier.Base.BaseSubResource, IHaveManagedBlockchainMemberTypesNetworkFabricConfigurationNetworkFabricConfiguration
        {
            /// <summary>
            /// NetworkFabricConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkframeworkconfiguration.html#cfn-managedblockchain-member-networkframeworkconfiguration-networkfabricconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkFabricConfiguration
            /// </summary>
            public Union<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration, BaseFunction>? NetworkFabricConfiguration { get; set; }
        }

        public class VotingPolicy : Humidifier.Base.BaseSubResource, IHaveManagedBlockchainMemberTypesApprovalThresholdPolicyApprovalThresholdPolicy
        {
            /// <summary>
            /// ApprovalThresholdPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-votingpolicy.html#cfn-managedblockchain-member-votingpolicy-approvalthresholdpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApprovalThresholdPolicy
            /// </summary>
            public Union<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy, BaseFunction>? ApprovalThresholdPolicy { get; set; }
        }
    }
}