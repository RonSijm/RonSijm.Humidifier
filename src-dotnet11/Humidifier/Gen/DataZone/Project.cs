namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using ProjectTypes;

    public class Project : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDomainUnitId, IHaveProjectProfileId, IHaveListOfDataZoneProjectTypesEnvironmentConfigurationUserParameterUserParameters, IHaveDescription, IHaveProjectCategory, IHaveListOfDataZoneProjectTypesResourceTagResourceTags, IHaveStringListOfGlossaryTerms, IHaveProjectExecutionRole, IHaveProjectProfileVersion, IHaveListOfDataZoneProjectTypesProjectMembershipAssignmentMembershipAssignments, IHaveName, IHaveDomainIdentifier
    {
        public class Attributes
        {
            public static string ProjectStatus =  "ProjectStatus" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string DomainId =  "DomainId" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.Project; }
        /// <summary>
        /// DomainUnitId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-project.html#cfn-datazone-project-domainunitid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainUnitId { get; set; }
        /// <summary>
        /// ProjectProfileId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-project.html#cfn-datazone-project-projectprofileid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectProfileId { get; set; }
        /// <summary>
        /// UserParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-project.html#cfn-datazone-project-userparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EnvironmentConfigurationUserParameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter>, IReadOnlyList<Union<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter, BaseFunction>>, BaseFunction>? UserParameters { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-project.html#cfn-datazone-project-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ProjectCategory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-project.html#cfn-datazone-project-projectcategory
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectCategory { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-project.html#cfn-datazone-project-resourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataZone.ProjectTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.DataZone.ProjectTypes.ResourceTag, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }
        /// <summary>
        /// GlossaryTerms
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-project.html#cfn-datazone-project-glossaryterms
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GlossaryTerms { get; set; }
        /// <summary>
        /// ProjectExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-project.html#cfn-datazone-project-projectexecutionrole
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectExecutionRole { get; set; }
        /// <summary>
        /// ProjectProfileVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-project.html#cfn-datazone-project-projectprofileversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectProfileVersion { get; set; }
        /// <summary>
        /// MembershipAssignments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-project.html#cfn-datazone-project-membershipassignments
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ProjectMembershipAssignment
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment>, IReadOnlyList<Union<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment, BaseFunction>>, BaseFunction>? MembershipAssignments { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-project.html#cfn-datazone-project-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
    }

    namespace ProjectTypes
    {
        public class EnvironmentConfigurationUserParameter : Humidifier.Base.BaseSubResource, IHaveEnvironmentId, IHaveListOfDataZoneProjectTypesEnvironmentParameterEnvironmentParameters, IHaveEnvironmentConfigurationName
        {
            /// <summary>
            /// EnvironmentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-project-environmentconfigurationuserparameter.html#cfn-datazone-project-environmentconfigurationuserparameter-environmentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnvironmentId { get; set; }
            /// <summary>
            /// EnvironmentParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-project-environmentconfigurationuserparameter.html#cfn-datazone-project-environmentconfigurationuserparameter-environmentparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EnvironmentParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataZone.ProjectTypes.EnvironmentParameter>, IReadOnlyList<Union<Humidifier.DataZone.ProjectTypes.EnvironmentParameter, BaseFunction>>, BaseFunction>? EnvironmentParameters { get; set; }
            /// <summary>
            /// EnvironmentConfigurationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-project-environmentconfigurationuserparameter.html#cfn-datazone-project-environmentconfigurationuserparameter-environmentconfigurationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnvironmentConfigurationName { get; set; }
        }

        public class EnvironmentParameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-project-environmentparameter.html#cfn-datazone-project-environmentparameter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-project-environmentparameter.html#cfn-datazone-project-environmentparameter-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Member : Humidifier.Base.BaseSubResource, IHaveUserIdentifier, IHaveGroupIdentifier
        {
            /// <summary>
            /// UserIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-project-member.html#cfn-datazone-project-member-useridentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserIdentifier { get; set; }
            /// <summary>
            /// GroupIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-project-member.html#cfn-datazone-project-member-groupidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupIdentifier { get; set; }
        }

        public class ProjectMembershipAssignment : Humidifier.Base.BaseSubResource, IHaveDesignation, IHaveDataZoneProjectTypesMemberMember
        {
            /// <summary>
            /// Designation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-project-projectmembershipassignment.html#cfn-datazone-project-projectmembershipassignment-designation
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Designation { get; set; }
            /// <summary>
            /// Member
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-project-projectmembershipassignment.html#cfn-datazone-project-projectmembershipassignment-member
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Member
            /// </summary>
            public Union<Humidifier.DataZone.ProjectTypes.Member, BaseFunction>? Member { get; set; }
        }

        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-project-resourcetag.html#cfn-datazone-project-resourcetag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-project-resourcetag.html#cfn-datazone-project-resourcetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}