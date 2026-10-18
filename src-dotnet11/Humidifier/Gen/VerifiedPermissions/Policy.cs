namespace Humidifier.VerifiedPermissions
{
    using global::System.Collections.Generic;
    using PolicyTypes;

    public class Policy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveVerifiedPermissionsPolicyTypesPolicyDefinitionDefinition, IHavePolicyStoreId, IHaveName
    {
        public class Attributes
        {
            public static string PolicyType =  "PolicyType" ;
            public static string PolicyId =  "PolicyId" ;
        }

        public override string AWSTypeName { get => AWS.VerifiedPermissions.Policy; }

        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policy.html#cfn-verifiedpermissions-policy-definition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: PolicyDefinition
        /// </summary>
        [Required]
        public Union<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition, BaseFunction>? Definition { get; set; }

        /// <summary>
        /// PolicyStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policy.html#cfn-verifiedpermissions-policy-policystoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyStoreId { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PolicyTypes
    {
        public class EntityIdentifier : Humidifier.Base.BaseSubResource, IHaveEntityType, IHaveEntityId
        {
            /// <summary>
            /// EntityType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-entityidentifier.html#cfn-verifiedpermissions-policy-entityidentifier-entitytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityType { get; set; }
            /// <summary>
            /// EntityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-entityidentifier.html#cfn-verifiedpermissions-policy-entityidentifier-entityid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityId { get; set; }
        }

        public class PolicyDefinition : Humidifier.Base.BaseSubResource, IHaveVerifiedPermissionsPolicyTypesStaticPolicyDefinitionStatic, IHaveVerifiedPermissionsPolicyTypesTemplateLinkedPolicyDefinitionTemplateLinked
        {
            /// <summary>
            /// Static
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-policydefinition.html#cfn-verifiedpermissions-policy-policydefinition-static
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticPolicyDefinition
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition, BaseFunction>? Static { get; set; }
            /// <summary>
            /// TemplateLinked
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-policydefinition.html#cfn-verifiedpermissions-policy-policydefinition-templatelinked
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateLinkedPolicyDefinition
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition, BaseFunction>? TemplateLinked { get; set; }
        }

        public class StaticPolicyDefinition : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveStatement
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-staticpolicydefinition.html#cfn-verifiedpermissions-policy-staticpolicydefinition-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-staticpolicydefinition.html#cfn-verifiedpermissions-policy-staticpolicydefinition-statement
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Statement { get; set; }
        }

        public class TemplateLinkedPolicyDefinition : Humidifier.Base.BaseSubResource, IHaveVerifiedPermissionsPolicyTypesEntityIdentifierResource, IHavePolicyTemplateId, IHaveVerifiedPermissionsPolicyTypesEntityIdentifierPrincipal
        {
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-templatelinkedpolicydefinition.html#cfn-verifiedpermissions-policy-templatelinkedpolicydefinition-resource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EntityIdentifier
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier, BaseFunction>? Resource { get; set; }
            /// <summary>
            /// PolicyTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-templatelinkedpolicydefinition.html#cfn-verifiedpermissions-policy-templatelinkedpolicydefinition-policytemplateid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyTemplateId { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-templatelinkedpolicydefinition.html#cfn-verifiedpermissions-policy-templatelinkedpolicydefinition-principal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EntityIdentifier
            /// </summary>
            public Union<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier, BaseFunction>? Principal { get; set; }
        }
    }
}