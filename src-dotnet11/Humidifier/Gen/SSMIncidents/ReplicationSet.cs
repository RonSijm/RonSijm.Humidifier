namespace Humidifier.SSMIncidents
{
    using global::System.Collections.Generic;
    using ReplicationSetTypes;

    public class ReplicationSet : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfSSMIncidentsReplicationSetTypesReplicationRegionRegions, IHaveDeletionProtected_Boolean
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SSMIncidents.ReplicationSet; }

        /// <summary>
        /// Regions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-replicationset.html#cfn-ssmincidents-replicationset-regions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ReplicationRegion
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion>, IReadOnlyList<Union<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion, BaseFunction>>, BaseFunction>? Regions { get; set; }
        /// <summary>
        /// DeletionProtected
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-replicationset.html#cfn-ssmincidents-replicationset-deletionprotected
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtected { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-replicationset.html#cfn-ssmincidents-replicationset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ReplicationSetTypes
    {
        public class RegionConfiguration : Humidifier.Base.BaseSubResource, IHaveSseKmsKeyId
        {
            /// <summary>
            /// SseKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-replicationset-regionconfiguration.html#cfn-ssmincidents-replicationset-regionconfiguration-ssekmskeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SseKmsKeyId { get; set; }
        }

        public class ReplicationRegion : Humidifier.Base.BaseSubResource, IHaveSSMIncidentsReplicationSetTypesRegionConfigurationRegionConfiguration, IHaveRegionName
        {
            /// <summary>
            /// RegionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-replicationset-replicationregion.html#cfn-ssmincidents-replicationset-replicationregion-regionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegionConfiguration
            /// </summary>
            public Union<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration, BaseFunction>? RegionConfiguration { get; set; }
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-replicationset-replicationregion.html#cfn-ssmincidents-replicationset-replicationregion-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
        }
    }
}