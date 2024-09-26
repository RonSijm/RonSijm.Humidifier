namespace Humidifier.Route53
{
    using System.Collections.Generic;
    using CidrCollectionTypes;

    public class CidrCollection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
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
        public List<Humidifier.Route53.CidrCollectionTypes.Location> Locations { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CidrCollectionTypes
    {
        public class Location : Humidifier.Base.BaseSubResource, IHaveLocationName
        {
            /// <summary>
            /// CidrList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-cidrcollection-location.html#cfn-route53-cidrcollection-location-cidrlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CidrList { get; set; }
            /// <summary>
            /// LocationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-cidrcollection-location.html#cfn-route53-cidrcollection-location-locationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocationName { get; set; }
        }
    }
}