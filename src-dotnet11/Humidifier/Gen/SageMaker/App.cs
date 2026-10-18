namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using AppTypes;

    public class App : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRecoveryMode_Boolean, IHaveDomainId, IHaveSageMakerAppTypesResourceSpecResourceSpec, IHaveAppType, IHaveUserProfileName, IHaveAppName
    {
        public class Attributes
        {
            public static string AppArn =  "AppArn" ;
            public static string BuiltInLifecycleConfigArn =  "BuiltInLifecycleConfigArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.App; }
        /// <summary>
        /// RecoveryMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html#cfn-sagemaker-app-recoverymode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RecoveryMode { get; set; }

        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html#cfn-sagemaker-app-domainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainId { get; set; }
        /// <summary>
        /// ResourceSpec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html#cfn-sagemaker-app-resourcespec
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ResourceSpec
        /// </summary>
        public Union<Humidifier.SageMaker.AppTypes.ResourceSpec, BaseFunction>? ResourceSpec { get; set; }

        /// <summary>
        /// AppType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html#cfn-sagemaker-app-apptype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AppType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html#cfn-sagemaker-app-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// UserProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html#cfn-sagemaker-app-userprofilename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserProfileName { get; set; }
        public Union<string, BaseFunction>? AppName { get => GivenName; set => GivenName = value; }
    }

    namespace AppTypes
    {
        public class ResourceSpec : Humidifier.Base.BaseSubResource, IHaveLifecycleConfigArn, IHaveSageMakerImageArn, IHaveInstanceType, IHaveSageMakerImageVersionArn
        {
            /// <summary>
            /// LifecycleConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-app-resourcespec.html#cfn-sagemaker-app-resourcespec-lifecycleconfigarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LifecycleConfigArn { get; set; }
            /// <summary>
            /// SageMakerImageArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-app-resourcespec.html#cfn-sagemaker-app-resourcespec-sagemakerimagearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SageMakerImageArn { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-app-resourcespec.html#cfn-sagemaker-app-resourcespec-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// SageMakerImageVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-app-resourcespec.html#cfn-sagemaker-app-resourcespec-sagemakerimageversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SageMakerImageVersionArn { get; set; }
        }
    }
}