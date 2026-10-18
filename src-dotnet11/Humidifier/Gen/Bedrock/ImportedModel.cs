namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using ImportedModelTypes;

    public class ImportedModel : Humidifier.Base.BaseResource, IHaveModelName, IHaveJobName, IHaveBedrockImportedModelTypesModelDataSourceModelDataSource
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
        public Union<string, BaseFunction>? ModelName { get; set; }
        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-importedmodel.html#cfn-bedrock-importedmodel-jobname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobName { get; set; }
        /// <summary>
        /// ModelDataSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-importedmodel.html#cfn-bedrock-importedmodel-modeldatasource
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ModelDataSource
        /// </summary>
        public Union<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource, BaseFunction>? ModelDataSource { get; set; }
    }

    namespace ImportedModelTypes
    {
        public class CustomModelUnits : Humidifier.Base.BaseSubResource, IHaveCustomModelUnitsPerModelCopy_Integer, IHaveCustomModelUnitsVersion
        {
            /// <summary>
            /// CustomModelUnitsPerModelCopy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-importedmodel-custommodelunits.html#cfn-bedrock-importedmodel-custommodelunits-custommodelunitspermodelcopy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CustomModelUnitsPerModelCopy { get; set; }
            /// <summary>
            /// CustomModelUnitsVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-importedmodel-custommodelunits.html#cfn-bedrock-importedmodel-custommodelunits-custommodelunitsversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomModelUnitsVersion { get; set; }
        }

        public class ModelDataSource : Humidifier.Base.BaseSubResource, IHaveBedrockImportedModelTypesS3DataSourceS3DataSource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-importedmodel-modeldatasource.html#cfn-bedrock-importedmodel-modeldatasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public Union<Humidifier.Bedrock.ImportedModelTypes.S3DataSource, BaseFunction>? S3DataSource { get; set; }
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
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }
    }
}