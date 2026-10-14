namespace Humidifier.LicenseManagerLinuxSubscriptions
{
    using global::System.Collections.Generic;

    public class SubscriptionProvider : Humidifier.Base.BaseResource, IHaveTags, IHaveSecretArn
    {
        public class Attributes
        {
            public static string SubscriptionProviderArn =  "SubscriptionProviderArn" ;
            public static string SubscriptionProviderStatus =  "SubscriptionProviderStatus" ;
            public static string SubscriptionProviderStatusMessage =  "SubscriptionProviderStatusMessage" ;
            public static string LastSuccessfulDataRetrievalTime =  "LastSuccessfulDataRetrievalTime" ;
        }

        public override string AWSTypeName { get => AWS.LicenseManagerLinuxSubscriptions.SubscriptionProvider; }

        /// <summary>
        /// SecretArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanagerlinuxsubscriptions-subscriptionprovider.html#cfn-licensemanagerlinuxsubscriptions-subscriptionprovider-secretarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SecretArn { get; set; }

        /// <summary>
        /// SubscriptionProviderSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanagerlinuxsubscriptions-subscriptionprovider.html#cfn-licensemanagerlinuxsubscriptions-subscriptionprovider-subscriptionprovidersource
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SubscriptionProviderSource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanagerlinuxsubscriptions-subscriptionprovider.html#cfn-licensemanagerlinuxsubscriptions-subscriptionprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}