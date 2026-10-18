namespace Humidifier.CodeStarConnections
{
    using global::System.Collections.Generic;

    public class RepositoryLink : Humidifier.Base.BaseResource, IHaveTags, IHaveOwnerId, IHaveEncryptionKeyArn, IHaveConnectionArn, IHaveRepositoryName
    {
        public class Attributes
        {
            public static string RepositoryLinkArn =  "RepositoryLinkArn" ;
            public static string ProviderType =  "ProviderType" ;
            public static string RepositoryLinkId =  "RepositoryLinkId" ;
        }

        public override string AWSTypeName { get => AWS.CodeStarConnections.RepositoryLink; }

        /// <summary>
        /// OwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-repositorylink.html#cfn-codestarconnections-repositorylink-ownerid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OwnerId { get; set; }
        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-repositorylink.html#cfn-codestarconnections-repositorylink-encryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }

        /// <summary>
        /// ConnectionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-repositorylink.html#cfn-codestarconnections-repositorylink-connectionarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectionArn { get; set; }

        /// <summary>
        /// RepositoryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-repositorylink.html#cfn-codestarconnections-repositorylink-repositoryname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RepositoryName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-repositorylink.html#cfn-codestarconnections-repositorylink-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}