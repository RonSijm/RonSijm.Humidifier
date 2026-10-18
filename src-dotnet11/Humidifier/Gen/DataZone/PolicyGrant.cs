namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using PolicyGrantTypes;

    public class PolicyGrant : Humidifier.Base.BaseResource, IHaveEntityType, IHavePolicyType, IHaveEntityIdentifier, IHaveDataZonePolicyGrantTypesPolicyGrantDetailDetail, IHaveDataZonePolicyGrantTypesPolicyGrantPrincipalPrincipal, IHaveDomainIdentifier
    {
        public class Attributes
        {
            public static string CreatedBy =  "CreatedBy" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string GrantId =  "GrantId" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.PolicyGrant; }

        /// <summary>
        /// EntityType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-policygrant.html#cfn-datazone-policygrant-entitytype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EntityType { get; set; }

        /// <summary>
        /// PolicyType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-policygrant.html#cfn-datazone-policygrant-policytype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyType { get; set; }

        /// <summary>
        /// EntityIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-policygrant.html#cfn-datazone-policygrant-entityidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EntityIdentifier { get; set; }

        /// <summary>
        /// Detail
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-policygrant.html#cfn-datazone-policygrant-detail
        /// Required: True
        /// UpdateType: Immutable
        /// Type: PolicyGrantDetail
        /// </summary>
        [Required]
        public Union<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail, BaseFunction>? Detail { get; set; }

        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-policygrant.html#cfn-datazone-policygrant-principal
        /// Required: True
        /// UpdateType: Immutable
        /// Type: PolicyGrantPrincipal
        /// </summary>
        [Required]
        public Union<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal, BaseFunction>? Principal { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-policygrant.html#cfn-datazone-policygrant-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
    }

    namespace PolicyGrantTypes
    {
        public class AddToProjectMemberPoolPolicyGrantDetail : Humidifier.Base.BaseSubResource, IHaveIncludeChildDomainUnits_Boolean
        {
            /// <summary>
            /// IncludeChildDomainUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-addtoprojectmemberpoolpolicygrantdetail.html#cfn-datazone-policygrant-addtoprojectmemberpoolpolicygrantdetail-includechilddomainunits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeChildDomainUnits { get; set; }
        }

        public class CreateAssetTypePolicyGrantDetail : Humidifier.Base.BaseSubResource, IHaveIncludeChildDomainUnits_Boolean
        {
            /// <summary>
            /// IncludeChildDomainUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-createassettypepolicygrantdetail.html#cfn-datazone-policygrant-createassettypepolicygrantdetail-includechilddomainunits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeChildDomainUnits { get; set; }
        }

        public class CreateDomainUnitPolicyGrantDetail : Humidifier.Base.BaseSubResource, IHaveIncludeChildDomainUnits_Boolean
        {
            /// <summary>
            /// IncludeChildDomainUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-createdomainunitpolicygrantdetail.html#cfn-datazone-policygrant-createdomainunitpolicygrantdetail-includechilddomainunits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeChildDomainUnits { get; set; }
        }

        public class CreateEnvironmentProfilePolicyGrantDetail : Humidifier.Base.BaseSubResource, IHaveDomainUnitId
        {
            /// <summary>
            /// DomainUnitId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-createenvironmentprofilepolicygrantdetail.html#cfn-datazone-policygrant-createenvironmentprofilepolicygrantdetail-domainunitid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainUnitId { get; set; }
        }

        public class CreateFormTypePolicyGrantDetail : Humidifier.Base.BaseSubResource, IHaveIncludeChildDomainUnits_Boolean
        {
            /// <summary>
            /// IncludeChildDomainUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-createformtypepolicygrantdetail.html#cfn-datazone-policygrant-createformtypepolicygrantdetail-includechilddomainunits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeChildDomainUnits { get; set; }
        }

        public class CreateGlossaryPolicyGrantDetail : Humidifier.Base.BaseSubResource, IHaveIncludeChildDomainUnits_Boolean
        {
            /// <summary>
            /// IncludeChildDomainUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-createglossarypolicygrantdetail.html#cfn-datazone-policygrant-createglossarypolicygrantdetail-includechilddomainunits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeChildDomainUnits { get; set; }
        }

        public class CreateProjectFromProjectProfilePolicyGrantDetail : Humidifier.Base.BaseSubResource, IHaveStringListOfProjectProfiles, IHaveIncludeChildDomainUnits_Boolean
        {
            /// <summary>
            /// ProjectProfiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-createprojectfromprojectprofilepolicygrantdetail.html#cfn-datazone-policygrant-createprojectfromprojectprofilepolicygrantdetail-projectprofiles
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ProjectProfiles { get; set; }
            /// <summary>
            /// IncludeChildDomainUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-createprojectfromprojectprofilepolicygrantdetail.html#cfn-datazone-policygrant-createprojectfromprojectprofilepolicygrantdetail-includechilddomainunits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeChildDomainUnits { get; set; }
        }

        public class CreateProjectPolicyGrantDetail : Humidifier.Base.BaseSubResource, IHaveIncludeChildDomainUnits_Boolean
        {
            /// <summary>
            /// IncludeChildDomainUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-createprojectpolicygrantdetail.html#cfn-datazone-policygrant-createprojectpolicygrantdetail-includechilddomainunits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeChildDomainUnits { get; set; }
        }

        public class DomainUnitFilterForProject : Humidifier.Base.BaseSubResource, IHaveDomainUnit, IHaveIncludeChildDomainUnits_Boolean
        {
            /// <summary>
            /// DomainUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-domainunitfilterforproject.html#cfn-datazone-policygrant-domainunitfilterforproject-domainunit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainUnit { get; set; }
            /// <summary>
            /// IncludeChildDomainUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-domainunitfilterforproject.html#cfn-datazone-policygrant-domainunitfilterforproject-includechilddomainunits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeChildDomainUnits { get; set; }
        }

        public class DomainUnitGrantFilter : Humidifier.Base.BaseSubResource, IHaveAllDomainUnitsGrantFilter_Json
        {
            /// <summary>
            /// AllDomainUnitsGrantFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-domainunitgrantfilter.html#cfn-datazone-policygrant-domainunitgrantfilter-alldomainunitsgrantfilter
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AllDomainUnitsGrantFilter { get; set; }
        }

        public class DomainUnitPolicyGrantPrincipal : Humidifier.Base.BaseSubResource, IHaveDataZonePolicyGrantTypesDomainUnitGrantFilterDomainUnitGrantFilter, IHaveDomainUnitDesignation, IHaveDomainUnitIdentifier
        {
            /// <summary>
            /// DomainUnitGrantFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-domainunitpolicygrantprincipal.html#cfn-datazone-policygrant-domainunitpolicygrantprincipal-domainunitgrantfilter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DomainUnitGrantFilter
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter, BaseFunction>? DomainUnitGrantFilter { get; set; }
            /// <summary>
            /// DomainUnitDesignation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-domainunitpolicygrantprincipal.html#cfn-datazone-policygrant-domainunitpolicygrantprincipal-domainunitdesignation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainUnitDesignation { get; set; }
            /// <summary>
            /// DomainUnitIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-domainunitpolicygrantprincipal.html#cfn-datazone-policygrant-domainunitpolicygrantprincipal-domainunitidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainUnitIdentifier { get; set; }
        }

        public class GroupPolicyGrantPrincipal : Humidifier.Base.BaseSubResource, IHaveGroupIdentifier
        {
            /// <summary>
            /// GroupIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-grouppolicygrantprincipal.html#cfn-datazone-policygrant-grouppolicygrantprincipal-groupidentifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupIdentifier { get; set; }
        }

        public class OverrideDomainUnitOwnersPolicyGrantDetail : Humidifier.Base.BaseSubResource, IHaveIncludeChildDomainUnits_Boolean
        {
            /// <summary>
            /// IncludeChildDomainUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-overridedomainunitownerspolicygrantdetail.html#cfn-datazone-policygrant-overridedomainunitownerspolicygrantdetail-includechilddomainunits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeChildDomainUnits { get; set; }
        }

        public class OverrideProjectOwnersPolicyGrantDetail : Humidifier.Base.BaseSubResource, IHaveIncludeChildDomainUnits_Boolean
        {
            /// <summary>
            /// IncludeChildDomainUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-overrideprojectownerspolicygrantdetail.html#cfn-datazone-policygrant-overrideprojectownerspolicygrantdetail-includechilddomainunits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeChildDomainUnits { get; set; }
        }

        public class PolicyGrantDetail : Humidifier.Base.BaseSubResource, IHaveCreateEnvironmentFromBlueprint_Json, IHaveDataZonePolicyGrantTypesCreateGlossaryPolicyGrantDetailCreateGlossary, IHaveDataZonePolicyGrantTypesCreateAssetTypePolicyGrantDetailCreateAssetType, IHaveDataZonePolicyGrantTypesCreateDomainUnitPolicyGrantDetailCreateDomainUnit, IHaveDataZonePolicyGrantTypesCreateProjectPolicyGrantDetailCreateProject, IHaveDataZonePolicyGrantTypesOverrideProjectOwnersPolicyGrantDetailOverrideProjectOwners, IHaveDataZonePolicyGrantTypesAddToProjectMemberPoolPolicyGrantDetailAddToProjectMemberPool, IHaveDelegateCreateEnvironmentProfile_Json, IHaveDataZonePolicyGrantTypesCreateProjectFromProjectProfilePolicyGrantDetailCreateProjectFromProjectProfile, IHaveCreateEnvironment_Json, IHaveDataZonePolicyGrantTypesCreateEnvironmentProfilePolicyGrantDetailCreateEnvironmentProfile, IHaveDataZonePolicyGrantTypesCreateFormTypePolicyGrantDetailCreateFormType, IHaveDataZonePolicyGrantTypesOverrideDomainUnitOwnersPolicyGrantDetailOverrideDomainUnitOwners
        {
            /// <summary>
            /// CreateEnvironmentFromBlueprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-createenvironmentfromblueprint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? CreateEnvironmentFromBlueprint { get; set; }
            /// <summary>
            /// CreateGlossary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-createglossary
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CreateGlossaryPolicyGrantDetail
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.CreateGlossaryPolicyGrantDetail, BaseFunction>? CreateGlossary { get; set; }
            /// <summary>
            /// CreateAssetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-createassettype
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CreateAssetTypePolicyGrantDetail
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.CreateAssetTypePolicyGrantDetail, BaseFunction>? CreateAssetType { get; set; }
            /// <summary>
            /// CreateDomainUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-createdomainunit
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CreateDomainUnitPolicyGrantDetail
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.CreateDomainUnitPolicyGrantDetail, BaseFunction>? CreateDomainUnit { get; set; }
            /// <summary>
            /// CreateProject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-createproject
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CreateProjectPolicyGrantDetail
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.CreateProjectPolicyGrantDetail, BaseFunction>? CreateProject { get; set; }
            /// <summary>
            /// OverrideProjectOwners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-overrideprojectowners
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OverrideProjectOwnersPolicyGrantDetail
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.OverrideProjectOwnersPolicyGrantDetail, BaseFunction>? OverrideProjectOwners { get; set; }
            /// <summary>
            /// AddToProjectMemberPool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-addtoprojectmemberpool
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AddToProjectMemberPoolPolicyGrantDetail
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.AddToProjectMemberPoolPolicyGrantDetail, BaseFunction>? AddToProjectMemberPool { get; set; }
            /// <summary>
            /// DelegateCreateEnvironmentProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-delegatecreateenvironmentprofile
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? DelegateCreateEnvironmentProfile { get; set; }
            /// <summary>
            /// CreateProjectFromProjectProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-createprojectfromprojectprofile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CreateProjectFromProjectProfilePolicyGrantDetail
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.CreateProjectFromProjectProfilePolicyGrantDetail, BaseFunction>? CreateProjectFromProjectProfile { get; set; }
            /// <summary>
            /// CreateEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-createenvironment
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? CreateEnvironment { get; set; }
            /// <summary>
            /// CreateEnvironmentProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-createenvironmentprofile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CreateEnvironmentProfilePolicyGrantDetail
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.CreateEnvironmentProfilePolicyGrantDetail, BaseFunction>? CreateEnvironmentProfile { get; set; }
            /// <summary>
            /// CreateFormType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-createformtype
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CreateFormTypePolicyGrantDetail
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.CreateFormTypePolicyGrantDetail, BaseFunction>? CreateFormType { get; set; }
            /// <summary>
            /// OverrideDomainUnitOwners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantdetail.html#cfn-datazone-policygrant-policygrantdetail-overridedomainunitowners
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OverrideDomainUnitOwnersPolicyGrantDetail
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.OverrideDomainUnitOwnersPolicyGrantDetail, BaseFunction>? OverrideDomainUnitOwners { get; set; }
        }

        public class PolicyGrantPrincipal : Humidifier.Base.BaseSubResource, IHaveDataZonePolicyGrantTypesGroupPolicyGrantPrincipalGroup, IHaveDataZonePolicyGrantTypesProjectPolicyGrantPrincipalProject, IHaveDataZonePolicyGrantTypesUserPolicyGrantPrincipalUser, IHaveDataZonePolicyGrantTypesDomainUnitPolicyGrantPrincipalDomainUnit
        {
            /// <summary>
            /// Group
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantprincipal.html#cfn-datazone-policygrant-policygrantprincipal-group
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GroupPolicyGrantPrincipal
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.GroupPolicyGrantPrincipal, BaseFunction>? Group { get; set; }
            /// <summary>
            /// Project
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantprincipal.html#cfn-datazone-policygrant-policygrantprincipal-project
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProjectPolicyGrantPrincipal
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.ProjectPolicyGrantPrincipal, BaseFunction>? Project { get; set; }
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantprincipal.html#cfn-datazone-policygrant-policygrantprincipal-user
            /// Required: False
            /// UpdateType: Immutable
            /// Type: UserPolicyGrantPrincipal
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.UserPolicyGrantPrincipal, BaseFunction>? User { get; set; }
            /// <summary>
            /// DomainUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-policygrantprincipal.html#cfn-datazone-policygrant-policygrantprincipal-domainunit
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DomainUnitPolicyGrantPrincipal
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.DomainUnitPolicyGrantPrincipal, BaseFunction>? DomainUnit { get; set; }
        }

        public class ProjectGrantFilter : Humidifier.Base.BaseSubResource, IHaveDataZonePolicyGrantTypesDomainUnitFilterForProjectDomainUnitFilter
        {
            /// <summary>
            /// DomainUnitFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-projectgrantfilter.html#cfn-datazone-policygrant-projectgrantfilter-domainunitfilter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DomainUnitFilterForProject
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject, BaseFunction>? DomainUnitFilter { get; set; }
        }

        public class ProjectPolicyGrantPrincipal : Humidifier.Base.BaseSubResource, IHaveProjectIdentifier, IHaveProjectDesignation, IHaveDataZonePolicyGrantTypesProjectGrantFilterProjectGrantFilter
        {
            /// <summary>
            /// ProjectIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-projectpolicygrantprincipal.html#cfn-datazone-policygrant-projectpolicygrantprincipal-projectidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectIdentifier { get; set; }
            /// <summary>
            /// ProjectDesignation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-projectpolicygrantprincipal.html#cfn-datazone-policygrant-projectpolicygrantprincipal-projectdesignation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectDesignation { get; set; }
            /// <summary>
            /// ProjectGrantFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-projectpolicygrantprincipal.html#cfn-datazone-policygrant-projectpolicygrantprincipal-projectgrantfilter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProjectGrantFilter
            /// </summary>
            public Union<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter, BaseFunction>? ProjectGrantFilter { get; set; }
        }

        public class UserPolicyGrantPrincipal : Humidifier.Base.BaseSubResource, IHaveAllUsersGrantFilter_Json, IHaveUserIdentifier
        {
            /// <summary>
            /// AllUsersGrantFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-userpolicygrantprincipal.html#cfn-datazone-policygrant-userpolicygrantprincipal-allusersgrantfilter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AllUsersGrantFilter { get; set; }
            /// <summary>
            /// UserIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-policygrant-userpolicygrantprincipal.html#cfn-datazone-policygrant-userpolicygrantprincipal-useridentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserIdentifier { get; set; }
        }
    }
}