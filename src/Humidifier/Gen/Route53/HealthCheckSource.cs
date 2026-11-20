namespace Humidifier.Route53
{
    using global::System.Collections.Generic;
    using HealthCheckSourceTypes;

    public class HealthCheckSource : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string HealthCheckSourceId =  "HealthCheckSourceId" ;
            public static string HealthCheckSourceStatus =  "HealthCheckSourceStatus" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Route53.HealthCheckSource; }

        /// <summary>
        /// HealthCheckSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthchecksource.html#cfn-route53-healthchecksource-healthchecksourceconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: HealthCheckSourceConfig
        /// </summary>
        [Required]
        public Humidifier.Route53.HealthCheckSourceTypes.HealthCheckSourceConfig HealthCheckSourceConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthchecksource.html#cfn-route53-healthchecksource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace HealthCheckSourceTypes
    {
        public class HealthCheckSourceConfig : Humidifier.Base.BaseSubResource, IHaveVpcId
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-healthchecksource-healthchecksourceconfig.html#cfn-route53-healthchecksource-healthchecksourceconfig-vpcid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcId { get; set; }
            /// <summary>
            /// SubnetConfigurationList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-healthchecksource-healthchecksourceconfig.html#cfn-route53-healthchecksource-healthchecksourceconfig-subnetconfigurationlist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SubnetConfiguration
            /// </summary>
            public List<Humidifier.Route53.HealthCheckSourceTypes.SubnetConfiguration> SubnetConfigurationList { get; set; }
        }

        public class SubnetConfiguration : Humidifier.Base.BaseSubResource, IHaveSubnetId, IHaveAvailabilityZoneId, IHaveSecurityGroupIdList
        {
            /// <summary>
            /// AvailabilityZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-healthchecksource-subnetconfiguration.html#cfn-route53-healthchecksource-subnetconfiguration-availabilityzoneid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZoneId { get; set; }
            /// <summary>
            /// SecurityGroupIdList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-healthchecksource-subnetconfiguration.html#cfn-route53-healthchecksource-subnetconfiguration-securitygroupidlist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIdList { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-healthchecksource-subnetconfiguration.html#cfn-route53-healthchecksource-subnetconfiguration-subnetid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId { get; set; }
        }
    }
}