namespace Humidifier.ECS
{
    using global::System.Collections.Generic;

    public class GatewayClusterAssociations : Humidifier.Base.BaseResource, IHaveGateway, IHaveCluster
    {
        public class Attributes
        {
            public static string GatewayArn =  "GatewayArn" ;
            public static string ClusterArn =  "ClusterArn" ;
            public static string Status =  "Status" ;
        }

        public override string AWSTypeName { get => AWS.ECS.GatewayClusterAssociations; }

        /// <summary>
        /// Gateway
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-gatewayclusterassociations.html#cfn-ecs-gatewayclusterassociations-gateway
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Gateway { get; set; }

        /// <summary>
        /// Cluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-gatewayclusterassociations.html#cfn-ecs-gatewayclusterassociations-cluster
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Cluster { get; set; }
    }
}