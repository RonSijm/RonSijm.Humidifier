namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;

    public class ModelPackageGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveModelPackageGroupName, IHaveModelPackageGroupDescription, IHaveModelPackageGroupPolicy_Json, IHaveDescription
    {
        public class Attributes
        {
            public static string ModelPackageGroupArn =  "ModelPackageGroupArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ModelPackageGroupStatus =  "ModelPackageGroupStatus" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.ModelPackageGroup; }
        public Union<string, BaseFunction>? ModelPackageGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ModelPackageGroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackagegroup.html#cfn-sagemaker-modelpackagegroup-modelpackagegroupdescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModelPackageGroupDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ModelPackageGroupDescription; set => ModelPackageGroupDescription = value; }
        /// <summary>
        /// ModelPackageGroupPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackagegroup.html#cfn-sagemaker-modelpackagegroup-modelpackagegrouppolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? ModelPackageGroupPolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackagegroup.html#cfn-sagemaker-modelpackagegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}