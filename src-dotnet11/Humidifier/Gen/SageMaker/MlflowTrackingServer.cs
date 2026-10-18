namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;

    public class MlflowTrackingServer : Humidifier.Base.BaseResource, IHaveTags, IHaveTrackingServerName, IHaveMlflowVersion, IHaveWeeklyMaintenanceWindowStart, IHaveTrackingServerSize, IHaveArtifactStoreUri, IHaveAutomaticModelRegistration_Boolean, IHaveRoleArn
    {
        public class Attributes
        {
            public static string TrackingServerArn =  "TrackingServerArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.MlflowTrackingServer; }

        /// <summary>
        /// TrackingServerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowtrackingserver.html#cfn-sagemaker-mlflowtrackingserver-trackingservername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TrackingServerName { get; set; }
        /// <summary>
        /// MlflowVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowtrackingserver.html#cfn-sagemaker-mlflowtrackingserver-mlflowversion
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MlflowVersion { get; set; }
        /// <summary>
        /// WeeklyMaintenanceWindowStart
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowtrackingserver.html#cfn-sagemaker-mlflowtrackingserver-weeklymaintenancewindowstart
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WeeklyMaintenanceWindowStart { get; set; }
        /// <summary>
        /// TrackingServerSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowtrackingserver.html#cfn-sagemaker-mlflowtrackingserver-trackingserversize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TrackingServerSize { get; set; }

        /// <summary>
        /// ArtifactStoreUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowtrackingserver.html#cfn-sagemaker-mlflowtrackingserver-artifactstoreuri
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ArtifactStoreUri { get; set; }
        /// <summary>
        /// AutomaticModelRegistration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowtrackingserver.html#cfn-sagemaker-mlflowtrackingserver-automaticmodelregistration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutomaticModelRegistration { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowtrackingserver.html#cfn-sagemaker-mlflowtrackingserver-rolearn
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-mlflowtrackingserver.html#cfn-sagemaker-mlflowtrackingserver-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}