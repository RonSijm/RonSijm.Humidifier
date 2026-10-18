namespace Humidifier.CodeStar
{
    using global::System.Collections.Generic;
    using GitHubRepositoryTypes;

    public class GitHubRepository : Humidifier.Base.BaseResource, IHaveEnableIssues_Boolean, IHaveConnectionArn, IHaveRepositoryName, IHaveRepositoryAccessToken, IHaveRepositoryOwner, IHaveIsPrivate_Boolean, IHaveCodeStarGitHubRepositoryTypesCodeCode, IHaveRepositoryDescription
    {
        public override string AWSTypeName { get => AWS.CodeStar.GitHubRepository; }
        /// <summary>
        /// EnableIssues
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestar-githubrepository.html#cfn-codestar-githubrepository-enableissues
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableIssues { get; set; }
        /// <summary>
        /// ConnectionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestar-githubrepository.html#cfn-codestar-githubrepository-connectionarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectionArn { get; set; }

        /// <summary>
        /// RepositoryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestar-githubrepository.html#cfn-codestar-githubrepository-repositoryname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RepositoryName { get; set; }
        /// <summary>
        /// RepositoryAccessToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestar-githubrepository.html#cfn-codestar-githubrepository-repositoryaccesstoken
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RepositoryAccessToken { get; set; }

        /// <summary>
        /// RepositoryOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestar-githubrepository.html#cfn-codestar-githubrepository-repositoryowner
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RepositoryOwner { get; set; }
        /// <summary>
        /// IsPrivate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestar-githubrepository.html#cfn-codestar-githubrepository-isprivate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsPrivate { get; set; }
        /// <summary>
        /// Code
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestar-githubrepository.html#cfn-codestar-githubrepository-code
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Code
        /// </summary>
        public Union<Humidifier.CodeStar.GitHubRepositoryTypes.Code, BaseFunction>? Code { get; set; }
        /// <summary>
        /// RepositoryDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestar-githubrepository.html#cfn-codestar-githubrepository-repositorydescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RepositoryDescription { get; set; }
    }

    namespace GitHubRepositoryTypes
    {
        public class Code : Humidifier.Base.BaseSubResource, IHaveCodeStarGitHubRepositoryTypesS3S3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codestar-githubrepository-code.html#cfn-codestar-githubrepository-code-s3
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3
            /// </summary>
            public Union<Humidifier.CodeStar.GitHubRepositoryTypes.S3, BaseFunction>? S3 { get; set; }
        }

        public class S3 : Humidifier.Base.BaseSubResource, IHaveObjectVersion, IHaveBucket, IHaveKey
        {
            /// <summary>
            /// ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codestar-githubrepository-s3.html#cfn-codestar-githubrepository-s3-objectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectVersion { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codestar-githubrepository-s3.html#cfn-codestar-githubrepository-s3-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codestar-githubrepository-s3.html#cfn-codestar-githubrepository-s3-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}