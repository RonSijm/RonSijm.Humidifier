namespace Humidifier.SecurityHub
{
    using System.Collections.Generic;

    public class PolicyAssociation : Humidifier.Base.BaseResource, IHaveTargetType, IHaveTargetId
    {
        public class Attributes
        {
            public static string AssociationStatusMessage =  "AssociationStatusMessage" ;
            public static string AssociationType =  "AssociationType" ;
            public static string AssociationIdentifier =  "AssociationIdentifier" ;
            public static string AssociationStatus =  "AssociationStatus" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.PolicyAssociation; }

        /// <summary>
        /// ConfigurationPolicyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-policyassociation.html#cfn-securityhub-policyassociation-configurationpolicyid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConfigurationPolicyId { get; set; }

        /// <summary>
        /// TargetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-policyassociation.html#cfn-securityhub-policyassociation-targettype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TargetType { get; set; }

        /// <summary>
        /// TargetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-policyassociation.html#cfn-securityhub-policyassociation-targetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TargetId { get; set; }
    }
}