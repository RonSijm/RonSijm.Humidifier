namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using ProjectMembershipTypes;

    public class ProjectMembership : Humidifier.Base.BaseResource, IHaveProjectIdentifier, IHaveDesignation, IHaveDataZoneProjectMembershipTypesMemberMember, IHaveDomainIdentifier
    {
        public class Attributes
        {
            public static string MemberIdentifier =  "MemberIdentifier" ;
            public static string MemberIdentifierType =  "MemberIdentifierType" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.ProjectMembership; }

        /// <summary>
        /// ProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectmembership.html#cfn-datazone-projectmembership-projectidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProjectIdentifier { get; set; }

        /// <summary>
        /// Designation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectmembership.html#cfn-datazone-projectmembership-designation
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Designation { get; set; }

        /// <summary>
        /// Member
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectmembership.html#cfn-datazone-projectmembership-member
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Member
        /// </summary>
        [Required]
        public Union<Humidifier.DataZone.ProjectMembershipTypes.Member, BaseFunction>? Member { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectmembership.html#cfn-datazone-projectmembership-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
    }

    namespace ProjectMembershipTypes
    {
        public class Member : Humidifier.Base.BaseSubResource, IHaveUserIdentifier, IHaveGroupIdentifier
        {
            /// <summary>
            /// UserIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectmembership-member.html#cfn-datazone-projectmembership-member-useridentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserIdentifier { get; set; }
            /// <summary>
            /// GroupIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectmembership-member.html#cfn-datazone-projectmembership-member-groupidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupIdentifier { get; set; }
        }
    }
}