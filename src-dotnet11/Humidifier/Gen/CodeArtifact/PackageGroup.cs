namespace Humidifier.CodeArtifact
{
    using global::System.Collections.Generic;
    using PackageGroupTypes;

    public class PackageGroup : Humidifier.Base.BaseResource, IHaveTags, IHavePattern, IHaveDescription, IHaveDomainName, IHaveCodeArtifactPackageGroupTypesOriginConfigurationOriginConfiguration, IHaveContactInfo, IHaveDomainOwner
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CodeArtifact.PackageGroup; }

        /// <summary>
        /// Pattern
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-pattern
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Pattern { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName { get; set; }
        /// <summary>
        /// OriginConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-originconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OriginConfiguration
        /// </summary>
        public Union<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration, BaseFunction>? OriginConfiguration { get; set; }
        /// <summary>
        /// ContactInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-contactinfo
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ContactInfo { get; set; }
        /// <summary>
        /// DomainOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-domainowner
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainOwner { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PackageGroupTypes
    {
        public class OriginConfiguration : Humidifier.Base.BaseSubResource, IHaveCodeArtifactPackageGroupTypesRestrictionsRestrictions
        {
            /// <summary>
            /// Restrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-originconfiguration.html#cfn-codeartifact-packagegroup-originconfiguration-restrictions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Restrictions
            /// </summary>
            public Union<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions, BaseFunction>? Restrictions { get; set; }
        }

        public class RestrictionType : Humidifier.Base.BaseSubResource, IHaveStringListOfRepositories, IHaveRestrictionMode
        {
            /// <summary>
            /// Repositories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-restrictiontype.html#cfn-codeartifact-packagegroup-restrictiontype-repositories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Repositories { get; set; }
            /// <summary>
            /// RestrictionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-restrictiontype.html#cfn-codeartifact-packagegroup-restrictiontype-restrictionmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RestrictionMode { get; set; }
        }

        public class Restrictions : Humidifier.Base.BaseSubResource, IHaveCodeArtifactPackageGroupTypesRestrictionTypeExternalUpstream, IHaveCodeArtifactPackageGroupTypesRestrictionTypePublish, IHaveCodeArtifactPackageGroupTypesRestrictionTypeInternalUpstream
        {
            /// <summary>
            /// ExternalUpstream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-restrictions.html#cfn-codeartifact-packagegroup-restrictions-externalupstream
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RestrictionType
            /// </summary>
            public Union<Humidifier.CodeArtifact.PackageGroupTypes.RestrictionType, BaseFunction>? ExternalUpstream { get; set; }
            /// <summary>
            /// Publish
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-restrictions.html#cfn-codeartifact-packagegroup-restrictions-publish
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RestrictionType
            /// </summary>
            public Union<Humidifier.CodeArtifact.PackageGroupTypes.RestrictionType, BaseFunction>? Publish { get; set; }
            /// <summary>
            /// InternalUpstream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-restrictions.html#cfn-codeartifact-packagegroup-restrictions-internalupstream
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RestrictionType
            /// </summary>
            public Union<Humidifier.CodeArtifact.PackageGroupTypes.RestrictionType, BaseFunction>? InternalUpstream { get; set; }
        }
    }
}