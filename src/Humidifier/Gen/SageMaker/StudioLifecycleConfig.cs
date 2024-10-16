namespace Humidifier.SageMaker
{
    using System.Collections.Generic;

    public class StudioLifecycleConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public class Attributes
        {
            public static string StudioLifecycleConfigArn =  "StudioLifecycleConfigArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.StudioLifecycleConfig; }

        /// <summary>
        /// StudioLifecycleConfigAppType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-studiolifecycleconfig.html#cfn-sagemaker-studiolifecycleconfig-studiolifecycleconfigapptype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StudioLifecycleConfigAppType { get; set; }
        public dynamic StudioLifecycleConfigName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// StudioLifecycleConfigContent
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-studiolifecycleconfig.html#cfn-sagemaker-studiolifecycleconfig-studiolifecycleconfigcontent
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StudioLifecycleConfigContent { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-studiolifecycleconfig.html#cfn-sagemaker-studiolifecycleconfig-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}