namespace Humidifier.VerifiedPermissions
{
    using global::System.Collections.Generic;

    public class PolicyTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveStatement, IHavePolicyStoreId, IHaveName
    {
        public class Attributes
        {
            public static string PolicyTemplateId =  "PolicyTemplateId" ;
        }

        public override string AWSTypeName { get => AWS.VerifiedPermissions.PolicyTemplate; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policytemplate.html#cfn-verifiedpermissions-policytemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Statement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policytemplate.html#cfn-verifiedpermissions-policytemplate-statement
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Statement { get; set; }

        /// <summary>
        /// PolicyStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policytemplate.html#cfn-verifiedpermissions-policytemplate-policystoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyStoreId { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}