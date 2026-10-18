namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;
    using IdNamespaceAssociationTypes;

    public class IdNamespaceAssociation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCleanRoomsIdNamespaceAssociationTypesIdMappingConfigIdMappingConfig, IHaveMembershipIdentifier, IHaveDescription, IHaveCleanRoomsIdNamespaceAssociationTypesIdNamespaceAssociationInputReferenceConfigInputReferenceConfig, IHaveName
    {
        public class Attributes
        {
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string MembershipArn =  "MembershipArn" ;
            public static string InputReferenceProperties =  "InputReferenceProperties" ;
            public static string Arn =  "Arn" ;
            public static string IdNamespaceAssociationIdentifier =  "IdNamespaceAssociationIdentifier" ;
            public static string CollaborationArn =  "CollaborationArn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRooms.IdNamespaceAssociation; }
        /// <summary>
        /// IdMappingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-idnamespaceassociation.html#cfn-cleanrooms-idnamespaceassociation-idmappingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IdMappingConfig
        /// </summary>
        public Union<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdMappingConfig, BaseFunction>? IdMappingConfig { get; set; }

        /// <summary>
        /// MembershipIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-idnamespaceassociation.html#cfn-cleanrooms-idnamespaceassociation-membershipidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MembershipIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-idnamespaceassociation.html#cfn-cleanrooms-idnamespaceassociation-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InputReferenceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-idnamespaceassociation.html#cfn-cleanrooms-idnamespaceassociation-inputreferenceconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: IdNamespaceAssociationInputReferenceConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig, BaseFunction>? InputReferenceConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-idnamespaceassociation.html#cfn-cleanrooms-idnamespaceassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace IdNamespaceAssociationTypes
    {
        public class IdMappingConfig : Humidifier.Base.BaseSubResource, IHaveAllowUseAsDimensionColumn_Boolean
        {
            /// <summary>
            /// AllowUseAsDimensionColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-idnamespaceassociation-idmappingconfig.html#cfn-cleanrooms-idnamespaceassociation-idmappingconfig-allowuseasdimensioncolumn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowUseAsDimensionColumn { get; set; }
        }

        public class IdNamespaceAssociationInputReferenceConfig : Humidifier.Base.BaseSubResource, IHaveInputReferenceArn, IHaveManageResourcePolicies_Boolean
        {
            /// <summary>
            /// InputReferenceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-idnamespaceassociation-idnamespaceassociationinputreferenceconfig.html#cfn-cleanrooms-idnamespaceassociation-idnamespaceassociationinputreferenceconfig-inputreferencearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputReferenceArn { get; set; }
            /// <summary>
            /// ManageResourcePolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-idnamespaceassociation-idnamespaceassociationinputreferenceconfig.html#cfn-cleanrooms-idnamespaceassociation-idnamespaceassociationinputreferenceconfig-manageresourcepolicies
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ManageResourcePolicies { get; set; }
        }

        public class IdNamespaceAssociationInputReferenceProperties : Humidifier.Base.BaseSubResource, IHaveIdNamespaceType, IHaveJsonListOfIdMappingWorkflowsSupported
        {
            /// <summary>
            /// IdNamespaceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-idnamespaceassociation-idnamespaceassociationinputreferenceproperties.html#cfn-cleanrooms-idnamespaceassociation-idnamespaceassociationinputreferenceproperties-idnamespacetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdNamespaceType { get; set; }
            /// <summary>
            /// IdMappingWorkflowsSupported
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-idnamespaceassociation-idnamespaceassociationinputreferenceproperties.html#cfn-cleanrooms-idnamespaceassociation-idnamespaceassociationinputreferenceproperties-idmappingworkflowssupported
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Json
            /// </summary>
            public Union<IReadOnlyList<object>, IReadOnlyList<Union<object, BaseFunction>>, BaseFunction>? IdMappingWorkflowsSupported { get; set; }
        }
    }
}