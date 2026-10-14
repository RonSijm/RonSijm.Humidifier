namespace Humidifier.XRay
{
    using global::System.Collections.Generic;

    public class TransactionSearchConfig : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.XRay.TransactionSearchConfig; }
        /// <summary>
        /// IndexingPercentage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-transactionsearchconfig.html#cfn-xray-transactionsearchconfig-indexingpercentage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic IndexingPercentage { get; set; }
    }
}