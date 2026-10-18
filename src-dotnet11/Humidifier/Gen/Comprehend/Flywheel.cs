namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;
    using FlywheelTypes;

    public class Flywheel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDataLakeS3Uri, IHaveDataAccessRoleArn, IHaveFlywheelName, IHaveModelType, IHaveComprehendFlywheelTypesTaskConfigTaskConfig, IHaveActiveModelArn, IHaveComprehendFlywheelTypesDataSecurityConfigDataSecurityConfig
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Comprehend.Flywheel; }

        /// <summary>
        /// DataLakeS3Uri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheel.html#cfn-comprehend-flywheel-datalakes3uri
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataLakeS3Uri { get; set; }

        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheel.html#cfn-comprehend-flywheel-dataaccessrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }
        public Union<string, BaseFunction>? FlywheelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ModelType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheel.html#cfn-comprehend-flywheel-modeltype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModelType { get; set; }
        /// <summary>
        /// TaskConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheel.html#cfn-comprehend-flywheel-taskconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TaskConfig
        /// </summary>
        public Union<Humidifier.Comprehend.FlywheelTypes.TaskConfig, BaseFunction>? TaskConfig { get; set; }
        /// <summary>
        /// ActiveModelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheel.html#cfn-comprehend-flywheel-activemodelarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ActiveModelArn { get; set; }
        /// <summary>
        /// DataSecurityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheel.html#cfn-comprehend-flywheel-datasecurityconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSecurityConfig
        /// </summary>
        public Union<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig, BaseFunction>? DataSecurityConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheel.html#cfn-comprehend-flywheel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FlywheelTypes
    {
        public class DataSecurityConfig : Humidifier.Base.BaseSubResource, IHaveComprehendFlywheelTypesVpcConfigVpcConfig, IHaveVolumeKmsKeyId, IHaveModelKmsKeyId, IHaveDataLakeKmsKeyId
        {
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-datasecurityconfig.html#cfn-comprehend-flywheel-datasecurityconfig-vpcconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.Comprehend.FlywheelTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-datasecurityconfig.html#cfn-comprehend-flywheel-datasecurityconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
            /// <summary>
            /// ModelKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-datasecurityconfig.html#cfn-comprehend-flywheel-datasecurityconfig-modelkmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelKmsKeyId { get; set; }
            /// <summary>
            /// DataLakeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-datasecurityconfig.html#cfn-comprehend-flywheel-datasecurityconfig-datalakekmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataLakeKmsKeyId { get; set; }
        }

        public class DocumentClassificationConfig : Humidifier.Base.BaseSubResource, IHaveMode, IHaveStringListOfLabels
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-documentclassificationconfig.html#cfn-comprehend-flywheel-documentclassificationconfig-mode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// Labels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-documentclassificationconfig.html#cfn-comprehend-flywheel-documentclassificationconfig-labels
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Labels { get; set; }
        }

        public class EntityRecognitionConfig : Humidifier.Base.BaseSubResource, IHaveListOfComprehendFlywheelTypesEntityTypesListItemEntityTypes
        {
            /// <summary>
            /// EntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-entityrecognitionconfig.html#cfn-comprehend-flywheel-entityrecognitionconfig-entitytypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EntityTypesListItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Comprehend.FlywheelTypes.EntityTypesListItem>, IReadOnlyList<Union<Humidifier.Comprehend.FlywheelTypes.EntityTypesListItem, BaseFunction>>, BaseFunction>? EntityTypes { get; set; }
        }

        public class EntityTypesListItem : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-entitytypeslistitem.html#cfn-comprehend-flywheel-entitytypeslistitem-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class TaskConfig : Humidifier.Base.BaseSubResource, IHaveLanguageCode, IHaveComprehendFlywheelTypesDocumentClassificationConfigDocumentClassificationConfig, IHaveComprehendFlywheelTypesEntityRecognitionConfigEntityRecognitionConfig
        {
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-taskconfig.html#cfn-comprehend-flywheel-taskconfig-languagecode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LanguageCode { get; set; }
            /// <summary>
            /// DocumentClassificationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-taskconfig.html#cfn-comprehend-flywheel-taskconfig-documentclassificationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DocumentClassificationConfig
            /// </summary>
            public Union<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig, BaseFunction>? DocumentClassificationConfig { get; set; }
            /// <summary>
            /// EntityRecognitionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-taskconfig.html#cfn-comprehend-flywheel-taskconfig-entityrecognitionconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EntityRecognitionConfig
            /// </summary>
            public Union<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig, BaseFunction>? EntityRecognitionConfig { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-vpcconfig.html#cfn-comprehend-flywheel-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-flywheel-vpcconfig.html#cfn-comprehend-flywheel-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}