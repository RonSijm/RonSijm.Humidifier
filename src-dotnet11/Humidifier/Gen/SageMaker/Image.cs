namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;

    public class Image : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveImageName, IHaveImageDisplayName, IHaveImageRoleArn, IHaveImageDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string ImageArn =  "ImageArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Image; }
        public Union<string, BaseFunction>? ImageName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ImageDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-image.html#cfn-sagemaker-image-imagedisplayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageDisplayName { get; set; }

        /// <summary>
        /// ImageRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-image.html#cfn-sagemaker-image-imagerolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ImageRoleArn { get; set; }
        /// <summary>
        /// ImageDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-image.html#cfn-sagemaker-image-imagedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ImageDescription; set => ImageDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-image.html#cfn-sagemaker-image-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}