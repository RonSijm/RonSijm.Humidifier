namespace Humidifier.DataZone
{
    using System.Collections.Generic;
    using ProjectMembershipTypes;

    public class ProjectMembership : Humidifier.Base.BaseResource, IHaveDomainIdentifier, IHaveProjectIdentifier
    {
        public override string AWSTypeName { get => AWS.DataZone.ProjectMembership; }

        /// <summary>
        /// ProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectmembership.html#cfn-datazone-projectmembership-projectidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProjectIdentifier { get; set; }

        /// <summary>
        /// Designation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectmembership.html#cfn-datazone-projectmembership-designation
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Designation { get; set; }

        /// <summary>
        /// Member
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectmembership.html#cfn-datazone-projectmembership-member
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Member
        /// </summary>
        [Required]
        public Humidifier.DataZone.ProjectMembershipTypes.Member Member { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectmembership.html#cfn-datazone-projectmembership-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainIdentifier { get; set; }
    }

    namespace ProjectMembershipTypes
    {
        public class Member : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UserIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectmembership-member.html#cfn-datazone-projectmembership-member-useridentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserIdentifier { get; set; }
            /// <summary>
            /// GroupIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectmembership-member.html#cfn-datazone-projectmembership-member-groupidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupIdentifier { get; set; }
        }
    }
}