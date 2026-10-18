namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using ModelImportJobTypes;

    public class ModelImportJob : Humidifier.Base.BaseResource, IHaveTags, IHaveImportedModelKmsKeyArn, IHaveBedrockModelImportJobTypesVpcConfigVpcConfig, IHaveBedrockModelImportJobTypesModelDataSourceModelDataSource, IHaveRoleArn
    {
        public class Attributes
        {
            public static string JobArn =  "JobArn" ;
            public static string Status =  "Status" ;
            public static string EndTime =  "EndTime" ;
            public static string JobName =  "JobName" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string ImportedModelName =  "ImportedModelName" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.ModelImportJob; }
        /// <summary>
        /// ImportedModelKmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-modelimportjob.html#cfn-bedrock-modelimportjob-importedmodelkmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImportedModelKmsKeyArn { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-modelimportjob.html#cfn-bedrock-modelimportjob-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public Union<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }

        /// <summary>
        /// ModelDataSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-modelimportjob.html#cfn-bedrock-modelimportjob-modeldatasource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ModelDataSource
        /// </summary>
        [Required]
        public Union<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource, BaseFunction>? ModelDataSource { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-modelimportjob.html#cfn-bedrock-modelimportjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-modelimportjob.html#cfn-bedrock-modelimportjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ModelImportJobTypes
    {
        public class ModelDataSource : Humidifier.Base.BaseSubResource, IHaveBedrockModelImportJobTypesS3DataSourceS3DataSource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelimportjob-modeldatasource.html#cfn-bedrock-modelimportjob-modeldatasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public Union<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource, BaseFunction>? S3DataSource { get; set; }
        }

        public class S3DataSource : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelimportjob-s3datasource.html#cfn-bedrock-modelimportjob-s3datasource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelimportjob-vpcconfig.html#cfn-bedrock-modelimportjob-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelimportjob-vpcconfig.html#cfn-bedrock-modelimportjob-vpcconfig-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }
    }
}