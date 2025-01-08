namespace Humidifier.SES
{
    using System.Collections.Generic;
    using EmailIdentityTypes;

    public class EmailIdentity : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string DkimDNSTokenValue1 =  "DkimDNSTokenValue1" ;
            public static string DkimDNSTokenName2 =  "DkimDNSTokenName2" ;
            public static string DkimDNSTokenName3 =  "DkimDNSTokenName3" ;
            public static string DkimDNSTokenName1 =  "DkimDNSTokenName1" ;
            public static string DkimDNSTokenValue2 =  "DkimDNSTokenValue2" ;
            public static string DkimDNSTokenValue3 =  "DkimDNSTokenValue3" ;
        }

        public override string AWSTypeName { get => AWS.SES.EmailIdentity; }
        /// <summary>
        /// ConfigurationSetAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-emailidentity.html#cfn-ses-emailidentity-configurationsetattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConfigurationSetAttributes
        /// </summary>
        public Humidifier.SES.EmailIdentityTypes.ConfigurationSetAttributes ConfigurationSetAttributes { get; set; }

        /// <summary>
        /// EmailIdentity_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-emailidentity.html#cfn-ses-emailidentity-emailidentity
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EmailIdentity_ { get; set; }
        /// <summary>
        /// DkimSigningAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-emailidentity.html#cfn-ses-emailidentity-dkimsigningattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DkimSigningAttributes
        /// </summary>
        public Humidifier.SES.EmailIdentityTypes.DkimSigningAttributes DkimSigningAttributes { get; set; }
        /// <summary>
        /// DkimAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-emailidentity.html#cfn-ses-emailidentity-dkimattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DkimAttributes
        /// </summary>
        public Humidifier.SES.EmailIdentityTypes.DkimAttributes DkimAttributes { get; set; }
        /// <summary>
        /// FeedbackAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-emailidentity.html#cfn-ses-emailidentity-feedbackattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FeedbackAttributes
        /// </summary>
        public Humidifier.SES.EmailIdentityTypes.FeedbackAttributes FeedbackAttributes { get; set; }
        /// <summary>
        /// MailFromAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-emailidentity.html#cfn-ses-emailidentity-mailfromattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MailFromAttributes
        /// </summary>
        public Humidifier.SES.EmailIdentityTypes.MailFromAttributes MailFromAttributes { get; set; }
    }

    namespace EmailIdentityTypes
    {
        public class ConfigurationSetAttributes : Humidifier.Base.BaseSubResource, IHaveConfigurationSetName
        {
            /// <summary>
            /// ConfigurationSetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-emailidentity-configurationsetattributes.html#cfn-ses-emailidentity-configurationsetattributes-configurationsetname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfigurationSetName { get; set; }
        }

        public class DkimAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SigningEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-emailidentity-dkimattributes.html#cfn-ses-emailidentity-dkimattributes-signingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SigningEnabled { get; set; }
        }

        public class DkimSigningAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DomainSigningPrivateKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-emailidentity-dkimsigningattributes.html#cfn-ses-emailidentity-dkimsigningattributes-domainsigningprivatekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainSigningPrivateKey { get; set; }
            /// <summary>
            /// DomainSigningSelector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-emailidentity-dkimsigningattributes.html#cfn-ses-emailidentity-dkimsigningattributes-domainsigningselector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainSigningSelector { get; set; }
            /// <summary>
            /// NextSigningKeyLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-emailidentity-dkimsigningattributes.html#cfn-ses-emailidentity-dkimsigningattributes-nextsigningkeylength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NextSigningKeyLength { get; set; }
        }

        public class FeedbackAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EmailForwardingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-emailidentity-feedbackattributes.html#cfn-ses-emailidentity-feedbackattributes-emailforwardingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EmailForwardingEnabled { get; set; }
        }

        public class MailFromAttributes : Humidifier.Base.BaseSubResource, IHaveMailFromDomain, IHaveBehaviorOnMxFailure
        {
            /// <summary>
            /// MailFromDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-emailidentity-mailfromattributes.html#cfn-ses-emailidentity-mailfromattributes-mailfromdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailFromDomain { get; set; }
            /// <summary>
            /// BehaviorOnMxFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-emailidentity-mailfromattributes.html#cfn-ses-emailidentity-mailfromattributes-behavioronmxfailure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BehaviorOnMxFailure { get; set; }
        }
    }
}