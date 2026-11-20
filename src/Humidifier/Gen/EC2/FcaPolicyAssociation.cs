namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class FcaPolicyAssociation : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ManagedBy =  "ManagedBy" ;
            public static string AssociatedAt =  "AssociatedAt" ;
            public static string ExpectedEffectiveAt =  "ExpectedEffectiveAt" ;
            public static string AssociationMode =  "AssociationMode" ;
            public static string OwnerAccount =  "OwnerAccount" ;
            public static string FcaPolicyAssociationId =  "FcaPolicyAssociationId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.FcaPolicyAssociation; }

        /// <summary>
        /// FcaPolicyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicyassociation.html#cfn-ec2-fcapolicyassociation-fcapolicyid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FcaPolicyId { get; set; }

        /// <summary>
        /// NetworkResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicyassociation.html#cfn-ec2-fcapolicyassociation-networkresourceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NetworkResourceId { get; set; }
        /// <summary>
        /// NetworkResourceScopeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicyassociation.html#cfn-ec2-fcapolicyassociation-networkresourcescopetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NetworkResourceScopeType { get; set; }
    }
}