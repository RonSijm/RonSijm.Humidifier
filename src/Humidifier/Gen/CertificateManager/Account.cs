namespace Humidifier.CertificateManager
{
    using System.Collections.Generic;
    using AccountTypes;

    public class Account : Humidifier.Base.BaseResource
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
        public Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration ExpiryEventsConfiguration { get; set; }
    }

    namespace AccountTypes
    {
        public class ExpiryEventsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DaysBeforeExpiry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-account-expiryeventsconfiguration.html#cfn-certificatemanager-account-expiryeventsconfiguration-daysbeforeexpiry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DaysBeforeExpiry { get; set; }
        }
    }
}