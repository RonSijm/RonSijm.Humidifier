namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;
    using IdMappingTableTypes;

    public class IdMappingTable : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMembershipIdentifier, IHaveDescription, IHaveKmsKeyArn, IHaveCleanRoomsIdMappingTableTypesIdMappingTableInputReferenceConfigInputReferenceConfig, IHaveName
    {
        public class Attributes
        {
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string MembershipArn =  "MembershipArn" ;
            public static string IdMappingTableIdentifier =  "IdMappingTableIdentifier" ;
            public static string InputReferenceProperties =  "InputReferenceProperties" ;
            public static string Arn =  "Arn" ;
            public static string CollaborationArn =  "CollaborationArn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRooms.IdMappingTable; }

        /// <summary>
        /// MembershipIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-idmappingtable.html#cfn-cleanrooms-idmappingtable-membershipidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MembershipIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-idmappingtable.html#cfn-cleanrooms-idmappingtable-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-idmappingtable.html#cfn-cleanrooms-idmappingtable-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }

        /// <summary>
        /// InputReferenceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-idmappingtable.html#cfn-cleanrooms-idmappingtable-inputreferenceconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: IdMappingTableInputReferenceConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputReferenceConfig, BaseFunction>? InputReferenceConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-idmappingtable.html#cfn-cleanrooms-idmappingtable-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace IdMappingTableTypes
    {
        public class IdMappingTableInputReferenceConfig : Humidifier.Base.BaseSubResource, IHaveInputReferenceArn, IHaveManageResourcePolicies_Boolean
        {
            /// <summary>
            /// InputReferenceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-idmappingtable-idmappingtableinputreferenceconfig.html#cfn-cleanrooms-idmappingtable-idmappingtableinputreferenceconfig-inputreferencearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputReferenceArn { get; set; }
            /// <summary>
            /// ManageResourcePolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-idmappingtable-idmappingtableinputreferenceconfig.html#cfn-cleanrooms-idmappingtable-idmappingtableinputreferenceconfig-manageresourcepolicies
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ManageResourcePolicies { get; set; }
        }

        public class IdMappingTableInputReferenceProperties : Humidifier.Base.BaseSubResource, IHaveListOfCleanRoomsIdMappingTableTypesIdMappingTableInputSourceIdMappingTableInputSource
        {
            /// <summary>
            /// IdMappingTableInputSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-idmappingtable-idmappingtableinputreferenceproperties.html#cfn-cleanrooms-idmappingtable-idmappingtableinputreferenceproperties-idmappingtableinputsource
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IdMappingTableInputSource
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputSource>, IReadOnlyList<Union<Humidifier.CleanRooms.IdMappingTableTypes.IdMappingTableInputSource, BaseFunction>>, BaseFunction>? IdMappingTableInputSource { get; set; }
        }

        public class IdMappingTableInputSource : Humidifier.Base.BaseSubResource, IHaveType, IHaveIdNamespaceAssociationId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-idmappingtable-idmappingtableinputsource.html#cfn-cleanrooms-idmappingtable-idmappingtableinputsource-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// IdNamespaceAssociationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-idmappingtable-idmappingtableinputsource.html#cfn-cleanrooms-idmappingtable-idmappingtableinputsource-idnamespaceassociationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdNamespaceAssociationId { get; set; }
        }
    }
}