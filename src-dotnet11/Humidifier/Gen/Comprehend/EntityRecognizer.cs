namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;
    using EntityRecognizerTypes;

    public class EntityRecognizer : Humidifier.Base.BaseResource, IHaveTags, IHaveLanguageCode, IHaveDataAccessRoleArn, IHaveComprehendEntityRecognizerTypesVpcConfigVpcConfig, IHaveVolumeKmsKeyId, IHaveModelKmsKeyId, IHaveRecognizerName, IHaveVersionName, IHaveModelPolicy, IHaveComprehendEntityRecognizerTypesEntityRecognizerInputDataConfigInputDataConfig
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Comprehend.EntityRecognizer; }

        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-languagecode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LanguageCode { get; set; }

        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-dataaccessrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public Union<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        /// <summary>
        /// VolumeKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-volumekmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
        /// <summary>
        /// ModelKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-modelkmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModelKmsKeyId { get; set; }

        /// <summary>
        /// RecognizerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-recognizername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RecognizerName { get; set; }
        /// <summary>
        /// VersionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-versionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionName { get; set; }
        /// <summary>
        /// ModelPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-modelpolicy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModelPolicy { get; set; }

        /// <summary>
        /// InputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-inputdataconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: EntityRecognizerInputDataConfig
        /// </summary>
        [Required]
        public Union<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig, BaseFunction>? InputDataConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EntityRecognizerTypes
    {
        public class AugmentedManifestsListItem : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveAnnotationDataS3Uri, IHaveSourceDocumentsS3Uri, IHaveDocumentType, IHaveStringListOfAttributeNames, IHaveSplit
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// AnnotationDataS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-annotationdatas3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnnotationDataS3Uri { get; set; }
            /// <summary>
            /// SourceDocumentsS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-sourcedocumentss3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceDocumentsS3Uri { get; set; }
            /// <summary>
            /// DocumentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-documenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentType { get; set; }
            /// <summary>
            /// AttributeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-attributenames
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AttributeNames { get; set; }
            /// <summary>
            /// Split
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-split
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Split { get; set; }
        }

        public class EntityRecognizerAnnotations : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveTestS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerannotations.html#cfn-comprehend-entityrecognizer-entityrecognizerannotations-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// TestS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerannotations.html#cfn-comprehend-entityrecognizer-entityrecognizerannotations-tests3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TestS3Uri { get; set; }
        }

        public class EntityRecognizerDocuments : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveInputFormat, IHaveTestS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerdocuments.html#cfn-comprehend-entityrecognizer-entityrecognizerdocuments-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// InputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerdocuments.html#cfn-comprehend-entityrecognizer-entityrecognizerdocuments-inputformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputFormat { get; set; }
            /// <summary>
            /// TestS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerdocuments.html#cfn-comprehend-entityrecognizer-entityrecognizerdocuments-tests3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TestS3Uri { get; set; }
        }

        public class EntityRecognizerEntityList : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerentitylist.html#cfn-comprehend-entityrecognizer-entityrecognizerentitylist-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class EntityRecognizerInputDataConfig : Humidifier.Base.BaseSubResource, IHaveListOfComprehendEntityRecognizerTypesEntityTypesListItemEntityTypes, IHaveComprehendEntityRecognizerTypesEntityRecognizerAnnotationsAnnotations, IHaveComprehendEntityRecognizerTypesEntityRecognizerDocumentsDocuments, IHaveDataFormat, IHaveComprehendEntityRecognizerTypesEntityRecognizerEntityListEntityList, IHaveListOfComprehendEntityRecognizerTypesAugmentedManifestsListItemAugmentedManifests
        {
            /// <summary>
            /// EntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-entitytypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EntityTypesListItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Comprehend.EntityRecognizerTypes.EntityTypesListItem>, IReadOnlyList<Union<Humidifier.Comprehend.EntityRecognizerTypes.EntityTypesListItem, BaseFunction>>, BaseFunction>? EntityTypes { get; set; }
            /// <summary>
            /// Annotations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-annotations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EntityRecognizerAnnotations
            /// </summary>
            public Union<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerAnnotations, BaseFunction>? Annotations { get; set; }
            /// <summary>
            /// Documents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-documents
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EntityRecognizerDocuments
            /// </summary>
            public Union<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerDocuments, BaseFunction>? Documents { get; set; }
            /// <summary>
            /// DataFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-dataformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataFormat { get; set; }
            /// <summary>
            /// EntityList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-entitylist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EntityRecognizerEntityList
            /// </summary>
            public Union<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerEntityList, BaseFunction>? EntityList { get; set; }
            /// <summary>
            /// AugmentedManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-augmentedmanifests
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AugmentedManifestsListItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Comprehend.EntityRecognizerTypes.AugmentedManifestsListItem>, IReadOnlyList<Union<Humidifier.Comprehend.EntityRecognizerTypes.AugmentedManifestsListItem, BaseFunction>>, BaseFunction>? AugmentedManifests { get; set; }
        }

        public class EntityTypesListItem : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entitytypeslistitem.html#cfn-comprehend-entityrecognizer-entitytypeslistitem-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-vpcconfig.html#cfn-comprehend-entityrecognizer-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-vpcconfig.html#cfn-comprehend-entityrecognizer-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}