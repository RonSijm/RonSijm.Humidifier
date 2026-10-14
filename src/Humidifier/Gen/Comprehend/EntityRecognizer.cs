namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;
    using EntityRecognizerTypes;

    public class EntityRecognizer : Humidifier.Base.BaseResource, IHaveTags, IHaveLanguageCode, IHaveVolumeKmsKeyId, IHaveVersionName, IHaveDataAccessRoleArn, IHaveModelKmsKeyId
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
        public dynamic LanguageCode { get; set; }

        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-dataaccessrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DataAccessRoleArn { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig VpcConfig { get; set; }
        /// <summary>
        /// VolumeKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-volumekmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VolumeKmsKeyId { get; set; }
        /// <summary>
        /// ModelKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-modelkmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModelKmsKeyId { get; set; }

        /// <summary>
        /// RecognizerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-recognizername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RecognizerName { get; set; }
        /// <summary>
        /// VersionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-versionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VersionName { get; set; }
        /// <summary>
        /// ModelPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-modelpolicy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModelPolicy { get; set; }

        /// <summary>
        /// InputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-inputdataconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: EntityRecognizerInputDataConfig
        /// </summary>
        [Required]
        public Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerInputDataConfig InputDataConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entityrecognizer.html#cfn-comprehend-entityrecognizer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace EntityRecognizerTypes
    {
        public class AugmentedManifestsListItem : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveDocumentType
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// AnnotationDataS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-annotationdatas3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AnnotationDataS3Uri { get; set; }
            /// <summary>
            /// SourceDocumentsS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-sourcedocumentss3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceDocumentsS3Uri { get; set; }
            /// <summary>
            /// DocumentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-documenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentType { get; set; }
            /// <summary>
            /// AttributeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-attributenames
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AttributeNames { get; set; }
            /// <summary>
            /// Split
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-augmentedmanifestslistitem.html#cfn-comprehend-entityrecognizer-augmentedmanifestslistitem-split
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Split { get; set; }
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
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// TestS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerannotations.html#cfn-comprehend-entityrecognizer-entityrecognizerannotations-tests3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TestS3Uri { get; set; }
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
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// InputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerdocuments.html#cfn-comprehend-entityrecognizer-entityrecognizerdocuments-inputformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputFormat { get; set; }
            /// <summary>
            /// TestS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerdocuments.html#cfn-comprehend-entityrecognizer-entityrecognizerdocuments-tests3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TestS3Uri { get; set; }
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
            public dynamic S3Uri { get; set; }
        }

        public class EntityRecognizerInputDataConfig : Humidifier.Base.BaseSubResource, IHaveDataFormat
        {
            /// <summary>
            /// EntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-entitytypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EntityTypesListItem
            /// </summary>
            public List<Humidifier.Comprehend.EntityRecognizerTypes.EntityTypesListItem> EntityTypes { get; set; }
            /// <summary>
            /// Annotations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-annotations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EntityRecognizerAnnotations
            /// </summary>
            public Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerAnnotations Annotations { get; set; }
            /// <summary>
            /// Documents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-documents
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EntityRecognizerDocuments
            /// </summary>
            public Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerDocuments Documents { get; set; }
            /// <summary>
            /// DataFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-dataformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataFormat { get; set; }
            /// <summary>
            /// EntityList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-entitylist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EntityRecognizerEntityList
            /// </summary>
            public Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerEntityList EntityList { get; set; }
            /// <summary>
            /// AugmentedManifests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-entityrecognizerinputdataconfig.html#cfn-comprehend-entityrecognizer-entityrecognizerinputdataconfig-augmentedmanifests
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AugmentedManifestsListItem
            /// </summary>
            public List<Humidifier.Comprehend.EntityRecognizerTypes.AugmentedManifestsListItem> AugmentedManifests { get; set; }
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
            public dynamic Type { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnets
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-vpcconfig.html#cfn-comprehend-entityrecognizer-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entityrecognizer-vpcconfig.html#cfn-comprehend-entityrecognizer-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}