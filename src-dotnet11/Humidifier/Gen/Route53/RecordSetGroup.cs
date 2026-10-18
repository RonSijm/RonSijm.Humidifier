namespace Humidifier.Route53
{
    using global::System.Collections.Generic;
    using RecordSetGroupTypes;

    public class RecordSetGroup : Humidifier.Base.BaseResource, IHaveComment, IHaveHostedZoneId, IHaveHostedZoneName, IHaveListOfRoute53RecordSetGroupTypesRecordSetRecordSets
    {
        public override string AWSTypeName { get => AWS.Route53.RecordSetGroup; }
        /// <summary>
        /// Comment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetgroup.html#cfn-route53-recordsetgroup-comment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Comment { get; set; }
        /// <summary>
        /// HostedZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetgroup.html#cfn-route53-recordsetgroup-hostedzoneid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HostedZoneId { get; set; }
        /// <summary>
        /// HostedZoneName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetgroup.html#cfn-route53-recordsetgroup-hostedzonename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HostedZoneName { get; set; }
        /// <summary>
        /// RecordSets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetgroup.html#cfn-route53-recordsetgroup-recordsets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RecordSet
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Route53.RecordSetGroupTypes.RecordSet>, IReadOnlyList<Union<Humidifier.Route53.RecordSetGroupTypes.RecordSet, BaseFunction>>, BaseFunction>? RecordSets { get; set; }
    }

    namespace RecordSetGroupTypes
    {
        public class AliasTarget : Humidifier.Base.BaseSubResource, IHaveDNSName, IHaveEvaluateTargetHealth_Boolean, IHaveHostedZoneId
        {
            /// <summary>
            /// DNSName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-dnshostname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DNSName { get; set; }
            /// <summary>
            /// EvaluateTargetHealth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-evaluatetargethealth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EvaluateTargetHealth { get; set; }
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-hostedzoneid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostedZoneId { get; set; }
        }

        public class CidrRoutingConfig : Humidifier.Base.BaseSubResource, IHaveCollectionId, IHaveLocationName
        {
            /// <summary>
            /// CollectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-cidrroutingconfig.html#cfn-route53-cidrroutingconfig-collectionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CollectionId { get; set; }
            /// <summary>
            /// LocationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-cidrroutingconfig.html#cfn-route53-cidrroutingconfig-locationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocationName { get; set; }
        }

        public class Coordinates : Humidifier.Base.BaseSubResource, IHaveLatitude, IHaveLongitude
        {
            /// <summary>
            /// Latitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordsetgroup-coordinates.html#cfn-route53-recordsetgroup-coordinates-latitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Latitude { get; set; }
            /// <summary>
            /// Longitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordsetgroup-coordinates.html#cfn-route53-recordsetgroup-coordinates-longitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Longitude { get; set; }
        }

        public class GeoLocation : Humidifier.Base.BaseSubResource, IHaveContinentCode, IHaveCountryCode, IHaveSubdivisionCode
        {
            /// <summary>
            /// ContinentCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordsetgroup-geolocation-continentcode
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

        public class GeoProximityLocation : Humidifier.Base.BaseSubResource, IHaveAWSRegion, IHaveBias_Integer, IHaveRoute53RecordSetGroupTypesCoordinatesCoordinates, IHaveLocalZoneGroup
        {
            /// <summary>
            /// AWSRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-geoproximitylocation.html#cfn-route53-geoproximitylocation-awsregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AWSRegion { get; set; }
            /// <summary>
            /// Bias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-geoproximitylocation.html#cfn-route53-geoproximitylocation-bias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Bias { get; set; }
            /// <summary>
            /// Coordinates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-geoproximitylocation.html#cfn-route53-geoproximitylocation-coordinates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Coordinates
            /// </summary>
            public Union<Humidifier.Route53.RecordSetGroupTypes.Coordinates, BaseFunction>? Coordinates { get; set; }
            /// <summary>
            /// LocalZoneGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-geoproximitylocation.html#cfn-route53-geoproximitylocation-LocalZoneGroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalZoneGroup { get; set; }
        }

        public class RecordSet : Humidifier.Base.BaseSubResource, IHaveRoute53RecordSetGroupTypesAliasTargetAliasTarget, IHaveRoute53RecordSetGroupTypesCidrRoutingConfigCidrRoutingConfig, IHaveFailover, IHaveRoute53RecordSetGroupTypesGeoLocationGeoLocation, IHaveRoute53RecordSetGroupTypesGeoProximityLocationGeoProximityLocation, IHaveHealthCheckId, IHaveHostedZoneId, IHaveHostedZoneName, IHaveMultiValueAnswer_Boolean, IHaveName, IHaveRegion, IHaveStringListOfResourceRecords, IHaveSetIdentifier, IHaveTTL, IHaveType, IHaveWeight_Integer
        {
            /// <summary>
            /// AliasTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-aliastarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AliasTarget
            /// </summary>
            public Union<Humidifier.Route53.RecordSetGroupTypes.AliasTarget, BaseFunction>? AliasTarget { get; set; }
            /// <summary>
            /// CidrRoutingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-cidrroutingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CidrRoutingConfig
            /// </summary>
            public Union<Humidifier.Route53.RecordSetGroupTypes.CidrRoutingConfig, BaseFunction>? CidrRoutingConfig { get; set; }
            /// <summary>
            /// Failover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-failover
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Failover { get; set; }
            /// <summary>
            /// GeoLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-geolocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeoLocation
            /// </summary>
            public Union<Humidifier.Route53.RecordSetGroupTypes.GeoLocation, BaseFunction>? GeoLocation { get; set; }
            /// <summary>
            /// GeoProximityLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-geoproximitylocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GeoProximityLocation
            /// </summary>
            public Union<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation, BaseFunction>? GeoProximityLocation { get; set; }
            /// <summary>
            /// HealthCheckId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-healthcheckid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HealthCheckId { get; set; }
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-hostedzoneid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostedZoneId { get; set; }
            /// <summary>
            /// HostedZoneName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-hostedzonename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostedZoneName { get; set; }
            /// <summary>
            /// MultiValueAnswer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-multivalueanswer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MultiValueAnswer { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// ResourceRecords
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-resourcerecords
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceRecords { get; set; }
            /// <summary>
            /// SetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-setidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SetIdentifier { get; set; }
            /// <summary>
            /// TTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-ttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TTL { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
        }
    }
}