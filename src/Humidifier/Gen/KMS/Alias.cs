namespace Humidifier.KMS
{
    using System.Collections.Generic;

    public class Alias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAliasName
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
        public dynamic TargetKeyId { get; set; }
        public dynamic AliasName { get => GivenName; set => GivenName = value; }
    }
}