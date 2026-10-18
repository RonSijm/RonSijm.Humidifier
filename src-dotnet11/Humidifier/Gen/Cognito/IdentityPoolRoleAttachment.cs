namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using IdentityPoolRoleAttachmentTypes;

    public class IdentityPoolRoleAttachment : Humidifier.Base.BaseResource, IHaveMapOfCognitoIdentityPoolRoleAttachmentTypesRoleMappingRoleMappings, IHaveIdentityPoolId, IHaveStringDictionaryOfRoles
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.Cognito.IdentityPoolRoleAttachment; }
        /// <summary>
        /// RoleMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html#cfn-cognito-identitypoolroleattachment-rolemappings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: RoleMapping
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.Cognito.IdentityPoolRoleAttachmentTypes.RoleMapping>, IReadOnlyDictionary<string, Union<Humidifier.Cognito.IdentityPoolRoleAttachmentTypes.RoleMapping, BaseFunction>>, BaseFunction>? RoleMappings { get; set; }

        /// <summary>
        /// IdentityPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html#cfn-cognito-identitypoolroleattachment-identitypoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IdentityPoolId { get; set; }
        /// <summary>
        /// Roles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypoolroleattachment.html#cfn-cognito-identitypoolroleattachment-roles
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Roles { get; set; }
    }

    namespace IdentityPoolRoleAttachmentTypes
    {
        public class MappingRule : Humidifier.Base.BaseSubResource, IHaveMatchType, IHaveValue, IHaveClaim, IHaveRoleARN
        {
            /// <summary>
            /// MatchType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-mappingrule.html#cfn-cognito-identitypoolroleattachment-mappingrule-matchtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchType { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-mappingrule.html#cfn-cognito-identitypoolroleattachment-mappingrule-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Claim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-mappingrule.html#cfn-cognito-identitypoolroleattachment-mappingrule-claim
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Claim { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-mappingrule.html#cfn-cognito-identitypoolroleattachment-mappingrule-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleARN { get; set; }
        }

        public class RoleMapping : Humidifier.Base.BaseSubResource, IHaveType, IHaveAmbiguousRoleResolution, IHaveCognitoIdentityPoolRoleAttachmentTypesRulesConfigurationTypeRulesConfiguration, IHaveIdentityProvider
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-rolemapping.html#cfn-cognito-identitypoolroleattachment-rolemapping-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// AmbiguousRoleResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-rolemapping.html#cfn-cognito-identitypoolroleattachment-rolemapping-ambiguousroleresolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmbiguousRoleResolution { get; set; }
            /// <summary>
            /// RulesConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-rolemapping.html#cfn-cognito-identitypoolroleattachment-rolemapping-rulesconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RulesConfigurationType
            /// </summary>
            public Union<Humidifier.Cognito.IdentityPoolRoleAttachmentTypes.RulesConfigurationType, BaseFunction>? RulesConfiguration { get; set; }
            /// <summary>
            /// IdentityProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-rolemapping.html#cfn-cognito-identitypoolroleattachment-rolemapping-identityprovider
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityProvider { get; set; }
        }

        public class RulesConfigurationType : Humidifier.Base.BaseSubResource, IHaveListOfCognitoIdentityPoolRoleAttachmentTypesMappingRuleRules
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-rulesconfigurationtype.html#cfn-cognito-identitypoolroleattachment-rulesconfigurationtype-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MappingRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Cognito.IdentityPoolRoleAttachmentTypes.MappingRule>, IReadOnlyList<Union<Humidifier.Cognito.IdentityPoolRoleAttachmentTypes.MappingRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }
    }
}