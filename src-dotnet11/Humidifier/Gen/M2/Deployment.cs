namespace Humidifier.M2
{
    using global::System.Collections.Generic;

    public class Deployment : Humidifier.Base.BaseResource, IHaveEnvironmentId, IHaveApplicationVersion_Integer, IHaveApplicationId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DeploymentId =  "DeploymentId" ;
        }

        public override string AWSTypeName { get => AWS.M2.Deployment; }

        /// <summary>
        /// EnvironmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-deployment.html#cfn-m2-deployment-environmentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EnvironmentId { get; set; }

        /// <summary>
        /// ApplicationVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-deployment.html#cfn-m2-deployment-applicationversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? ApplicationVersion { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-m2-deployment.html#cfn-m2-deployment-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }
    }
}