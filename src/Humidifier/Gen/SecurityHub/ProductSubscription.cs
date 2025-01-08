namespace Humidifier.SecurityHub
{
    using System.Collections.Generic;

    public class ProductSubscription : Humidifier.Base.BaseResource, IHaveProductArn
    {
        public class Attributes
        {
            public static string ProductSubscriptionArn =  "ProductSubscriptionArn" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.ProductSubscription; }

        /// <summary>
        /// ProductArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-productsubscription.html#cfn-securityhub-productsubscription-productarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProductArn { get; set; }
    }
}