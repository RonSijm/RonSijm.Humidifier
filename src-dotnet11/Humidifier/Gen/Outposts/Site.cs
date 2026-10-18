namespace Humidifier.Outposts
{
    using global::System.Collections.Generic;
    using SiteTypes;

    public class Site : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveOutpostsSiteTypesRackPhysicalPropertiesRackPhysicalProperties, IHaveDescription, IHaveOutpostsSiteTypesAddressShippingAddress, IHaveNotes, IHaveName, IHaveOutpostsSiteTypesAddressOperatingAddress
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
        public Union<Humidifier.Outposts.SiteTypes.RackPhysicalProperties, BaseFunction>? RackPhysicalProperties { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-site.html#cfn-outposts-site-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ShippingAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-site.html#cfn-outposts-site-shippingaddress
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Address
        /// </summary>
        public Union<Humidifier.Outposts.SiteTypes.Address, BaseFunction>? ShippingAddress { get; set; }
        /// <summary>
        /// Notes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-site.html#cfn-outposts-site-notes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Notes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-site.html#cfn-outposts-site-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OperatingAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-site.html#cfn-outposts-site-operatingaddress
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Address
        /// </summary>
        public Union<Humidifier.Outposts.SiteTypes.Address, BaseFunction>? OperatingAddress { get; set; }
    }

    namespace SiteTypes
    {
        public class Address : Humidifier.Base.BaseSubResource, IHaveAddressLine3, IHaveDistrictOrCounty, IHaveAddressLine2, IHaveStateOrRegion, IHaveAddressLine1, IHaveMunicipality, IHaveContactPhoneNumber, IHavePostalCode, IHaveCity, IHaveCountryCode, IHaveContactName
        {
            /// <summary>
            /// AddressLine3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-addressline3
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddressLine3 { get; set; }
            /// <summary>
            /// DistrictOrCounty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-districtorcounty
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DistrictOrCounty { get; set; }
            /// <summary>
            /// AddressLine2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-addressline2
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddressLine2 { get; set; }
            /// <summary>
            /// StateOrRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-stateorregion
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StateOrRegion { get; set; }
            /// <summary>
            /// AddressLine1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-addressline1
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddressLine1 { get; set; }
            /// <summary>
            /// Municipality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-municipality
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Municipality { get; set; }
            /// <summary>
            /// ContactPhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-contactphonenumber
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContactPhoneNumber { get; set; }
            /// <summary>
            /// PostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-postalcode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PostalCode { get; set; }
            /// <summary>
            /// City
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-city
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? City { get; set; }
            /// <summary>
            /// CountryCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-countrycode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CountryCode { get; set; }
            /// <summary>
            /// ContactName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-address.html#cfn-outposts-site-address-contactname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContactName { get; set; }
        }

        public class RackPhysicalProperties : Humidifier.Base.BaseSubResource, IHaveOpticalStandard, IHavePowerConnector, IHavePowerPhase, IHaveUplinkGbps, IHaveMaximumSupportedWeightLbs, IHavePowerDrawKva, IHaveUplinkCount, IHaveFiberOpticCableType, IHavePowerFeedDrop
        {
            /// <summary>
            /// OpticalStandard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-opticalstandard
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OpticalStandard { get; set; }
            /// <summary>
            /// PowerConnector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-powerconnector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PowerConnector { get; set; }
            /// <summary>
            /// PowerPhase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-powerphase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PowerPhase { get; set; }
            /// <summary>
            /// UplinkGbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-uplinkgbps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UplinkGbps { get; set; }
            /// <summary>
            /// MaximumSupportedWeightLbs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-maximumsupportedweightlbs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaximumSupportedWeightLbs { get; set; }
            /// <summary>
            /// PowerDrawKva
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-powerdrawkva
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PowerDrawKva { get; set; }
            /// <summary>
            /// UplinkCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-uplinkcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UplinkCount { get; set; }
            /// <summary>
            /// FiberOpticCableType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-fiberopticcabletype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FiberOpticCableType { get; set; }
            /// <summary>
            /// PowerFeedDrop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-outposts-site-rackphysicalproperties.html#cfn-outposts-site-rackphysicalproperties-powerfeeddrop
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PowerFeedDrop { get; set; }
        }
    }
}