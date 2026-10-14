namespace Humidifier.NetworkFirewall
{
    using global::System.Collections.Generic;
    using ContainerAssociationTypes;

    public class ContainerAssociation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveType
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ResolvedCidrCount =  "ResolvedCidrCount" ;
            public static string ContainerAssociationArn =  "ContainerAssociationArn" ;
        }

        public override string AWSTypeName { get => AWS.NetworkFirewall.ContainerAssociation; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-containerassociation.html#cfn-networkfirewall-containerassociation-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        public dynamic ContainerAssociationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-containerassociation.html#cfn-networkfirewall-containerassociation-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ContainerMonitoringConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-containerassociation.html#cfn-networkfirewall-containerassociation-containermonitoringconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ContainerMonitoringConfiguration
        /// </summary>
        [Required]
        public List<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> ContainerMonitoringConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-containerassociation.html#cfn-networkfirewall-containerassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ContainerAssociationTypes
    {
        public class ContainerAttribute : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-containerassociation-containerattribute.html#cfn-networkfirewall-containerassociation-containerattribute-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-containerassociation-containerattribute.html#cfn-networkfirewall-containerassociation-containerattribute-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class ContainerMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveClusterArn
        {
            /// <summary>
            /// ClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-containerassociation-containermonitoringconfiguration.html#cfn-networkfirewall-containerassociation-containermonitoringconfiguration-clusterarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterArn { get; set; }
            /// <summary>
            /// AttributeFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-containerassociation-containermonitoringconfiguration.html#cfn-networkfirewall-containerassociation-containermonitoringconfiguration-attributefilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerAttribute
            /// </summary>
            public List<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerAttribute> AttributeFilters { get; set; }
        }
    }
}