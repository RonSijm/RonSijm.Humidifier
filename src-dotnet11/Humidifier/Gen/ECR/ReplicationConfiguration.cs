namespace Humidifier.ECR
{
    using global::System.Collections.Generic;
    using ReplicationConfigurationTypes;

    public class ReplicationConfiguration : Humidifier.Base.BaseResource, IHaveECRReplicationConfigurationTypesReplicationConfigurationReplicationConfiguration_
    {
        public class Attributes
        {
            public static string RegistryId =  "RegistryId" ;
        }

        public override string AWSTypeName { get => AWS.ECR.ReplicationConfiguration; }

        /// <summary>
        /// ReplicationConfiguration_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-replicationconfiguration.html#cfn-ecr-replicationconfiguration-replicationconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ReplicationConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration, BaseFunction>? ReplicationConfiguration_ { get; set; }
    }

    namespace ReplicationConfigurationTypes
    {
        public class ReplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfECRReplicationConfigurationTypesReplicationRuleRules
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationconfiguration.html#cfn-ecr-replicationconfiguration-replicationconfiguration-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicationRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule>, IReadOnlyList<Union<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class ReplicationDestination : Humidifier.Base.BaseSubResource, IHaveRegion, IHaveRegistryId
        {
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationdestination.html#cfn-ecr-replicationconfiguration-replicationdestination-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// RegistryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationdestination.html#cfn-ecr-replicationconfiguration-replicationdestination-registryid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegistryId { get; set; }
        }

        public class ReplicationRule : Humidifier.Base.BaseSubResource, IHaveListOfECRReplicationConfigurationTypesRepositoryFilterRepositoryFilters, IHaveListOfECRReplicationConfigurationTypesReplicationDestinationDestinations
        {
            /// <summary>
            /// RepositoryFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationrule.html#cfn-ecr-replicationconfiguration-replicationrule-repositoryfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RepositoryFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECR.ReplicationConfigurationTypes.RepositoryFilter>, IReadOnlyList<Union<Humidifier.ECR.ReplicationConfigurationTypes.RepositoryFilter, BaseFunction>>, BaseFunction>? RepositoryFilters { get; set; }
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationrule.html#cfn-ecr-replicationconfiguration-replicationrule-destinations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicationDestination
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationDestination>, IReadOnlyList<Union<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationDestination, BaseFunction>>, BaseFunction>? Destinations { get; set; }
        }

        public class RepositoryFilter : Humidifier.Base.BaseSubResource, IHaveFilterType, IHaveFilter
        {
            /// <summary>
            /// FilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-repositoryfilter.html#cfn-ecr-replicationconfiguration-repositoryfilter-filtertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterType { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-repositoryfilter.html#cfn-ecr-replicationconfiguration-repositoryfilter-filter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Filter { get; set; }
        }
    }
}