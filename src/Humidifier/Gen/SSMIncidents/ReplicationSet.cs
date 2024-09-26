namespace Humidifier.SSMIncidents
{
    using System.Collections.Generic;
    using ReplicationSetTypes;

    public class ReplicationSet : Humidifier.Base.BaseResource, IHaveTags
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
        public List<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> Regions { get; set; }
        /// <summary>
        /// DeletionProtected
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-replicationset.html#cfn-ssmincidents-replicationset-deletionprotected
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeletionProtected { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-replicationset.html#cfn-ssmincidents-replicationset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ReplicationSetTypes
    {
        public class RegionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SseKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-replicationset-regionconfiguration.html#cfn-ssmincidents-replicationset-regionconfiguration-ssekmskeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SseKmsKeyId { get; set; }
        }

        public class ReplicationRegion : Humidifier.Base.BaseSubResource, IHaveRegionName
        {
            /// <summary>
            /// RegionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-replicationset-replicationregion.html#cfn-ssmincidents-replicationset-replicationregion-regionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegionConfiguration
            /// </summary>
            public Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration RegionConfiguration { get; set; }
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-replicationset-replicationregion.html#cfn-ssmincidents-replicationset-replicationregion-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegionName { get; set; }
        }
    }
}