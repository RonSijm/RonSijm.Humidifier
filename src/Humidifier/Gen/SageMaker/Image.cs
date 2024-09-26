namespace Humidifier.SageMaker
{
    using System.Collections.Generic;

    public class Image : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveImageName, IHaveDescription
    {
        public class Attributes
        {
            public static string ImageArn =  "ImageArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Image; }
        public dynamic ImageName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ImageDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-image.html#cfn-sagemaker-image-imagedisplayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ImageDisplayName { get; set; }

        /// <summary>
        /// ImageRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-image.html#cfn-sagemaker-image-imagerolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ImageRoleArn { get; set; }
        /// <summary>
        /// ImageDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-image.html#cfn-sagemaker-image-imagedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ImageDescription { get; set; }

        [Ignore]
        public dynamic Description { get => ImageDescription; set => ImageDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-image.html#cfn-sagemaker-image-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}