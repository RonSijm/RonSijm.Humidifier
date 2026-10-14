namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using OwnerTypes;

    public class Owner : Humidifier.Base.BaseResource, IHaveDomainIdentifier
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
        public dynamic EntityType { get; set; }

        /// <summary>
        /// Owner_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-owner.html#cfn-datazone-owner-owner
        /// Required: True
        /// UpdateType: Immutable
        /// Type: OwnerProperties
        /// </summary>
        [Required]
        public Humidifier.DataZone.OwnerTypes.OwnerProperties Owner_ { get; set; }

        /// <summary>
        /// EntityIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-owner.html#cfn-datazone-owner-entityidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EntityIdentifier { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-owner.html#cfn-datazone-owner-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainIdentifier { get; set; }
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
            public dynamic GroupIdentifier { get; set; }
        }

        public class OwnerProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Group
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-owner-ownerproperties.html#cfn-datazone-owner-ownerproperties-group
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OwnerGroupProperties
            /// </summary>
            public Humidifier.DataZone.OwnerTypes.OwnerGroupProperties Group { get; set; }
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-owner-ownerproperties.html#cfn-datazone-owner-ownerproperties-user
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OwnerUserProperties
            /// </summary>
            public Humidifier.DataZone.OwnerTypes.OwnerUserProperties User { get; set; }
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
            public dynamic UserIdentifier { get; set; }
        }
    }
}