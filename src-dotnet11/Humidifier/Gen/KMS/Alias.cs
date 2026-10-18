namespace Humidifier.KMS
{
    using global::System.Collections.Generic;

    public class Alias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTargetKeyId, IHaveAliasName
    {
        public override string AWSTypeName { get => AWS.KMS.Alias; }

        /// <summary>
        /// TargetKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-alias.html#cfn-kms-alias-targetkeyid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetKeyId { get; set; }
        public Union<string, BaseFunction>? AliasName { get => GivenName; set => GivenName = value; }
    }
}