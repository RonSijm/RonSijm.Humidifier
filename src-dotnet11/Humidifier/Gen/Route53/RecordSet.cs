namespace Humidifier.Route53
{
    using global::System.Collections.Generic;
    using RecordSetTypes;

    public class RecordSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveHealthCheckId, IHaveRoute53RecordSetTypesAliasTargetAliasTarget, IHaveComment, IHaveHostedZoneName, IHaveStringListOfResourceRecords, IHaveHostedZoneId, IHaveSetIdentifier, IHaveTTL, IHaveWeight_Integer, IHaveName, IHaveType, IHaveRoute53RecordSetTypesCidrRoutingConfigCidrRoutingConfig, IHaveFailover, IHaveRegion, IHaveRoute53RecordSetTypesGeoLocationGeoLocation, IHaveMultiValueAnswer_Boolean
    {
        public override string AWSTypeName { get => AWS.Route53.RecordSet; }
        /// <summary>
        /// HealthCheckId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-healthcheckid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HealthCheckId { get; set; }
        /// <summary>
        /// AliasTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-aliastarget
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AliasTarget
        /// </summary>
        public Union<Humidifier.Route53.RecordSetTypes.AliasTarget, BaseFunction>? AliasTarget { get; set; }
        /// <summary>
        /// Comment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-comment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Comment { get; set; }
        /// <summary>
        /// HostedZoneName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-hostedzonename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HostedZoneName { get; set; }
        /// <summary>
        /// ResourceRecords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-resourcerecords
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceRecords { get; set; }
        /// <summary>
        /// HostedZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-hostedzoneid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HostedZoneId { get; set; }
        /// <summary>
        /// SetIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-setidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SetIdentifier { get; set; }
        /// <summary>
        /// TTL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-ttl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TTL { get; set; }
        /// <summary>
        /// Weight
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-weight
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Weight { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// CidrRoutingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-cidrroutingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CidrRoutingConfig
        /// </summary>
        public Union<Humidifier.Route53.RecordSetTypes.CidrRoutingConfig, BaseFunction>? CidrRoutingConfig { get; set; }
        /// <summary>
        /// Failover
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-failover
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Failover { get; set; }
        /// <summary>
        /// Region
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-region
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Region { get; set; }
        /// <summary>
        /// GeoLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-geolocation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GeoLocation
        /// </summary>
        public Union<Humidifier.Route53.RecordSetTypes.GeoLocation, BaseFunction>? GeoLocation { get; set; }
        /// <summary>
        /// MultiValueAnswer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordset.html#cfn-route53-recordset-multivalueanswer
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? MultiValueAnswer { get; set; }
    }

    namespace RecordSetTypes
    {
        public class AliasTarget : Humidifier.Base.BaseSubResource, IHaveHostedZoneId, IHaveDNSName, IHaveEvaluateTargetHealth_Boolean
        {
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-aliastarget.html#cfn-route53-recordset-aliastarget-hostedzoneid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostedZoneId { get; set; }
            /// <summary>
            /// DNSName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-aliastarget.html#cfn-route53-recordset-aliastarget-dnsname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DNSName { get; set; }
            /// <summary>
            /// EvaluateTargetHealth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-aliastarget.html#cfn-route53-recordset-aliastarget-evaluatetargethealth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EvaluateTargetHealth { get; set; }
        }

        public class CidrRoutingConfig : Humidifier.Base.BaseSubResource, IHaveCollectionId, IHaveLocationName
        {
            /// <summary>
            /// CollectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-cidrroutingconfig.html#cfn-route53-recordset-cidrroutingconfig-collectionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CollectionId { get; set; }
            /// <summary>
            /// LocationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-cidrroutingconfig.html#cfn-route53-recordset-cidrroutingconfig-locationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocationName { get; set; }
        }

        public class GeoLocation : Humidifier.Base.BaseSubResource, IHaveContinentCode, IHaveCountryCode, IHaveSubdivisionCode
        {
            /// <summary>
            /// ContinentCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-continentcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContinentCode { get; set; }
            /// <summary>
            /// CountryCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-countrycode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CountryCode { get; set; }
            /// <summary>
            /// SubdivisionCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-subdivisioncode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubdivisionCode { get; set; }
        }
    }
}