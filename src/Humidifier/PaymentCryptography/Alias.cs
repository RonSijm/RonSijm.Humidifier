namespace Humidifier.PaymentCryptography
{
    using System.Collections.Generic;

    public class Alias : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::PaymentCryptography::Alias";
            }
        }

        /// <summary>
        /// AliasName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-paymentcryptography-alias.html#cfn-paymentcryptography-alias-aliasname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AliasName { get; set; }
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