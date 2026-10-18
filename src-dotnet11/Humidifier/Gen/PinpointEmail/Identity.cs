namespace Humidifier.PinpointEmail
{
    using global::System.Collections.Generic;
    using IdentityTypes;

    public class Identity : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveFeedbackForwardingEnabled_Boolean, IHaveDkimSigningEnabled_Boolean, IHaveListOfPinpointEmailIdentityTypesTagsTags, IHaveName, IHavePinpointEmailIdentityTypesMailFromAttributesMailFromAttributes
    {
        public class Attributes
        {
            public static string IdentityDNSRecordName3 =  "IdentityDNSRecordName3" ;
            public static string IdentityDNSRecordName1 =  "IdentityDNSRecordName1" ;
            public static string IdentityDNSRecordName2 =  "IdentityDNSRecordName2" ;
            public static string IdentityDNSRecordValue3 =  "IdentityDNSRecordValue3" ;
            public static string IdentityDNSRecordValue2 =  "IdentityDNSRecordValue2" ;
            public static string IdentityDNSRecordValue1 =  "IdentityDNSRecordValue1" ;
        }

        public override string AWSTypeName { get => AWS.PinpointEmail.Identity; }
        /// <summary>
        /// FeedbackForwardingEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-identity.html#cfn-pinpointemail-identity-feedbackforwardingenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? FeedbackForwardingEnabled { get; set; }
        /// <summary>
        /// DkimSigningEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-identity.html#cfn-pinpointemail-identity-dkimsigningenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DkimSigningEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-identity.html#cfn-pinpointemail-identity-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public Union<IReadOnlyList<Humidifier.PinpointEmail.IdentityTypes.Tags>, IReadOnlyList<Union<Humidifier.PinpointEmail.IdentityTypes.Tags, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// MailFromAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-identity.html#cfn-pinpointemail-identity-mailfromattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MailFromAttributes
        /// </summary>
        public Union<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes, BaseFunction>? MailFromAttributes { get; set; }
    }

    namespace IdentityTypes
    {
        public class MailFromAttributes : Humidifier.Base.BaseSubResource, IHaveMailFromDomain, IHaveBehaviorOnMxFailure
        {
            /// <summary>
            /// MailFromDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-identity-mailfromattributes.html#cfn-pinpointemail-identity-mailfromattributes-mailfromdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailFromDomain { get; set; }
            /// <summary>
            /// BehaviorOnMxFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-identity-mailfromattributes.html#cfn-pinpointemail-identity-mailfromattributes-behavioronmxfailure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BehaviorOnMxFailure { get; set; }
        }

        public class Tags : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-identity-tags.html#cfn-pinpointemail-identity-tags-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-identity-tags.html#cfn-pinpointemail-identity-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}