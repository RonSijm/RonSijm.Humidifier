namespace Humidifier.IdentityStore
{
    using global::System.Collections.Generic;
    using UserTypes;

    public class User : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTitle, IHaveDisplayName, IHaveUserName, IHaveTimezone, IHaveIdentityStoreId, IHaveLocale
    {
        public class Attributes
        {
            public static string UpdatedBy =  "UpdatedBy" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string UserId =  "UserId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UserStatus =  "UserStatus" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.IdentityStore.User; }
        /// <summary>
        /// Locale
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-locale
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Locale { get; set; }
        /// <summary>
        /// Timezone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-timezone
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Timezone { get; set; }
        /// <summary>
        /// PhoneNumbers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-phonenumbers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: PhoneNumbersItems
        /// </summary>
        public List<Humidifier.IdentityStore.UserTypes.PhoneNumbersItems> PhoneNumbers { get; set; }
        public dynamic UserName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Website
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-website
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Website { get; set; }
        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-title
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Title { get; set; }

        /// <summary>
        /// IdentityStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-identitystoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IdentityStoreId { get; set; }
        /// <summary>
        /// Roles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-roles
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: RolesItems
        /// </summary>
        public List<Humidifier.IdentityStore.UserTypes.RolesItems> Roles { get; set; }
        /// <summary>
        /// NickName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-nickname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NickName { get; set; }
        /// <summary>
        /// Birthdate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-birthdate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Birthdate { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Addresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-addresses
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AddressesItems
        /// </summary>
        public List<Humidifier.IdentityStore.UserTypes.AddressesItems> Addresses { get; set; }
        /// <summary>
        /// Photos
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-photos
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: PhotosItems
        /// </summary>
        public List<Humidifier.IdentityStore.UserTypes.PhotosItems> Photos { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// PreferredLanguage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-preferredlanguage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PreferredLanguage { get; set; }
        /// <summary>
        /// Emails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-emails
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: EmailsItems
        /// </summary>
        public List<Humidifier.IdentityStore.UserTypes.EmailsItems> Emails { get; set; }
        /// <summary>
        /// UserType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-usertype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UserType { get; set; }
        /// <summary>
        /// ProfileUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-identitystore-user.html#cfn-identitystore-user-profileurl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProfileUrl { get; set; }
    }

    namespace UserTypes
    {
        public class AddressesItems : Humidifier.Base.BaseSubResource, IHaveType, IHaveRegion, IHavePrimary, IHaveCountry, IHaveLocality
        {
            /// <summary>
            /// Formatted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-addressesitems.html#cfn-identitystore-user-addressesitems-formatted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Formatted { get; set; }
            /// <summary>
            /// StreetAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-addressesitems.html#cfn-identitystore-user-addressesitems-streetaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreetAddress { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-addressesitems.html#cfn-identitystore-user-addressesitems-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Locality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-addressesitems.html#cfn-identitystore-user-addressesitems-locality
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Locality { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-addressesitems.html#cfn-identitystore-user-addressesitems-primary
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Primary { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-addressesitems.html#cfn-identitystore-user-addressesitems-region
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// PostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-addressesitems.html#cfn-identitystore-user-addressesitems-postalcode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PostalCode { get; set; }
            /// <summary>
            /// Country
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-addressesitems.html#cfn-identitystore-user-addressesitems-country
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Country { get; set; }
        }

        public class EmailsItems : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue, IHavePrimary
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-emailsitems.html#cfn-identitystore-user-emailsitems-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-emailsitems.html#cfn-identitystore-user-emailsitems-primary
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Primary { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-emailsitems.html#cfn-identitystore-user-emailsitems-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class Name : Humidifier.Base.BaseSubResource, IHaveGivenName
        {
            /// <summary>
            /// Formatted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-name.html#cfn-identitystore-user-name-formatted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Formatted { get; set; }
            /// <summary>
            /// HonorificSuffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-name.html#cfn-identitystore-user-name-honorificsuffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HonorificSuffix { get; set; }
            /// <summary>
            /// FamilyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-name.html#cfn-identitystore-user-name-familyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FamilyName { get; set; }
            /// <summary>
            /// GivenName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-name.html#cfn-identitystore-user-name-givenname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GivenName { get; set; }
            /// <summary>
            /// MiddleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-name.html#cfn-identitystore-user-name-middlename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MiddleName { get; set; }
            /// <summary>
            /// HonorificPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-name.html#cfn-identitystore-user-name-honorificprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HonorificPrefix { get; set; }
        }

        public class PhoneNumbersItems : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue, IHavePrimary
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-phonenumbersitems.html#cfn-identitystore-user-phonenumbersitems-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-phonenumbersitems.html#cfn-identitystore-user-phonenumbersitems-primary
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Primary { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-phonenumbersitems.html#cfn-identitystore-user-phonenumbersitems-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class PhotosItems : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue, IHavePrimary
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-photositems.html#cfn-identitystore-user-photositems-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-photositems.html#cfn-identitystore-user-photositems-primary
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Primary { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-photositems.html#cfn-identitystore-user-photositems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Display
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-photositems.html#cfn-identitystore-user-photositems-display
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Display { get; set; }
        }

        public class RolesItems : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue, IHavePrimary
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-rolesitems.html#cfn-identitystore-user-rolesitems-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-rolesitems.html#cfn-identitystore-user-rolesitems-primary
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Primary { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-identitystore-user-rolesitems.html#cfn-identitystore-user-rolesitems-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }
    }
}