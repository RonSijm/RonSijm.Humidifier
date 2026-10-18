namespace Humidifier.ECR
{
    using global::System.Collections.Generic;
    using RepositoryCreationTemplateTypes;

    public class RepositoryCreationTemplate : Humidifier.Base.BaseResource, IHaveListOfECRRepositoryCreationTemplateTypesImageTagMutabilityExclusionFilterImageTagMutabilityExclusionFilters, IHaveCustomRoleArn, IHaveDescription, IHaveECRRepositoryCreationTemplateTypesEncryptionConfigurationEncryptionConfiguration, IHaveTagListOfResourceTags, IHaveRepositoryPolicy, IHaveLifecyclePolicy, IHaveStringListOfAppliedFor, IHavePrefix, IHaveImageTagMutability
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.ECR.RepositoryCreationTemplate; }
        /// <summary>
        /// ImageTagMutabilityExclusionFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repositorycreationtemplate.html#cfn-ecr-repositorycreationtemplate-imagetagmutabilityexclusionfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ImageTagMutabilityExclusionFilter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECR.RepositoryCreationTemplateTypes.ImageTagMutabilityExclusionFilter>, IReadOnlyList<Union<Humidifier.ECR.RepositoryCreationTemplateTypes.ImageTagMutabilityExclusionFilter, BaseFunction>>, BaseFunction>? ImageTagMutabilityExclusionFilters { get; set; }
        /// <summary>
        /// CustomRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repositorycreationtemplate.html#cfn-ecr-repositorycreationtemplate-customrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomRoleArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repositorycreationtemplate.html#cfn-ecr-repositorycreationtemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repositorycreationtemplate.html#cfn-ecr-repositorycreationtemplate-encryptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repositorycreationtemplate.html#cfn-ecr-repositorycreationtemplate-resourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }
        /// <summary>
        /// RepositoryPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repositorycreationtemplate.html#cfn-ecr-repositorycreationtemplate-repositorypolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RepositoryPolicy { get; set; }
        /// <summary>
        /// LifecyclePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repositorycreationtemplate.html#cfn-ecr-repositorycreationtemplate-lifecyclepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LifecyclePolicy { get; set; }

        /// <summary>
        /// AppliedFor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repositorycreationtemplate.html#cfn-ecr-repositorycreationtemplate-appliedfor
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AppliedFor { get; set; }

        /// <summary>
        /// Prefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repositorycreationtemplate.html#cfn-ecr-repositorycreationtemplate-prefix
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Prefix { get; set; }
        /// <summary>
        /// ImageTagMutability
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repositorycreationtemplate.html#cfn-ecr-repositorycreationtemplate-imagetagmutability
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageTagMutability { get; set; }
    }

    namespace RepositoryCreationTemplateTypes
    {
        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveEncryptionType, IHaveKmsKey
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repositorycreationtemplate-encryptionconfiguration.html#cfn-ecr-repositorycreationtemplate-encryptionconfiguration-encryptiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repositorycreationtemplate-encryptionconfiguration.html#cfn-ecr-repositorycreationtemplate-encryptionconfiguration-kmskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
        }

        public class ImageTagMutabilityExclusionFilter : Humidifier.Base.BaseSubResource, IHaveImageTagMutabilityExclusionFilterType, IHaveImageTagMutabilityExclusionFilterValue
        {
            /// <summary>
            /// ImageTagMutabilityExclusionFilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repositorycreationtemplate-imagetagmutabilityexclusionfilter.html#cfn-ecr-repositorycreationtemplate-imagetagmutabilityexclusionfilter-imagetagmutabilityexclusionfiltertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageTagMutabilityExclusionFilterType { get; set; }
            /// <summary>
            /// ImageTagMutabilityExclusionFilterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repositorycreationtemplate-imagetagmutabilityexclusionfilter.html#cfn-ecr-repositorycreationtemplate-imagetagmutabilityexclusionfilter-imagetagmutabilityexclusionfiltervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageTagMutabilityExclusionFilterValue { get; set; }
        }
    }
}