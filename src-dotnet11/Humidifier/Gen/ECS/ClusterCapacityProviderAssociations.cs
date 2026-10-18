namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using ClusterCapacityProviderAssociationsTypes;

    public class ClusterCapacityProviderAssociations : Humidifier.Base.BaseResource, IHaveListOfECSClusterCapacityProviderAssociationsTypesCapacityProviderStrategyDefaultCapacityProviderStrategy, IHaveStringListOfCapacityProviders, IHaveCluster
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
        public Union<IReadOnlyList<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy>, IReadOnlyList<Union<Humidifier.ECS.ClusterCapacityProviderAssociationsTypes.CapacityProviderStrategy, BaseFunction>>, BaseFunction>? DefaultCapacityProviderStrategy { get; set; }
        /// <summary>
        /// CapacityProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-clustercapacityproviderassociations.html#cfn-ecs-clustercapacityproviderassociations-capacityproviders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CapacityProviders { get; set; }

        /// <summary>
        /// Cluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-clustercapacityproviderassociations.html#cfn-ecs-clustercapacityproviderassociations-cluster
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Cluster { get; set; }
    }

    namespace ClusterCapacityProviderAssociationsTypes
    {
        public class CapacityProviderStrategy : Humidifier.Base.BaseSubResource, IHaveCapacityProvider, IHaveBase_Integer, IHaveWeight_Integer
        {
            /// <summary>
            /// CapacityProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-clustercapacityproviderassociations-capacityproviderstrategy.html#cfn-ecs-clustercapacityproviderassociations-capacityproviderstrategy-capacityprovider
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProvider { get; set; }
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-clustercapacityproviderassociations-capacityproviderstrategy.html#cfn-ecs-clustercapacityproviderassociations-capacityproviderstrategy-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Base { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-clustercapacityproviderassociations-capacityproviderstrategy.html#cfn-ecs-clustercapacityproviderassociations-capacityproviderstrategy-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
        }
    }
}