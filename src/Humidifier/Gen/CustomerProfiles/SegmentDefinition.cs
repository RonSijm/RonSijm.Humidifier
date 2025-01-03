namespace Humidifier.CustomerProfiles
{
    using System.Collections.Generic;
    using SegmentDefinitionTypes;

    public class SegmentDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveDisplayName, IHaveDomainName
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string SegmentDefinitionArn =  "SegmentDefinitionArn" ;
        }

        public override string AWSTypeName { get => AWS.CustomerProfiles.SegmentDefinition; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-segmentdefinition.html#cfn-customerprofiles-segmentdefinition-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-segmentdefinition.html#cfn-customerprofiles-segmentdefinition-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }

        /// <summary>
        /// SegmentGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-segmentdefinition.html#cfn-customerprofiles-segmentdefinition-segmentgroups
        /// Required: True
        /// UpdateType: Immutable
        /// Type: SegmentGroup
        /// </summary>
        [Required]
        public Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup SegmentGroups { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-segmentdefinition.html#cfn-customerprofiles-segmentdefinition-displayname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }
        public dynamic SegmentDefinitionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-segmentdefinition.html#cfn-customerprofiles-segmentdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace SegmentDefinitionTypes
    {
        public class AddressDimension : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-addressdimension.html#cfn-customerprofiles-segmentdefinition-addressdimension-state
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension State { get; set; }
            /// <summary>
            /// Country
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-addressdimension.html#cfn-customerprofiles-segmentdefinition-addressdimension-country
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension Country { get; set; }
            /// <summary>
            /// PostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-addressdimension.html#cfn-customerprofiles-segmentdefinition-addressdimension-postalcode
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension PostalCode { get; set; }
            /// <summary>
            /// City
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-addressdimension.html#cfn-customerprofiles-segmentdefinition-addressdimension-city
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension City { get; set; }
            /// <summary>
            /// County
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-addressdimension.html#cfn-customerprofiles-segmentdefinition-addressdimension-county
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension County { get; set; }
            /// <summary>
            /// Province
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-addressdimension.html#cfn-customerprofiles-segmentdefinition-addressdimension-province
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension Province { get; set; }
        }

        public class AttributeDimension : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// DimensionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-attributedimension.html#cfn-customerprofiles-segmentdefinition-attributedimension-dimensiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DimensionType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-attributedimension.html#cfn-customerprofiles-segmentdefinition-attributedimension-values
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class CalculatedAttributeDimension : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// DimensionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-calculatedattributedimension.html#cfn-customerprofiles-segmentdefinition-calculatedattributedimension-dimensiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DimensionType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-calculatedattributedimension.html#cfn-customerprofiles-segmentdefinition-calculatedattributedimension-values
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// ConditionOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-calculatedattributedimension.html#cfn-customerprofiles-segmentdefinition-calculatedattributedimension-conditionoverrides
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConditionOverrides
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ConditionOverrides ConditionOverrides { get; set; }
        }

        public class ConditionOverrides : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-conditionoverrides.html#cfn-customerprofiles-segmentdefinition-conditionoverrides-range
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RangeOverride
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.RangeOverride Range { get; set; }
        }

        public class DateDimension : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// DimensionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-datedimension.html#cfn-customerprofiles-segmentdefinition-datedimension-dimensiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DimensionType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-datedimension.html#cfn-customerprofiles-segmentdefinition-datedimension-values
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class Dimension : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CalculatedAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-dimension.html#cfn-customerprofiles-segmentdefinition-dimension-calculatedattributes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: CalculatedAttributeDimension
            /// </summary>
            public Dictionary<string, Humidifier.CustomerProfiles.SegmentDefinitionTypes.CalculatedAttributeDimension> CalculatedAttributes { get; set; }
            /// <summary>
            /// ProfileAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-dimension.html#cfn-customerprofiles-segmentdefinition-dimension-profileattributes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileAttributes
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileAttributes ProfileAttributes { get; set; }
        }

        public class ExtraLengthValueProfileDimension : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// DimensionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-extralengthvalueprofiledimension.html#cfn-customerprofiles-segmentdefinition-extralengthvalueprofiledimension-dimensiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DimensionType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-extralengthvalueprofiledimension.html#cfn-customerprofiles-segmentdefinition-extralengthvalueprofiledimension-values
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class Group : Humidifier.Base.BaseSubResource, IHaveType, IHaveSourceType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-group.html#cfn-customerprofiles-segmentdefinition-group-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-group.html#cfn-customerprofiles-segmentdefinition-group-sourcetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceType { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-group.html#cfn-customerprofiles-segmentdefinition-group-dimensions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Dimension
            /// </summary>
            public List<Humidifier.CustomerProfiles.SegmentDefinitionTypes.Dimension> Dimensions { get; set; }
            /// <summary>
            /// SourceSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-group.html#cfn-customerprofiles-segmentdefinition-group-sourcesegments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SourceSegment
            /// </summary>
            public List<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SourceSegment> SourceSegments { get; set; }
        }

        public class ProfileAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdditionalInformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-additionalinformation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ExtraLengthValueProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ExtraLengthValueProfileDimension AdditionalInformation { get; set; }
            /// <summary>
            /// BusinessName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-businessname
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension BusinessName { get; set; }
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-address
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AddressDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.AddressDimension Address { get; set; }
            /// <summary>
            /// FirstName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-firstname
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension FirstName { get; set; }
            /// <summary>
            /// PersonalEmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-personalemailaddress
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension PersonalEmailAddress { get; set; }
            /// <summary>
            /// BusinessEmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-businessemailaddress
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension BusinessEmailAddress { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-attributes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: AttributeDimension
            /// </summary>
            public Dictionary<string, Humidifier.CustomerProfiles.SegmentDefinitionTypes.AttributeDimension> Attributes_ { get; set; }
            /// <summary>
            /// MailingAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-mailingaddress
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AddressDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.AddressDimension MailingAddress { get; set; }
            /// <summary>
            /// BusinessPhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-businessphonenumber
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension BusinessPhoneNumber { get; set; }
            /// <summary>
            /// MiddleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-middlename
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension MiddleName { get; set; }
            /// <summary>
            /// MobilePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-mobilephonenumber
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension MobilePhoneNumber { get; set; }
            /// <summary>
            /// EmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-emailaddress
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension EmailAddress { get; set; }
            /// <summary>
            /// AccountNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-accountnumber
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension AccountNumber { get; set; }
            /// <summary>
            /// BillingAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-billingaddress
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AddressDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.AddressDimension BillingAddress { get; set; }
            /// <summary>
            /// GenderString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-genderstring
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension GenderString { get; set; }
            /// <summary>
            /// HomePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-homephonenumber
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension HomePhoneNumber { get; set; }
            /// <summary>
            /// ShippingAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-shippingaddress
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AddressDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.AddressDimension ShippingAddress { get; set; }
            /// <summary>
            /// PhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-phonenumber
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension PhoneNumber { get; set; }
            /// <summary>
            /// LastName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-lastname
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension LastName { get; set; }
            /// <summary>
            /// PartyTypeString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-partytypestring
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ProfileDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.ProfileDimension PartyTypeString { get; set; }
            /// <summary>
            /// BirthDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profileattributes.html#cfn-customerprofiles-segmentdefinition-profileattributes-birthdate
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DateDimension
            /// </summary>
            public Humidifier.CustomerProfiles.SegmentDefinitionTypes.DateDimension BirthDate { get; set; }
        }

        public class ProfileDimension : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// DimensionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profiledimension.html#cfn-customerprofiles-segmentdefinition-profiledimension-dimensiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DimensionType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-profiledimension.html#cfn-customerprofiles-segmentdefinition-profiledimension-values
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class RangeOverride : Humidifier.Base.BaseSubResource, IHaveUnit, IHaveEnd, IHaveStart
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-rangeoverride.html#cfn-customerprofiles-segmentdefinition-rangeoverride-start
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-rangeoverride.html#cfn-customerprofiles-segmentdefinition-rangeoverride-end
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic End { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-rangeoverride.html#cfn-customerprofiles-segmentdefinition-rangeoverride-unit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class SegmentGroup : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-segmentgroup.html#cfn-customerprofiles-segmentdefinition-segmentgroup-groups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Group
            /// </summary>
            public List<Humidifier.CustomerProfiles.SegmentDefinitionTypes.Group> Groups { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-segmentgroup.html#cfn-customerprofiles-segmentdefinition-segmentgroup-include
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Include { get; set; }
        }

        public class SourceSegment : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SegmentDefinitionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-segmentdefinition-sourcesegment.html#cfn-customerprofiles-segmentdefinition-sourcesegment-segmentdefinitionname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentDefinitionName { get; set; }
        }
    }
}