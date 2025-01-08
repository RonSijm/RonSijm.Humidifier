namespace Humidifier.ECS
{
    using System.Collections.Generic;
    using ClusterCapacityProviderAssociationsTypes;

    public class ClusterCapacityProviderAssociations : Humidifier.Base.BaseResource, IHaveCluster, IHaveCapacityProviders
    {
        public override string AWSTypeName { get => AWS.ECS.ClusterCapacityProviderAssociations; }

        /// <summary>
        /// DefaultCapacityProviderStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-clustercapacityproviderassociations.html#cfn-ecs-clustercapacityproviderassociations-defaultcapacityproviderstrategy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CapacityProviderStrategy
        /// </summary>
        [Required]
        public List<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy> DefaultCapacityProviderStrategy { get; set; }

        /// <summary>
        /// CapacityProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-clustercapacityproviderassociations.html#cfn-ecs-clustercapacityproviderassociations-capacityproviders
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic CapacityProviders { get; set; }

        /// <summary>
        /// Cluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-clustercapacityproviderassociations.html#cfn-ecs-clustercapacityproviderassociations-cluster
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Cluster { get; set; }
    }

    namespace ClusterCapacityProviderAssociationsTypes
    {
        public class CapacityProviderStrategy : Humidifier.Base.BaseSubResource, IHaveWeight, IHaveBase, IHaveCapacityProvider
        {
            /// <summary>
            /// CapacityProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-clustercapacityproviderassociations-capacityproviderstrategy.html#cfn-ecs-clustercapacityproviderassociations-capacityproviderstrategy-capacityprovider
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityProvider { get; set; }
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-clustercapacityproviderassociations-capacityproviderstrategy.html#cfn-ecs-clustercapacityproviderassociations-capacityproviderstrategy-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Base { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-clustercapacityproviderassociations-capacityproviderstrategy.html#cfn-ecs-clustercapacityproviderassociations-capacityproviderstrategy-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Weight { get; set; }
        }
    }
}