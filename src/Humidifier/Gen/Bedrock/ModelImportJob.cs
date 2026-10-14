namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using ModelImportJobTypes;

    public class ModelImportJob : Humidifier.Base.BaseResource, IHaveTags, IHaveRoleArn
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
        public dynamic ImportedModelKmsKeyArn { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-modelimportjob.html#cfn-bedrock-modelimportjob-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public Humidifier.Bedrock.ModelImportJobTypes.VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// ModelDataSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-modelimportjob.html#cfn-bedrock-modelimportjob-modeldatasource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ModelDataSource
        /// </summary>
        [Required]
        public Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource ModelDataSource { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-modelimportjob.html#cfn-bedrock-modelimportjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-modelimportjob.html#cfn-bedrock-modelimportjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ModelImportJobTypes
    {
        public class ModelDataSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelimportjob-modeldatasource.html#cfn-bedrock-modelimportjob-modeldatasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public Humidifier.Bedrock.ModelImportJobTypes.S3DataSource S3DataSource { get; set; }
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
            public dynamic S3Uri { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelimportjob-vpcconfig.html#cfn-bedrock-modelimportjob-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-modelimportjob-vpcconfig.html#cfn-bedrock-modelimportjob-vpcconfig-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
        }
    }
}