namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using CodeRepositoryTypes;

    public class CodeRepository : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCodeRepositoryName, IHaveSageMakerCodeRepositoryTypesGitConfigGitConfig
    {
        public class Attributes
        {
            public static string CodeRepositoryName =  "CodeRepositoryName" ;
            public static string CodeRepositoryArn =  "CodeRepositoryArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.CodeRepository; }
        public Union<string, BaseFunction>? CodeRepositoryName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// GitConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-coderepository.html#cfn-sagemaker-coderepository-gitconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: GitConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig, BaseFunction>? GitConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-coderepository.html#cfn-sagemaker-coderepository-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CodeRepositoryTypes
    {
        public class GitConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveBranch, IHaveRepositoryUrl
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-coderepository-gitconfig.html#cfn-sagemaker-coderepository-gitconfig-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// Branch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-coderepository-gitconfig.html#cfn-sagemaker-coderepository-gitconfig-branch
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Branch { get; set; }
            /// <summary>
            /// RepositoryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-coderepository-gitconfig.html#cfn-sagemaker-coderepository-gitconfig-repositoryurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepositoryUrl { get; set; }
        }
    }
}