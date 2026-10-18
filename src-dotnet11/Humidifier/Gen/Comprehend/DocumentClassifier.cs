namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;
    using DocumentClassifierTypes;

    public class DocumentClassifier : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLanguageCode, IHaveDataAccessRoleArn, IHaveComprehendDocumentClassifierTypesDocumentClassifierOutputDataConfigOutputDataConfig, IHaveComprehendDocumentClassifierTypesVpcConfigVpcConfig, IHaveDocumentClassifierName, IHaveMode, IHaveVolumeKmsKeyId, IHaveModelKmsKeyId, IHaveVersionName, IHaveModelPolicy, IHaveComprehendDocumentClassifierTypesDocumentClassifierInputDataConfigInputDataConfig
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Comprehend.DocumentClassifier; }

        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifier.html#cfn-comprehend-documentclassifier-languagecode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LanguageCode { get; set; }

        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifier.html#cfn-comprehend-documentclassifier-dataaccessrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }
        /// <summary>
        /// OutputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifier.html#cfn-comprehend-documentclassifier-outputdataconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DocumentClassifierOutputDataConfig
        /// </summary>
        public Union<Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierOutputDataConfig, BaseFunction>? OutputDataConfig { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifier.html#cfn-comprehend-documentclassifier-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public Union<Humidifier.Comprehend.DocumentClassifierTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        public Union<string, BaseFunction>? DocumentClassifierName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifier.html#cfn-comprehend-documentclassifier-mode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Mode { get; set; }
        /// <summary>
        /// VolumeKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifier.html#cfn-comprehend-documentclassifier-volumekmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
        /// <summary>
        /// ModelKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifier.html#cfn-comprehend-documentclassifier-modelkmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModelKmsKeyId { get; set; }
        /// <summary>
        /// VersionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifier.html#cfn-comprehend-documentclassifier-versionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionName { get; set; }
        /// <summary>
        /// ModelPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifier.html#cfn-comprehend-documentclassifier-modelpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModelPolicy { get; set; }

        /// <summary>
        /// InputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifier.html#cfn-comprehend-documentclassifier-inputdataconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: DocumentClassifierInputDataConfig
        /// </summary>
        [Required]
        public Union<Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierInputDataConfig, BaseFunction>? InputDataConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassifier.html#cfn-comprehend-documentclassifier-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DocumentClassifierTypes
    {
        public class AugmentedManifestsListItem : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveStringListOfAttributeNames, IHaveSplit
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-augmentedmanifestslistitem.html#cfn-comprehend-documentclassifier-augmentedmanifestslistitem-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// AttributeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-augmentedmanifestslistitem.html#cfn-comprehend-documentclassifier-augmentedmanifestslistitem-attributenames
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AttributeNames { get; set; }
            /// <summary>
            /// Split
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-augmentedmanifestslistitem.html#cfn-comprehend-documentclassifier-augmentedmanifestslistitem-split
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Split { get; set; }
        }

        public class DocumentClassifierDocuments : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveTestS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifierdocuments.html#cfn-comprehend-documentclassifier-documentclassifierdocuments-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// TestS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifierdocuments.html#cfn-comprehend-documentclassifier-documentclassifierdocuments-tests3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TestS3Uri { get; set; }
        }

        public class DocumentClassifierInputDataConfig : Humidifier.Base.BaseSubResource, IHaveComprehendDocumentClassifierTypesDocumentReaderConfigDocumentReaderConfig, IHaveS3Uri, IHaveComprehendDocumentClassifierTypesDocumentClassifierDocumentsDocuments, IHaveDataFormat, IHaveDocumentType, IHaveListOfComprehendDocumentClassifierTypesAugmentedManifestsListItemAugmentedManifests, IHaveLabelDelimiter, IHaveTestS3Uri
        {
            /// <summary>
            /// DocumentReaderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifierinputdataconfig.html#cfn-comprehend-documentclassifier-documentclassifierinputdataconfig-documentreaderconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DocumentReaderConfig
            /// </summary>
            public Union<Humidifier.Comprehend.DocumentClassifierTypes.DocumentReaderConfig, BaseFunction>? DocumentReaderConfig { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifierinputdataconfig.html#cfn-comprehend-documentclassifier-documentclassifierinputdataconfig-s3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// Documents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifierinputdataconfig.html#cfn-comprehend-documentclassifier-documentclassifierinputdataconfig-documents
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DocumentClassifierDocuments
            /// </summary>
            public Union<Humidifier.Comprehend.DocumentClassifierTypes.DocumentClassifierDocuments, BaseFunction>? Documents { get; set; }
            /// <summary>
            /// DataFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifierinputdataconfig.html#cfn-comprehend-documentclassifier-documentclassifierinputdataconfig-dataformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataFormat { get; set; }
            /// <summary>
            /// DocumentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifierinputdataconfig.html#cfn-comprehend-documentclassifier-documentclassifierinputdataconfig-documenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentType { get; set; }
            /// <summary>
            /// AugmentedManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifierinputdataconfig.html#cfn-comprehend-documentclassifier-documentclassifierinputdataconfig-augmentedmanifests
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AugmentedManifestsListItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Comprehend.DocumentClassifierTypes.AugmentedManifestsListItem>, IReadOnlyList<Union<Humidifier.Comprehend.DocumentClassifierTypes.AugmentedManifestsListItem, BaseFunction>>, BaseFunction>? AugmentedManifests { get; set; }
            /// <summary>
            /// LabelDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifierinputdataconfig.html#cfn-comprehend-documentclassifier-documentclassifierinputdataconfig-labeldelimiter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LabelDelimiter { get; set; }
            /// <summary>
            /// TestS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifierinputdataconfig.html#cfn-comprehend-documentclassifier-documentclassifierinputdataconfig-tests3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TestS3Uri { get; set; }
        }

        public class DocumentClassifierOutputDataConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveS3Uri
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifieroutputdataconfig.html#cfn-comprehend-documentclassifier-documentclassifieroutputdataconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentclassifieroutputdataconfig.html#cfn-comprehend-documentclassifier-documentclassifieroutputdataconfig-s3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class DocumentReaderConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfFeatureTypes, IHaveDocumentReadMode, IHaveDocumentReadAction
        {
            /// <summary>
            /// FeatureTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentreaderconfig.html#cfn-comprehend-documentclassifier-documentreaderconfig-featuretypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FeatureTypes { get; set; }
            /// <summary>
            /// DocumentReadMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentreaderconfig.html#cfn-comprehend-documentclassifier-documentreaderconfig-documentreadmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentReadMode { get; set; }
            /// <summary>
            /// DocumentReadAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-documentreaderconfig.html#cfn-comprehend-documentclassifier-documentreaderconfig-documentreadaction
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentReadAction { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-vpcconfig.html#cfn-comprehend-documentclassifier-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassifier-vpcconfig.html#cfn-comprehend-documentclassifier-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}