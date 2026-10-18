namespace Humidifier.CertificateManager
{
    using global::System.Collections.Generic;
    using AccountTypes;

    public class Account : Humidifier.Base.BaseResource, IHaveCertificateManagerAccountTypesExpiryEventsConfigurationExpiryEventsConfiguration
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.CertificateManager.Account; }

        /// <summary>
        /// ExpiryEventsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-account.html#cfn-certificatemanager-account-expiryeventsconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ExpiryEventsConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration, BaseFunction>? ExpiryEventsConfiguration { get; set; }
    }

    namespace AccountTypes
    {
        public class ExpiryEventsConfiguration : Humidifier.Base.BaseSubResource, IHaveDaysBeforeExpiry_Integer
        {
            /// <summary>
            /// DaysBeforeExpiry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-account-expiryeventsconfiguration.html#cfn-certificatemanager-account-expiryeventsconfiguration-daysbeforeexpiry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DaysBeforeExpiry { get; set; }
        }
    }
}