namespace Humidifier.Route53
{
    using global::System.Collections.Generic;
    using CidrCollectionTypes;

    public class CidrCollection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfRoute53CidrCollectionTypesLocationLocations, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Route53.CidrCollection; }
        /// <summary>
        /// Locations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-cidrcollection.html#cfn-route53-cidrcollection-locations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Location
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Route53.CidrCollectionTypes.Location>, IReadOnlyList<Union<Humidifier.Route53.CidrCollectionTypes.Location, BaseFunction>>, BaseFunction>? Locations { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CidrCollectionTypes
    {
        public class Location : Humidifier.Base.BaseSubResource, IHaveStringListOfCidrList, IHaveLocationName
        {
            /// <summary>
            /// CidrList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-cidrcollection-location.html#cfn-route53-cidrcollection-location-cidrlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CidrList { get; set; }
            /// <summary>
            /// LocationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-cidrcollection-location.html#cfn-route53-cidrcollection-location-locationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocationName { get; set; }
        }
    }
}