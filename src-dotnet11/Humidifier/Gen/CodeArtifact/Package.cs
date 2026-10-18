namespace Humidifier.CodeArtifact
{
    using global::System.Collections.Generic;
    using PackageTypes;

    public class Package : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveRepository, IHaveFormat, IHaveDomainName, IHaveNamespace_, IHaveName
    {
        public class Attributes
        {
            public static string OriginConfiguration =  "OriginConfiguration" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CodeArtifact.Package; }

        /// <summary>
        /// Repository
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-package.html#cfn-codeartifact-package-repository
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Repository { get; set; }

        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-package.html#cfn-codeartifact-package-format
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Format { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-package.html#cfn-codeartifact-package-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName { get; set; }
        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-package.html#cfn-codeartifact-package-namespace
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Namespace_ { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PackageTypes
    {
        public class OriginConfiguration : Humidifier.Base.BaseSubResource, IHaveCodeArtifactPackageTypesRestrictionsRestrictions
        {
            /// <summary>
            /// Restrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-package-originconfiguration.html#cfn-codeartifact-package-originconfiguration-restrictions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Restrictions
            /// </summary>
            public Union<Humidifier.CodeArtifact.PackageTypes.Restrictions, BaseFunction>? Restrictions { get; set; }
        }

        public class Restrictions : Humidifier.Base.BaseSubResource, IHaveUpstream, IHavePublish
        {
            /// <summary>
            /// Upstream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-package-restrictions.html#cfn-codeartifact-package-restrictions-upstream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Upstream { get; set; }
            /// <summary>
            /// Publish
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-package-restrictions.html#cfn-codeartifact-package-restrictions-publish
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Publish { get; set; }
        }
    }
}