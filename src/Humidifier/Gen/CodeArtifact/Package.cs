namespace Humidifier.CodeArtifact
{
    using global::System.Collections.Generic;
    using PackageTypes;

    public class Package : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveNamespace_, IHaveDomainName, IHaveFormat, IHaveRepository
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
        public dynamic Repository { get; set; }

        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-package.html#cfn-codeartifact-package-format
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Format { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-package.html#cfn-codeartifact-package-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }
        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-package.html#cfn-codeartifact-package-namespace
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Namespace_ { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace PackageTypes
    {
        public class OriginConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Restrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-package-originconfiguration.html#cfn-codeartifact-package-originconfiguration-restrictions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Restrictions
            /// </summary>
            public Humidifier.CodeArtifact.PackageTypes.Restrictions Restrictions { get; set; }
        }

        public class Restrictions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Upstream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-package-restrictions.html#cfn-codeartifact-package-restrictions-upstream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Upstream { get; set; }
            /// <summary>
            /// Publish
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeartifact-package-restrictions.html#cfn-codeartifact-package-restrictions-publish
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Publish { get; set; }
        }
    }
}