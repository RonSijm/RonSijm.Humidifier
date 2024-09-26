namespace Humidifier.CodeArtifact
{
    using System.Collections.Generic;
    using PackageGroupTypes;

    public class PackageGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveDomainName, IHavePattern
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
        public dynamic Pattern { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }
        /// <summary>
        /// OriginConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-originconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OriginConfiguration
        /// </summary>
        public Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration OriginConfiguration { get; set; }
        /// <summary>
        /// ContactInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-contactinfo
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ContactInfo { get; set; }
        /// <summary>
        /// DomainOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-domainowner
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainOwner { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-packagegroup.html#cfn-codeartifact-packagegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace PackageGroupTypes
    {
        public class OriginConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Restrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-originconfiguration.html#cfn-codeartifact-packagegroup-originconfiguration-restrictions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Restrictions
            /// </summary>
            public Humidifier.CodeArtifact.PackageGroupTypes.Restrictions Restrictions { get; set; }
        }

        public class RestrictionType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Repositories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-restrictiontype.html#cfn-codeartifact-packagegroup-restrictiontype-repositories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Repositories { get; set; }
            /// <summary>
            /// RestrictionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-restrictiontype.html#cfn-codeartifact-packagegroup-restrictiontype-restrictionmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RestrictionMode { get; set; }
        }

        public class Restrictions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExternalUpstream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-restrictions.html#cfn-codeartifact-packagegroup-restrictions-externalupstream
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RestrictionType
            /// </summary>
            public Humidifier.CodeArtifact.PackageGroupTypes.RestrictionType ExternalUpstream { get; set; }
            /// <summary>
            /// Publish
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-restrictions.html#cfn-codeartifact-packagegroup-restrictions-publish
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RestrictionType
            /// </summary>
            public Humidifier.CodeArtifact.PackageGroupTypes.RestrictionType Publish { get; set; }
            /// <summary>
            /// InternalUpstream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-packagegroup-restrictions.html#cfn-codeartifact-packagegroup-restrictions-internalupstream
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RestrictionType
            /// </summary>
            public Humidifier.CodeArtifact.PackageGroupTypes.RestrictionType InternalUpstream { get; set; }
        }
    }
}