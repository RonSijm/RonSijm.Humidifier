namespace Humidifier.ECR
{
    using System.Collections.Generic;
    using ReplicationConfigurationTypes;

    public class ReplicationConfiguration : Humidifier.Base.BaseResource
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
        public Humidifier.ECR.ReplicationConfigurationTypes.ReplicationConfiguration ReplicationConfiguration_ { get; set; }
    }

    namespace ReplicationConfigurationTypes
    {
        public class ReplicationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationconfiguration.html#cfn-ecr-replicationconfiguration-replicationconfiguration-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicationRule
            /// </summary>
            public List<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationRule> Rules { get; set; }
        }

        public class ReplicationDestination : Humidifier.Base.BaseSubResource, IHaveRegion
        {
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationdestination.html#cfn-ecr-replicationconfiguration-replicationdestination-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// RegistryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationdestination.html#cfn-ecr-replicationconfiguration-replicationdestination-registryid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegistryId { get; set; }
        }

        public class ReplicationRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RepositoryFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationrule.html#cfn-ecr-replicationconfiguration-replicationrule-repositoryfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RepositoryFilter
            /// </summary>
            public List<Humidifier.ECR.ReplicationConfigurationTypes.RepositoryFilter> RepositoryFilters { get; set; }
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationrule.html#cfn-ecr-replicationconfiguration-replicationrule-destinations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicationDestination
            /// </summary>
            public List<Humidifier.ECR.ReplicationConfigurationTypes.ReplicationDestination> Destinations { get; set; }
        }

        public class RepositoryFilter : Humidifier.Base.BaseSubResource, IHaveFilterType
        {
            /// <summary>
            /// FilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-repositoryfilter.html#cfn-ecr-replicationconfiguration-repositoryfilter-filtertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterType { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-repositoryfilter.html#cfn-ecr-replicationconfiguration-repositoryfilter-filter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Filter { get; set; }
        }
    }
}