namespace Humidifier.ECR
{
    using System.Collections.Generic;
    using RepositoryTypes;

    public class Repository : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRepositoryName, IHaveRepositoryPolicyText, IHaveImageTagMutability
    {
        public class Attributes
        {
            public static string RepositoryUri =  "RepositoryUri" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ECR.Repository; }
        /// <summary>
        /// EmptyOnDelete
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-emptyondelete
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EmptyOnDelete { get; set; }
        /// <summary>
        /// ImageScanningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-imagescanningconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ImageScanningConfiguration
        /// </summary>
        public Humidifier.ECR.RepositoryTypes.ImageScanningConfiguration ImageScanningConfiguration { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Humidifier.ECR.RepositoryTypes.EncryptionConfiguration EncryptionConfiguration { get; set; }
        /// <summary>
        /// RepositoryPolicyText
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-repositorypolicytext
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic RepositoryPolicyText { get; set; }
        /// <summary>
        /// LifecyclePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-lifecyclepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecyclePolicy
        /// </summary>
        public Humidifier.ECR.RepositoryTypes.LifecyclePolicy LifecyclePolicy { get; set; }
        public dynamic RepositoryName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// ImageTagMutability
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-imagetagmutability
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ImageTagMutability { get; set; }
    }

    namespace RepositoryTypes
    {
        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKey, IHaveEncryptionType
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-encryptionconfiguration.html#cfn-ecr-repository-encryptionconfiguration-encryptiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionType { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-encryptionconfiguration.html#cfn-ecr-repository-encryptionconfiguration-kmskey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKey { get; set; }
        }

        public class ImageScanningConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScanOnPush
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-imagescanningconfiguration.html#cfn-ecr-repository-imagescanningconfiguration-scanonpush
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ScanOnPush { get; set; }
        }

        public class LifecyclePolicy : Humidifier.Base.BaseSubResource, IHaveRegistryId
        {
            /// <summary>
            /// LifecyclePolicyText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-lifecyclepolicy.html#cfn-ecr-repository-lifecyclepolicy-lifecyclepolicytext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LifecyclePolicyText { get; set; }
            /// <summary>
            /// RegistryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-lifecyclepolicy.html#cfn-ecr-repository-lifecyclepolicy-registryid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegistryId { get; set; }
        }
    }
}