namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using ImportedModelTypes;

    public class ImportedModel : Humidifier.Base.BaseResource, IHaveModelName, IHaveJobName
    {
        public class Attributes
        {
            public static string ModelArn =  "ModelArn" ;
            public static string JobArn =  "JobArn" ;
            public static string CustomModelUnits =  "CustomModelUnits" ;
            public static string ModelArchitecture =  "ModelArchitecture" ;
            public static string InstructSupported =  "InstructSupported" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ModelKmsKeyArn =  "ModelKmsKeyArn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.ImportedModel; }
        /// <summary>
        /// ModelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-importedmodel.html#cfn-bedrock-importedmodel-modelname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModelName { get; set; }
        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-importedmodel.html#cfn-bedrock-importedmodel-jobname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobName { get; set; }
        /// <summary>
        /// ModelDataSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-importedmodel.html#cfn-bedrock-importedmodel-modeldatasource
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ModelDataSource
        /// </summary>
        public Humidifier.Bedrock.ImportedModelTypes.ModelDataSource ModelDataSource { get; set; }
    }

    namespace ImportedModelTypes
    {
        public class CustomModelUnits : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomModelUnitsPerModelCopy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-importedmodel-custommodelunits.html#cfn-bedrock-importedmodel-custommodelunits-custommodelunitspermodelcopy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CustomModelUnitsPerModelCopy { get; set; }
            /// <summary>
            /// CustomModelUnitsVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-importedmodel-custommodelunits.html#cfn-bedrock-importedmodel-custommodelunits-custommodelunitsversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomModelUnitsVersion { get; set; }
        }

        public class ModelDataSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-importedmodel-modeldatasource.html#cfn-bedrock-importedmodel-modeldatasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public Humidifier.Bedrock.ImportedModelTypes.S3DataSource S3DataSource { get; set; }
        }

        public class S3DataSource : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-importedmodel-s3datasource.html#cfn-bedrock-importedmodel-s3datasource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }
    }
}