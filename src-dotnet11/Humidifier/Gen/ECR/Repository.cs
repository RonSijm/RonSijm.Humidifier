namespace Humidifier.ECR
{
    using global::System.Collections.Generic;
    using RepositoryTypes;

    public class Repository : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEmptyOnDelete_Boolean, IHaveECRRepositoryTypesImageScanningConfigurationImageScanningConfiguration, IHaveListOfECRRepositoryTypesImageTagMutabilityExclusionFilterImageTagMutabilityExclusionFilters, IHaveECRRepositoryTypesEncryptionConfigurationEncryptionConfiguration, IHaveRepositoryPolicyText_Json, IHaveECRRepositoryTypesLifecyclePolicyLifecyclePolicy, IHaveRepositoryName, IHaveImageTagMutability
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
        public Union<bool, BaseFunction>? EmptyOnDelete { get; set; }
        /// <summary>
        /// ImageScanningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-imagescanningconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ImageScanningConfiguration
        /// </summary>
        public Union<Humidifier.ECR.RepositoryTypes.ImageScanningConfiguration, BaseFunction>? ImageScanningConfiguration { get; set; }
        /// <summary>
        /// ImageTagMutabilityExclusionFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-imagetagmutabilityexclusionfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ImageTagMutabilityExclusionFilter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECR.RepositoryTypes.ImageTagMutabilityExclusionFilter>, IReadOnlyList<Union<Humidifier.ECR.RepositoryTypes.ImageTagMutabilityExclusionFilter, BaseFunction>>, BaseFunction>? ImageTagMutabilityExclusionFilters { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.ECR.RepositoryTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// RepositoryPolicyText
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-repositorypolicytext
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? RepositoryPolicyText { get; set; }
        /// <summary>
        /// LifecyclePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-lifecyclepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecyclePolicy
        /// </summary>
        public Union<Humidifier.ECR.RepositoryTypes.LifecyclePolicy, BaseFunction>? LifecyclePolicy { get; set; }
        public Union<string, BaseFunction>? RepositoryName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ImageTagMutability
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-imagetagmutability
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageTagMutability { get; set; }
    }

    namespace RepositoryTypes
    {
        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveEncryptionType, IHaveKmsKey
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-encryptionconfiguration.html#cfn-ecr-repository-encryptionconfiguration-encryptiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-encryptionconfiguration.html#cfn-ecr-repository-encryptionconfiguration-kmskey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
        }

        public class ImageScanningConfiguration : Humidifier.Base.BaseSubResource, IHaveScanOnPush_Boolean
        {
            /// <summary>
            /// ScanOnPush
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-imagescanningconfiguration.html#cfn-ecr-repository-imagescanningconfiguration-scanonpush
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ScanOnPush { get; set; }
        }

        public class ImageTagMutabilityExclusionFilter : Humidifier.Base.BaseSubResource, IHaveImageTagMutabilityExclusionFilterType, IHaveImageTagMutabilityExclusionFilterValue
        {
            /// <summary>
            /// ImageTagMutabilityExclusionFilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-imagetagmutabilityexclusionfilter.html#cfn-ecr-repository-imagetagmutabilityexclusionfilter-imagetagmutabilityexclusionfiltertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageTagMutabilityExclusionFilterType { get; set; }
            /// <summary>
            /// ImageTagMutabilityExclusionFilterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-imagetagmutabilityexclusionfilter.html#cfn-ecr-repository-imagetagmutabilityexclusionfilter-imagetagmutabilityexclusionfiltervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageTagMutabilityExclusionFilterValue { get; set; }
        }

        public class LifecyclePolicy : Humidifier.Base.BaseSubResource, IHaveLifecyclePolicyText, IHaveRegistryId
        {
            /// <summary>
            /// LifecyclePolicyText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-lifecyclepolicy.html#cfn-ecr-repository-lifecyclepolicy-lifecyclepolicytext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LifecyclePolicyText { get; set; }
            /// <summary>
            /// RegistryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-lifecyclepolicy.html#cfn-ecr-repository-lifecyclepolicy-registryid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegistryId { get; set; }
        }
    }
}