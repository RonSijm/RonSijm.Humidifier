namespace Humidifier.VerifiedPermissions
{
    using global::System.Collections.Generic;

    public class PolicyStoreAlias : Humidifier.Base.BaseResource, IHaveAliasName, IHavePolicyStoreId
    {
        public override string AWSTypeName { get => AWS.VerifiedPermissions.PolicyStoreAlias; }

        /// <summary>
        /// AliasName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystorealias.html#cfn-verifiedpermissions-policystorealias-aliasname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AliasName { get; set; }

        /// <summary>
        /// PolicyStoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-verifiedpermissions-policystorealias.html#cfn-verifiedpermissions-policystorealias-policystoreid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyStoreId { get; set; }
    }
}