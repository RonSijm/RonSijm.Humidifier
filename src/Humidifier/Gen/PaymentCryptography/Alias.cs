namespace Humidifier.PaymentCryptography
{
    using System.Collections.Generic;

    public class Alias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveKeyArn
    {
        public override string AWSTypeName { get => AWS.PaymentCryptography.Alias; }
        public dynamic AliasName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// KeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-paymentcryptography-alias.html#cfn-paymentcryptography-alias-keyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KeyArn { get; set; }
    }
}