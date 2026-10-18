namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;

    public class ImageVersion : Humidifier.Base.BaseResource, IHaveImageName, IHaveHorovod_Boolean, IHaveProcessor, IHaveJobType, IHaveAlias, IHaveProgrammingLang, IHaveVendorGuidance, IHaveMLFramework, IHaveStringListOfAliases, IHaveReleaseNotes, IHaveBaseImage
    {
        public class Attributes
        {
            public static string ImageVersionArn =  "ImageVersionArn" ;
            public static string Version =  "Version" ;
            public static string ContainerImage =  "ContainerImage" ;
            public static string ImageArn =  "ImageArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.ImageVersion; }

        /// <summary>
        /// ImageName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html#cfn-sagemaker-imageversion-imagename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ImageName { get; set; }
        /// <summary>
        /// Horovod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html#cfn-sagemaker-imageversion-horovod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Horovod { get; set; }
        /// <summary>
        /// Processor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html#cfn-sagemaker-imageversion-processor
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Processor { get; set; }
        /// <summary>
        /// JobType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html#cfn-sagemaker-imageversion-jobtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobType { get; set; }
        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html#cfn-sagemaker-imageversion-alias
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Alias { get; set; }
        /// <summary>
        /// ProgrammingLang
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html#cfn-sagemaker-imageversion-programminglang
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProgrammingLang { get; set; }
        /// <summary>
        /// VendorGuidance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html#cfn-sagemaker-imageversion-vendorguidance
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VendorGuidance { get; set; }
        /// <summary>
        /// MLFramework
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html#cfn-sagemaker-imageversion-mlframework
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MLFramework { get; set; }
        /// <summary>
        /// Aliases
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html#cfn-sagemaker-imageversion-aliases
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Aliases { get; set; }
        /// <summary>
        /// ReleaseNotes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html#cfn-sagemaker-imageversion-releasenotes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ReleaseNotes { get; set; }

        /// <summary>
        /// BaseImage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html#cfn-sagemaker-imageversion-baseimage
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BaseImage { get; set; }
    }
}