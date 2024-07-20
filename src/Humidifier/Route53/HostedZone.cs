namespace Humidifier.Route53
{
    using System.Collections.Generic;
    using HostedZoneTypes;

    public class HostedZone : Humidifier.Resource
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string NameServers =  "NameServers" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Route53::HostedZone";
            }
        }

        /// <summary>
        /// HostedZoneTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-hostedzonetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HostedZoneTag
        /// </summary>
        public List<HostedZoneTag> HostedZoneTags { get; set; }
        /// <summary>
        /// VPCs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-vpcs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VPC
        /// </summary>
        public List<VPC> VPCs { get; set; }
        /// <summary>
        /// HostedZoneConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-hostedzoneconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HostedZoneConfig
        /// </summary>
        public HostedZoneConfig HostedZoneConfig { get; set; }
        /// <summary>
        /// QueryLoggingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-queryloggingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QueryLoggingConfig
        /// </summary>
        public QueryLoggingConfig QueryLoggingConfig { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace HostedZoneTypes
    {
        public class HostedZoneConfig
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-hostedzoneconfig.html#cfn-route53-hostedzone-hostedzoneconfig-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comment { get; set; }
        }

        public class HostedZoneTag
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-hostedzonetag.html#cfn-route53-hostedzone-hostedzonetag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-hostedzonetag.html#cfn-route53-hostedzone-hostedzonetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class QueryLoggingConfig
        {
            /// <summary>
            /// CloudWatchLogsLogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-queryloggingconfig.html#cfn-route53-hostedzone-queryloggingconfig-cloudwatchlogsloggrouparn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudWatchLogsLogGroupArn { get; set; }
        }

        public class VPC
        {
            /// <summary>
            /// VPCRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-vpc.html#cfn-route53-hostedzone-vpc-vpcregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VPCRegion { get; set; }
            /// <summary>
            /// VPCId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-vpc.html#cfn-route53-hostedzone-vpc-vpcid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VPCId { get; set; }
        }
    }
}