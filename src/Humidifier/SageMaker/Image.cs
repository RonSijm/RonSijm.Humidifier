namespace Humidifier.SageMaker
{
    using System.Collections.Generic;

    public class Image : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string ImageArn =  "ImageArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::Image";
            }
        }

        /// <summary>
        /// ImageName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-image.html#cfn-sagemaker-image-imagename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ImageName { get; set; }
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
        public dynamic ImageRoleArn { get; set; }
        /// <summary>
        /// ImageDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-image.html#cfn-sagemaker-image-imagedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ImageDescription { get; set; }
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