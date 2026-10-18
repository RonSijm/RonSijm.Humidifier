namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using OwnerTypes;

    public class Owner : Humidifier.Base.BaseResource, IHaveEntityType, IHaveDataZoneOwnerTypesOwnerPropertiesOwner_, IHaveEntityIdentifier, IHaveDomainIdentifier
    {
        public class Attributes
        {
            public static string OwnerType =  "OwnerType" ;
            public static string OwnerIdentifier =  "OwnerIdentifier" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.Owner; }

        /// <summary>
        /// EntityType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-owner.html#cfn-datazone-owner-entitytype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EntityType { get; set; }

        /// <summary>
        /// Owner_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-owner.html#cfn-datazone-owner-owner
        /// Required: True
        /// UpdateType: Immutable
        /// Type: OwnerProperties
        /// </summary>
        [Required]
        public Union<Humidifier.DataZone.OwnerTypes.OwnerProperties, BaseFunction>? Owner_ { get; set; }

        /// <summary>
        /// EntityIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-owner.html#cfn-datazone-owner-entityidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EntityIdentifier { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-owner.html#cfn-datazone-owner-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
    }

    namespace OwnerTypes
    {
        public class OwnerGroupProperties : Humidifier.Base.BaseSubResource, IHaveGroupIdentifier
        {
            /// <summary>
            /// GroupIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-owner-ownergroupproperties.html#cfn-datazone-owner-ownergroupproperties-groupidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupIdentifier { get; set; }
        }

        public class OwnerProperties : Humidifier.Base.BaseSubResource, IHaveDataZoneOwnerTypesOwnerGroupPropertiesGroup, IHaveDataZoneOwnerTypesOwnerUserPropertiesUser
        {
            /// <summary>
            /// Group
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-owner-ownerproperties.html#cfn-datazone-owner-ownerproperties-group
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OwnerGroupProperties
            /// </summary>
            public Union<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties, BaseFunction>? Group { get; set; }
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-owner-ownerproperties.html#cfn-datazone-owner-ownerproperties-user
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OwnerUserProperties
            /// </summary>
            public Union<Humidifier.DataZone.OwnerTypes.OwnerUserProperties, BaseFunction>? User { get; set; }
        }

        public class OwnerUserProperties : Humidifier.Base.BaseSubResource, IHaveUserIdentifier
        {
            /// <summary>
            /// UserIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-owner-owneruserproperties.html#cfn-datazone-owner-owneruserproperties-useridentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserIdentifier { get; set; }
        }
    }
}