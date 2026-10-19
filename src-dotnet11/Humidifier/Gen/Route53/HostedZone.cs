namespace Humidifier.Route53
{
    using global::System.Collections.Generic;
    using HostedZoneTypes;

    public class HostedZone : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDelegationSetId, IHaveListOfRoute53HostedZoneTypesHostedZoneTagHostedZoneTags, IHaveListOfRoute53HostedZoneTypesVPCVPCs, IHaveRoute53HostedZoneTypesHostedZoneFeaturesHostedZoneFeatures, IHaveRoute53HostedZoneTypesHostedZoneConfigHostedZoneConfig, IHaveRoute53HostedZoneTypesQueryLoggingConfigQueryLoggingConfig, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string NameServers =  "NameServers" ;
        }

        public override string AWSTypeName { get => AWS.Route53.HostedZone; }
        /// <summary>
        /// DelegationSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-delegationsetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DelegationSetId { get; set; }
        /// <summary>
        /// HostedZoneTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-hostedzonetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HostedZoneTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Route53.HostedZoneTypes.HostedZoneTag>, IReadOnlyList<Union<Humidifier.Route53.HostedZoneTypes.HostedZoneTag, BaseFunction>>, BaseFunction>? HostedZoneTags { get; set; }
        /// <summary>
        /// VPCs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-vpcs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VPC
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Route53.HostedZoneTypes.VPC>, IReadOnlyList<Union<Humidifier.Route53.HostedZoneTypes.VPC, BaseFunction>>, BaseFunction>? VPCs { get; set; }
        /// <summary>
        /// HostedZoneFeatures
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-hostedzonefeatures
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HostedZoneFeatures
        /// </summary>
        public Union<Humidifier.Route53.HostedZoneTypes.HostedZoneFeatures, BaseFunction>? HostedZoneFeatures { get; set; }
        /// <summary>
        /// HostedZoneConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-hostedzoneconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HostedZoneConfig
        /// </summary>
        public Union<Humidifier.Route53.HostedZoneTypes.HostedZoneConfig, BaseFunction>? HostedZoneConfig { get; set; }
        /// <summary>
        /// QueryLoggingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-queryloggingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QueryLoggingConfig
        /// </summary>
        public Union<Humidifier.Route53.HostedZoneTypes.QueryLoggingConfig, BaseFunction>? QueryLoggingConfig { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace HostedZoneTypes
    {
        public class HostedZoneConfig : Humidifier.Base.BaseSubResource, IHaveComment
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-hostedzoneconfig.html#cfn-route53-hostedzone-hostedzoneconfig-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
        }

        public class HostedZoneFeatures : Humidifier.Base.BaseSubResource, IHaveEnableAcceleratedRecovery_Boolean
        {
            /// <summary>
            /// EnableAcceleratedRecovery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-hostedzonefeatures.html#cfn-route53-hostedzone-hostedzonefeatures-enableacceleratedrecovery
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableAcceleratedRecovery { get; set; }
        }

        public class HostedZoneTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-hostedzonetag.html#cfn-route53-hostedzone-hostedzonetag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-hostedzonetag.html#cfn-route53-hostedzone-hostedzonetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class QueryLoggingConfig : Humidifier.Base.BaseSubResource, IHaveCloudWatchLogsLogGroupArn
        {
            /// <summary>
            /// CloudWatchLogsLogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-queryloggingconfig.html#cfn-route53-hostedzone-queryloggingconfig-cloudwatchlogsloggrouparn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudWatchLogsLogGroupArn { get; set; }
        }

        public class VPC : Humidifier.Base.BaseSubResource, IHaveVPCRegion, IHaveVPCId
        {
            /// <summary>
            /// VPCRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-vpc.html#cfn-route53-hostedzone-vpc-vpcregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VPCRegion { get; set; }
            /// <summary>
            /// VPCId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-vpc.html#cfn-route53-hostedzone-vpc-vpcid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VPCId { get; set; }
        }
    }
}