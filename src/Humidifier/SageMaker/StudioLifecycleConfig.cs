namespace Humidifier.SageMaker
{
    using System.Collections.Generic;

    public class StudioLifecycleConfig : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string StudioLifecycleConfigArn =  "StudioLifecycleConfigArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::StudioLifecycleConfig";
            }
        }

        /// <summary>
        /// StudioLifecycleConfigAppType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-studiolifecycleconfig.html#cfn-sagemaker-studiolifecycleconfig-studiolifecycleconfigapptype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StudioLifecycleConfigAppType { get; set; }
        /// <summary>
        /// StudioLifecycleConfigName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-studiolifecycleconfig.html#cfn-sagemaker-studiolifecycleconfig-studiolifecycleconfigname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StudioLifecycleConfigName { get; set; }
        /// <summary>
        /// StudioLifecycleConfigContent
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-studiolifecycleconfig.html#cfn-sagemaker-studiolifecycleconfig-studiolifecycleconfigcontent
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
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