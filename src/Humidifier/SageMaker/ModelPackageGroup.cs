namespace Humidifier.SageMaker
{
    using System.Collections.Generic;

    public class ModelPackageGroup : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string ModelPackageGroupArn =  "ModelPackageGroupArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ModelPackageGroupStatus =  "ModelPackageGroupStatus" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::ModelPackageGroup";
            }
        }

        /// <summary>
        /// ModelPackageGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackagegroup.html#cfn-sagemaker-modelpackagegroup-modelpackagegroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModelPackageGroupName { get; set; }
        /// <summary>
        /// ModelPackageGroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackagegroup.html#cfn-sagemaker-modelpackagegroup-modelpackagegroupdescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModelPackageGroupDescription { get; set; }
        /// <summary>
        /// ModelPackageGroupPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackagegroup.html#cfn-sagemaker-modelpackagegroup-modelpackagegrouppolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic ModelPackageGroupPolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackagegroup.html#cfn-sagemaker-modelpackagegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}