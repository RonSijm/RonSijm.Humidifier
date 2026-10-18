namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;

    public class MlflowApp : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveWeeklyMaintenanceWindowStart, IHaveArtifactStoreUri, IHaveRoleArn, IHaveModelRegistrationMode, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string MlflowVersion =  "MlflowVersion" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string MlflowAppId =  "MlflowAppId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.MlflowApp; }
        /// <summary>
        /// WeeklyMaintenanceWindowStart
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowapp.html#cfn-sagemaker-mlflowapp-weeklymaintenancewindowstart
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WeeklyMaintenanceWindowStart { get; set; }

        /// <summary>
        /// ArtifactStoreUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowapp.html#cfn-sagemaker-mlflowapp-artifactstoreuri
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ArtifactStoreUri { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowapp.html#cfn-sagemaker-mlflowapp-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// ModelRegistrationMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowapp.html#cfn-sagemaker-mlflowapp-modelregistrationmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModelRegistrationMode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowapp.html#cfn-sagemaker-mlflowapp-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}