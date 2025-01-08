namespace Humidifier.Route53
{
    using System.Collections.Generic;
    using RecordSetTypes;

    public class RecordSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveType, IHaveRegion, IHaveWeight, IHaveComment, IHaveHostedZoneId, IHaveTTL, IHaveHostedZoneName, IHaveFailover, IHaveHealthCheckId, IHaveMultiValueAnswer, IHaveResourceRecords, IHaveSetIdentifier
    {
        public override string AWSTypeName { get => AWS.Route53.RecordSet; }
        /// <summary>
        /// AliasTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-aliastarget
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AliasTarget
        /// </summary>
        public Humidifier.Route53.RecordSetTypes.AliasTarget AliasTarget { get; set; }
        /// <summary>
        /// CidrRoutingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-cidrroutingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CidrRoutingConfig
        /// </summary>
        public Humidifier.Route53.RecordSetTypes.CidrRoutingConfig CidrRoutingConfig { get; set; }
        /// <summary>
        /// Comment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-comment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Comment { get; set; }
        /// <summary>
        /// Failover
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-failover
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Failover { get; set; }
        /// <summary>
        /// GeoLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-geolocation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GeoLocation
        /// </summary>
        public Humidifier.Route53.RecordSetTypes.GeoLocation GeoLocation { get; set; }
        /// <summary>
        /// GeoProximityLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-geoproximitylocation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GeoProximityLocation
        /// </summary>
        public Humidifier.Route53.RecordSetTypes.GeoProximityLocation GeoProximityLocation { get; set; }
        /// <summary>
        /// HealthCheckId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-healthcheckid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HealthCheckId { get; set; }
        /// <summary>
        /// HostedZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-hostedzoneid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HostedZoneId { get; set; }
        /// <summary>
        /// HostedZoneName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-hostedzonename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HostedZoneName { get; set; }
        /// <summary>
        /// MultiValueAnswer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-multivalueanswer
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic MultiValueAnswer { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Region
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-region
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Region { get; set; }
        /// <summary>
        /// ResourceRecords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-resourcerecords
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ResourceRecords { get; set; }
        /// <summary>
        /// SetIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-setidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SetIdentifier { get; set; }
        /// <summary>
        /// TTL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-ttl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TTL { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// Weight
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-weight
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Weight { get; set; }
    }

    namespace RecordSetTypes
    {
        public class AliasTarget : Humidifier.Base.BaseSubResource, IHaveHostedZoneId, IHaveDNSName, IHaveEvaluateTargetHealth
        {
            /// <summary>
            /// DNSName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-dnshostname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DNSName { get; set; }
            /// <summary>
            /// EvaluateTargetHealth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-evaluatetargethealth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EvaluateTargetHealth { get; set; }
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-hostedzoneid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostedZoneId { get; set; }
        }

        public class CidrRoutingConfig : Humidifier.Base.BaseSubResource, IHaveLocationName, IHaveCollectionId
        {
            /// <summary>
            /// CollectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-cidrroutingconfig.html#cfn-route53-cidrroutingconfig-collectionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CollectionId { get; set; }
            /// <summary>
            /// LocationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-cidrroutingconfig.html#cfn-route53-cidrroutingconfig-locationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocationName { get; set; }
        }

        public class Coordinates : Humidifier.Base.BaseSubResource, IHaveLatitude, IHaveLongitude
        {
            /// <summary>
            /// Latitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-coordinates.html#cfn-route53-recordset-coordinates-latitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Latitude { get; set; }
            /// <summary>
            /// Longitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-coordinates.html#cfn-route53-recordset-coordinates-longitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Longitude { get; set; }
        }

        public class GeoLocation : Humidifier.Base.BaseSubResource, IHaveCountryCode, IHaveContinentCode, IHaveSubdivisionCode
        {
            /// <summary>
            /// ContinentCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-continentcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContinentCode { get; set; }
            /// <summary>
            /// CountryCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-countrycode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CountryCode { get; set; }
            /// <summary>
            /// SubdivisionCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-subdivisioncode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubdivisionCode { get; set; }
        }

        public class GeoProximityLocation : Humidifier.Base.BaseSubResource, IHaveAWSRegion, IHaveBias, IHaveLocalZoneGroup
        {
            /// <summary>
            /// AWSRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-geoproximitylocation.html#cfn-route53-geoproximitylocation-awsregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AWSRegion { get; set; }
            /// <summary>
            /// Bias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-geoproximitylocation.html#cfn-route53-geoproximitylocation-bias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Bias { get; set; }
            /// <summary>
            /// Coordinates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-geoproximitylocation.html#cfn-route53-geoproximitylocation-coordinates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Coordinates
            /// </summary>
            public Humidifier.Route53.RecordSetTypes.Coordinates Coordinates { get; set; }
            /// <summary>
            /// LocalZoneGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-geoproximitylocation.html#cfn-route53-geoproximitylocation-LocalZoneGroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalZoneGroup { get; set; }
        }
    }
}