namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using AppTypes;

    public class App : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomainId, IHaveUserProfileName, IHaveAppType
    {
        public class Attributes
        {
            public static string AppArn =  "AppArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.App; }

        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html#cfn-sagemaker-app-domainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainId { get; set; }
        /// <summary>
        /// ResourceSpec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html#cfn-sagemaker-app-resourcespec
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ResourceSpec
        /// </summary>
        public Humidifier.SageMaker.AppTypes.ResourceSpec ResourceSpec { get; set; }

        /// <summary>
        /// AppType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html#cfn-sagemaker-app-apptype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AppType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html#cfn-sagemaker-app-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// UserProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html#cfn-sagemaker-app-userprofilename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic UserProfileName { get; set; }
        public dynamic AppName { get => GivenName; set => GivenName = value; }
    }

    namespace AppTypes
    {
        public class ResourceSpec : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveLifecycleConfigArn, IHaveSageMakerImageArn, IHaveSageMakerImageVersionArn
        {
            /// <summary>
            /// LifecycleConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-app-resourcespec.html#cfn-sagemaker-app-resourcespec-lifecycleconfigarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LifecycleConfigArn { get; set; }
            /// <summary>
            /// SageMakerImageArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-app-resourcespec.html#cfn-sagemaker-app-resourcespec-sagemakerimagearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SageMakerImageArn { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-app-resourcespec.html#cfn-sagemaker-app-resourcespec-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// SageMakerImageVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-app-resourcespec.html#cfn-sagemaker-app-resourcespec-sagemakerimageversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SageMakerImageVersionArn { get; set; }
        }
    }
}