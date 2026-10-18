namespace Humidifier.CustomerProfiles
{
    using global::System.Collections.Generic;
    using ObjectTypeTypes;

    public class ObjectType : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMaxProfileObjectCount_Integer, IHaveDescription, IHaveDomainName, IHaveEncryptionKey, IHaveExpirationDays_Integer, IHaveListOfCustomerProfilesObjectTypeTypesFieldMapFields, IHaveAllowProfileCreation_Boolean, IHaveSourcePriority_Integer, IHaveObjectTypeName, IHaveListOfCustomerProfilesObjectTypeTypesKeyMapKeys, IHaveSourceLastUpdatedTimestampFormat, IHaveTemplateId
    {
        public class Attributes
        {
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string MaxAvailableProfileObjectCount =  "MaxAvailableProfileObjectCount" ;
        }

        public override string AWSTypeName { get => AWS.CustomerProfiles.ObjectType; }
        /// <summary>
        /// MaxProfileObjectCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-maxprofileobjectcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxProfileObjectCount { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName { get; set; }
        /// <summary>
        /// EncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-encryptionkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionKey { get; set; }
        /// <summary>
        /// ExpirationDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-expirationdays
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ExpirationDays { get; set; }
        /// <summary>
        /// Fields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-fields
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FieldMap
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap>, IReadOnlyList<Union<Humidifier.CustomerProfiles.ObjectTypeTypes.FieldMap, BaseFunction>>, BaseFunction>? Fields { get; set; }
        /// <summary>
        /// AllowProfileCreation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-allowprofilecreation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AllowProfileCreation { get; set; }
        /// <summary>
        /// SourcePriority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-sourcepriority
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SourcePriority { get; set; }
        public Union<string, BaseFunction>? ObjectTypeName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Keys
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-keys
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: KeyMap
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap>, IReadOnlyList<Union<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap, BaseFunction>>, BaseFunction>? Keys { get; set; }
        /// <summary>
        /// SourceLastUpdatedTimestampFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-sourcelastupdatedtimestampformat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceLastUpdatedTimestampFormat { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TemplateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html#cfn-customerprofiles-objecttype-templateid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateId { get; set; }
    }

    namespace ObjectTypeTypes
    {
        public class FieldMap : Humidifier.Base.BaseSubResource, IHaveName, IHaveCustomerProfilesObjectTypeTypesObjectTypeFieldObjectTypeField
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-fieldmap.html#cfn-customerprofiles-objecttype-fieldmap-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// ObjectTypeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-fieldmap.html#cfn-customerprofiles-objecttype-fieldmap-objecttypefield
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ObjectTypeField
            /// </summary>
            public Union<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField, BaseFunction>? ObjectTypeField { get; set; }
        }

        public class KeyMap : Humidifier.Base.BaseSubResource, IHaveListOfCustomerProfilesObjectTypeTypesObjectTypeKeyObjectTypeKeyList, IHaveName
        {
            /// <summary>
            /// ObjectTypeKeyList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-keymap.html#cfn-customerprofiles-objecttype-keymap-objecttypekeylist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ObjectTypeKey
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeKey>, IReadOnlyList<Union<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeKey, BaseFunction>>, BaseFunction>? ObjectTypeKeyList { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-keymap.html#cfn-customerprofiles-objecttype-keymap-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ObjectTypeField : Humidifier.Base.BaseSubResource, IHaveTarget, IHaveContentType, IHaveSource
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-objecttypefield.html#cfn-customerprofiles-objecttype-objecttypefield-target
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-objecttypefield.html#cfn-customerprofiles-objecttype-objecttypefield-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-objecttypefield.html#cfn-customerprofiles-objecttype-objecttypefield-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class ObjectTypeKey : Humidifier.Base.BaseSubResource, IHaveStringListOfFieldNames, IHaveStringListOfStandardIdentifiers
        {
            /// <summary>
            /// FieldNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-objecttypekey.html#cfn-customerprofiles-objecttype-objecttypekey-fieldnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FieldNames { get; set; }
            /// <summary>
            /// StandardIdentifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-objecttypekey.html#cfn-customerprofiles-objecttype-objecttypekey-standardidentifiers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StandardIdentifiers { get; set; }
        }
    }
}