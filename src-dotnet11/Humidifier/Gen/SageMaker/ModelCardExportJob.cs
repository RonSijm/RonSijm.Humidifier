namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ModelCardExportJobTypes;

    public class ModelCardExportJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveModelCardExportJobName, IHaveModelCardName, IHaveSageMakerModelCardExportJobTypesModelCardExportOutputConfigOutputConfig, IHaveModelCardVersion_Integer
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastModifiedAt =  "LastModifiedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ExportArtifacts =  "ExportArtifacts" ;
            public static string ModelCardExportJobArn =  "ModelCardExportJobArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.ModelCardExportJob; }
        public Union<string, BaseFunction>? ModelCardExportJobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ModelCardName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelcardexportjob.html#cfn-sagemaker-modelcardexportjob-modelcardname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ModelCardName { get; set; }

        /// <summary>
        /// OutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelcardexportjob.html#cfn-sagemaker-modelcardexportjob-outputconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ModelCardExportOutputConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig, BaseFunction>? OutputConfig { get; set; }
        /// <summary>
        /// ModelCardVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelcardexportjob.html#cfn-sagemaker-modelcardexportjob-modelcardversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ModelCardVersion { get; set; }
    }

    namespace ModelCardExportJobTypes
    {
        public class ModelCardExportArtifacts : Humidifier.Base.BaseSubResource, IHaveS3ExportArtifacts
        {
            /// <summary>
            /// S3ExportArtifacts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcardexportjob-modelcardexportartifacts.html#cfn-sagemaker-modelcardexportjob-modelcardexportartifacts-s3exportartifacts
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ExportArtifacts { get; set; }
        }

        public class ModelCardExportOutputConfig : Humidifier.Base.BaseSubResource, IHaveS3OutputPath
        {
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelcardexportjob-modelcardexportoutputconfig.html#cfn-sagemaker-modelcardexportjob-modelcardexportoutputconfig-s3outputpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
        }
    }
}