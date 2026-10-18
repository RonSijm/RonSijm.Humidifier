namespace Humidifier.CodeCommit
{
    using global::System.Collections.Generic;
    using RepositoryTypes;

    public class Repository : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKmsKeyId, IHaveRepositoryName, IHaveListOfCodeCommitRepositoryTypesRepositoryTriggerTriggers, IHaveCodeCommitRepositoryTypesCodeCode, IHaveRepositoryDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string CloneUrlHttp =  "CloneUrlHttp" ;
            public static string CloneUrlSsh =  "CloneUrlSsh" ;
            public static string Arn =  "Arn" ;
            public static string RepositoryId =  "RepositoryId" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.CodeCommit.Repository; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html#cfn-codecommit-repository-kmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        public Union<string, BaseFunction>? RepositoryName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Triggers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html#cfn-codecommit-repository-triggers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RepositoryTrigger
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger>, IReadOnlyList<Union<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger, BaseFunction>>, BaseFunction>? Triggers { get; set; }
        /// <summary>
        /// Code
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html#cfn-codecommit-repository-code
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Code
        /// </summary>
        public Union<Humidifier.CodeCommit.RepositoryTypes.Code, BaseFunction>? Code { get; set; }
        /// <summary>
        /// RepositoryDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html#cfn-codecommit-repository-repositorydescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RepositoryDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => RepositoryDescription; set => RepositoryDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html#cfn-codecommit-repository-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace RepositoryTypes
    {
        public class Code : Humidifier.Base.BaseSubResource, IHaveCodeCommitRepositoryTypesS3S3, IHaveBranchName
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-code.html#cfn-codecommit-repository-code-s3
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3
            /// </summary>
            public Union<Humidifier.CodeCommit.RepositoryTypes.S3, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// BranchName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-code.html#cfn-codecommit-repository-code-branchname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BranchName { get; set; }
        }

        public class RepositoryTrigger : Humidifier.Base.BaseSubResource, IHaveStringListOfEvents, IHaveStringListOfBranches, IHaveCustomData, IHaveDestinationArn, IHaveName
        {
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-repositorytrigger.html#cfn-codecommit-repository-repositorytrigger-events
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Events { get; set; }
            /// <summary>
            /// Branches
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-repositorytrigger.html#cfn-codecommit-repository-repositorytrigger-branches
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Branches { get; set; }
            /// <summary>
            /// CustomData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-repositorytrigger.html#cfn-codecommit-repository-repositorytrigger-customdata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomData { get; set; }
            /// <summary>
            /// DestinationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-repositorytrigger.html#cfn-codecommit-repository-repositorytrigger-destinationarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-repositorytrigger.html#cfn-codecommit-repository-repositorytrigger-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class S3 : Humidifier.Base.BaseSubResource, IHaveObjectVersion, IHaveBucket, IHaveKey
        {
            /// <summary>
            /// ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-s3.html#cfn-codecommit-repository-s3-objectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectVersion { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-s3.html#cfn-codecommit-repository-s3-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-s3.html#cfn-codecommit-repository-s3-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}