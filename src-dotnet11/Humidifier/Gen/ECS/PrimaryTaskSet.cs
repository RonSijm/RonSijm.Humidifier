namespace Humidifier.ECS
{
    using global::System.Collections.Generic;

    public class PrimaryTaskSet : Humidifier.Base.BaseResource, IHaveTaskSetId, IHaveCluster, IHaveService
    {
        public override string AWSTypeName { get => AWS.ECS.PrimaryTaskSet; }

        /// <summary>
        /// TaskSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-primarytaskset.html#cfn-ecs-primarytaskset-tasksetid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TaskSetId { get; set; }

        /// <summary>
        /// Cluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-primarytaskset.html#cfn-ecs-primarytaskset-cluster
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Cluster { get; set; }

        /// <summary>
        /// Service
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-primarytaskset.html#cfn-ecs-primarytaskset-service
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Service { get; set; }
    }
}