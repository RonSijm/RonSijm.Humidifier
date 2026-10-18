namespace Humidifier.ECR
{
    using global::System.Collections.Generic;
    using PublicRepositoryTypes;

    public class PublicRepository : Humidifier.Base.BaseResource, IHaveTags, IHaveRepositoryPolicyText_Json, IHaveRepositoryName, IHaveECRPublicRepositoryTypesRepositoryCatalogDataRepositoryCatalogData
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ECR.PublicRepository; }
        /// <summary>
        /// RepositoryPolicyText
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-publicrepository.html#cfn-ecr-publicrepository-repositorypolicytext
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? RepositoryPolicyText { get; set; }
        /// <summary>
        /// RepositoryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-publicrepository.html#cfn-ecr-publicrepository-repositoryname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RepositoryName { get; set; }
        /// <summary>
        /// RepositoryCatalogData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-publicrepository.html#cfn-ecr-publicrepository-repositorycatalogdata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RepositoryCatalogData
        /// </summary>
        public Union<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData, BaseFunction>? RepositoryCatalogData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-publicrepository.html#cfn-ecr-publicrepository-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PublicRepositoryTypes
    {
        public class RepositoryCatalogData : Humidifier.Base.BaseSubResource, IHaveAboutText, IHaveStringListOfOperatingSystems, IHaveUsageText, IHaveRepositoryDescription, IHaveStringListOfArchitectures
        {
            /// <summary>
            /// AboutText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-publicrepository-repositorycatalogdata.html#cfn-ecr-publicrepository-repositorycatalogdata-abouttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AboutText { get; set; }
            /// <summary>
            /// OperatingSystems
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-publicrepository-repositorycatalogdata.html#cfn-ecr-publicrepository-repositorycatalogdata-operatingsystems
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OperatingSystems { get; set; }
            /// <summary>
            /// UsageText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-publicrepository-repositorycatalogdata.html#cfn-ecr-publicrepository-repositorycatalogdata-usagetext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsageText { get; set; }
            /// <summary>
            /// RepositoryDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-publicrepository-repositorycatalogdata.html#cfn-ecr-publicrepository-repositorycatalogdata-repositorydescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepositoryDescription { get; set; }
            /// <summary>
            /// Architectures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-publicrepository-repositorycatalogdata.html#cfn-ecr-publicrepository-repositorycatalogdata-architectures
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Architectures { get; set; }
        }
    }
}