namespace Humidifier.Outposts
{
    using global::System.Collections.Generic;
    using SiteTypes;

    public class Site : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveNotes
    {
        public class Attributes
        {
            public static string SiteId =  "SiteId" ;
            public static string SiteArn =  "SiteArn" ;
        }

        public override string AWSTypeName { get => AWS.Outposts.Site; }
        /// <summary>
        /// RackPhysicalProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-site.html#cfn-outposts-site-rackphysicalproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RackPhysicalProperties
        /// </summary>
        public Humidifier.Outposts.SiteTypes.RackPhysicalProperties RackPhysicalProperties { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-site.html#cfn-outposts-site-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ShippingAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-site.html#cfn-outposts-site-shippingaddress
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Address
        /// </summary>
        public Humidifier.Outposts.SiteTypes.Address ShippingAddress { get; set; }
        /// <summary>
        /// Notes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-site.html#cfn-outposts-site-notes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Notes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-site.html#cfn-outposts-site-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OperatingAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-site.html#cfn-outposts-site-operatingaddress
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Address
        /// </summary>
        public Humidifier.Outposts.SiteTypes.Address OperatingAddress { get; set; }
    }

    namespace SiteTypes
    {
        public class Address : Humidifier.Base.BaseSubResource, IHaveCountryCode
        {
            /// <summary>
            /// AddressLine3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-addressline3
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AddressLine3 { get; set; }
            /// <summary>
            /// DistrictOrCounty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-districtorcounty
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DistrictOrCounty { get; set; }
            /// <summary>
            /// AddressLine2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-addressline2
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AddressLine2 { get; set; }
            /// <summary>
            /// StateOrRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-stateorregion
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StateOrRegion { get; set; }
            /// <summary>
            /// AddressLine1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-addressline1
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AddressLine1 { get; set; }
            /// <summary>
            /// Municipality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-municipality
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Municipality { get; set; }
            /// <summary>
            /// ContactPhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-contactphonenumber
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContactPhoneNumber { get; set; }
            /// <summary>
            /// PostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-postalcode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PostalCode { get; set; }
            /// <summary>
            /// City
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-city
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic City { get; set; }
            /// <summary>
            /// CountryCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-countrycode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CountryCode { get; set; }
            /// <summary>
            /// ContactName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-contactname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContactName { get; set; }
        }

        public class RackPhysicalProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OpticalStandard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-opticalstandard
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OpticalStandard { get; set; }
            /// <summary>
            /// PowerConnector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-powerconnector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PowerConnector { get; set; }
            /// <summary>
            /// PowerPhase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-powerphase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PowerPhase { get; set; }
            /// <summary>
            /// UplinkGbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-uplinkgbps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UplinkGbps { get; set; }
            /// <summary>
            /// MaximumSupportedWeightLbs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-maximumsupportedweightlbs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaximumSupportedWeightLbs { get; set; }
            /// <summary>
            /// PowerDrawKva
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-powerdrawkva
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PowerDrawKva { get; set; }
            /// <summary>
            /// UplinkCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-uplinkcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UplinkCount { get; set; }
            /// <summary>
            /// FiberOpticCableType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-fiberopticcabletype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FiberOpticCableType { get; set; }
            /// <summary>
            /// PowerFeedDrop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-powerfeeddrop
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PowerFeedDrop { get; set; }
        }
    }
}