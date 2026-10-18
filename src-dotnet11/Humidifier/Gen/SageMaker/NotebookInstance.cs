namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using NotebookInstanceTypes;

    public class NotebookInstance : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKmsKeyId, IHaveVolumeSizeInGB_Integer, IHaveStringListOfAdditionalCodeRepositories, IHaveDefaultCodeRepository, IHaveDirectInternetAccess, IHavePlatformIdentifier, IHaveSubnetId, IHaveStringListOfSecurityGroupIds, IHaveRoleArn, IHaveSageMakerNotebookInstanceTypesInstanceMetadataServiceConfigurationInstanceMetadataServiceConfiguration, IHaveRootAccess, IHaveInstanceType, IHaveNotebookInstanceName, IHaveLifecycleConfigName
    {
        public class Attributes
        {
            public static string NotebookInstanceArn =  "NotebookInstanceArn" ;
            public static string NotebookInstanceName =  "NotebookInstanceName" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.NotebookInstance; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// VolumeSizeInGB
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-volumesizeingb
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
        /// <summary>
        /// AdditionalCodeRepositories
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-additionalcoderepositories
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdditionalCodeRepositories { get; set; }
        /// <summary>
        /// DefaultCodeRepository
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-defaultcoderepository
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultCodeRepository { get; set; }
        /// <summary>
        /// DirectInternetAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-directinternetaccess
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DirectInternetAccess { get; set; }
        /// <summary>
        /// PlatformIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-platformidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PlatformIdentifier { get; set; }
        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-subnetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SubnetId { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-securitygroupids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// InstanceMetadataServiceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-instancemetadataserviceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceMetadataServiceConfiguration
        /// </summary>
        public Union<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration, BaseFunction>? InstanceMetadataServiceConfiguration { get; set; }
        /// <summary>
        /// RootAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-rootaccess
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RootAccess { get; set; }

        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-instancetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceType { get; set; }
        public Union<string, BaseFunction>? NotebookInstanceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// LifecycleConfigName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-lifecycleconfigname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LifecycleConfigName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html#cfn-sagemaker-notebookinstance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace NotebookInstanceTypes
    {
        public class InstanceMetadataServiceConfiguration : Humidifier.Base.BaseSubResource, IHaveMinimumInstanceMetadataServiceVersion
        {
            /// <summary>
            /// MinimumInstanceMetadataServiceVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-notebookinstance-instancemetadataserviceconfiguration.html#cfn-sagemaker-notebookinstance-instancemetadataserviceconfiguration-minimuminstancemetadataserviceversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MinimumInstanceMetadataServiceVersion { get; set; }
        }
    }
}