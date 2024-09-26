namespace Humidifier.VerifiedPermissions
{
    using System.Collections.Generic;
    using PolicyTypes;

    public class Policy : Humidifier.Base.BaseResource, IHavePolicyStoreId
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
        public Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition Definition { get; set; }

        /// <summary>
        /// PolicyStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policy.html#cfn-verifiedpermissions-policy-policystoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PolicyStoreId { get; set; }
    }

    namespace PolicyTypes
    {
        public class EntityIdentifier : Humidifier.Base.BaseSubResource, IHaveEntityId
        {
            /// <summary>
            /// EntityType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-entityidentifier.html#cfn-verifiedpermissions-policy-entityidentifier-entitytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntityType { get; set; }
            /// <summary>
            /// EntityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-entityidentifier.html#cfn-verifiedpermissions-policy-entityidentifier-entityid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntityId { get; set; }
        }

        public class PolicyDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Static
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-policydefinition.html#cfn-verifiedpermissions-policy-policydefinition-static
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StaticPolicyDefinition
            /// </summary>
            public Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition Static { get; set; }
            /// <summary>
            /// TemplateLinked
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-policydefinition.html#cfn-verifiedpermissions-policy-policydefinition-templatelinked
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateLinkedPolicyDefinition
            /// </summary>
            public Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition TemplateLinked { get; set; }
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
            public dynamic Description { get; set; }
            /// <summary>
            /// Statement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-staticpolicydefinition.html#cfn-verifiedpermissions-policy-staticpolicydefinition-statement
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Statement { get; set; }
        }

        public class TemplateLinkedPolicyDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-templatelinkedpolicydefinition.html#cfn-verifiedpermissions-policy-templatelinkedpolicydefinition-resource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EntityIdentifier
            /// </summary>
            public Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier Resource { get; set; }
            /// <summary>
            /// PolicyTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-templatelinkedpolicydefinition.html#cfn-verifiedpermissions-policy-templatelinkedpolicydefinition-policytemplateid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyTemplateId { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-verifiedpermissions-policy-templatelinkedpolicydefinition.html#cfn-verifiedpermissions-policy-templatelinkedpolicydefinition-principal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EntityIdentifier
            /// </summary>
            public Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier Principal { get; set; }
        }
    }
}