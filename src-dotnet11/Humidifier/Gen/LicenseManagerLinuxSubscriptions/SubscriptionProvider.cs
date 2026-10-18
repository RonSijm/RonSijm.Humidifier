namespace Humidifier.LicenseManagerLinuxSubscriptions
{
    using global::System.Collections.Generic;

    public class SubscriptionProvider : Humidifier.Base.BaseResource, IHaveTags, IHaveSecretArn, IHaveSubscriptionProviderSource
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
        public Union<string, BaseFunction>? SecretArn { get; set; }

        /// <summary>
        /// SubscriptionProviderSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanagerlinuxsubscriptions-subscriptionprovider.html#cfn-licensemanagerlinuxsubscriptions-subscriptionprovider-subscriptionprovidersource
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SubscriptionProviderSource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanagerlinuxsubscriptions-subscriptionprovider.html#cfn-licensemanagerlinuxsubscriptions-subscriptionprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}