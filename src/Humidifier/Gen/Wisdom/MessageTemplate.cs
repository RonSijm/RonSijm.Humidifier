namespace Humidifier.Wisdom
{
    using System.Collections.Generic;
    using MessageTemplateTypes;

    public class MessageTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveLanguage
    {
        public class Attributes
        {
            public static string MessageTemplateArn =  "MessageTemplateArn" ;
            public static string MessageTemplateContentSha256 =  "MessageTemplateContentSha256" ;
            public static string MessageTemplateId =  "MessageTemplateId" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.MessageTemplate; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Language
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-language
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Language { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-content
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Content
        /// </summary>
        [Required]
        public Humidifier.Wisdom.MessageTemplateTypes.Content Content { get; set; }
        /// <summary>
        /// GroupingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-groupingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GroupingConfiguration
        /// </summary>
        public Humidifier.Wisdom.MessageTemplateTypes.GroupingConfiguration GroupingConfiguration { get; set; }

        /// <summary>
        /// KnowledgeBaseArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-knowledgebasearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic KnowledgeBaseArn { get; set; }

        /// <summary>
        /// ChannelSubtype
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-channelsubtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ChannelSubtype { get; set; }
        /// <summary>
        /// DefaultAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-defaultattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MessageTemplateAttributes
        /// </summary>
        public Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateAttributes DefaultAttributes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace MessageTemplateTypes
    {
        public class AgentAttributes : Humidifier.Base.BaseSubResource, IHaveFirstName, IHaveLastName
        {
            /// <summary>
            /// FirstName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-agentattributes.html#cfn-wisdom-messagetemplate-agentattributes-firstname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FirstName { get; set; }
            /// <summary>
            /// LastName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-agentattributes.html#cfn-wisdom-messagetemplate-agentattributes-lastname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastName { get; set; }
        }

        public class Content : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EmailMessageTemplateContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-content.html#cfn-wisdom-messagetemplate-content-emailmessagetemplatecontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmailMessageTemplateContent
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContent EmailMessageTemplateContent { get; set; }
            /// <summary>
            /// SmsMessageTemplateContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-content.html#cfn-wisdom-messagetemplate-content-smsmessagetemplatecontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmsMessageTemplateContent
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContent SmsMessageTemplateContent { get; set; }
        }

        public class CustomerProfileAttributes : Humidifier.Base.BaseSubResource, IHaveState, IHaveFirstName, IHaveLastName, IHaveEmailAddress, IHaveProfileId, IHavePhoneNumber, IHaveCountry, IHaveBusinessName
        {
            /// <summary>
            /// ProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-profileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProfileId { get; set; }
            /// <summary>
            /// BillingCity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingcity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingCity { get; set; }
            /// <summary>
            /// Gender
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-gender
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Gender { get; set; }
            /// <summary>
            /// ProfileARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-profilearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProfileARN { get; set; }
            /// <summary>
            /// BillingProvince
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingprovince
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingProvince { get; set; }
            /// <summary>
            /// BillingPostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingpostalcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingPostalCode { get; set; }
            /// <summary>
            /// ShippingAddress1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingaddress1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShippingAddress1 { get; set; }
            /// <summary>
            /// BusinessName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-businessname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BusinessName { get; set; }
            /// <summary>
            /// ShippingAddress4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingaddress4
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShippingAddress4 { get; set; }
            /// <summary>
            /// ShippingAddress3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingaddress3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShippingAddress3 { get; set; }
            /// <summary>
            /// ShippingAddress2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingaddress2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShippingAddress2 { get; set; }
            /// <summary>
            /// MailingCity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingcity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailingCity { get; set; }
            /// <summary>
            /// BusinessPhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-businessphonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BusinessPhoneNumber { get; set; }
            /// <summary>
            /// City
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-city
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic City { get; set; }
            /// <summary>
            /// EmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-emailaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmailAddress { get; set; }
            /// <summary>
            /// Province
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-province
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Province { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// ShippingPostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingpostalcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShippingPostalCode { get; set; }
            /// <summary>
            /// Country
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-country
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Country { get; set; }
            /// <summary>
            /// ShippingState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShippingState { get; set; }
            /// <summary>
            /// LastName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-lastname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastName { get; set; }
            /// <summary>
            /// BillingCounty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingcounty
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingCounty { get; set; }
            /// <summary>
            /// BillingState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingState { get; set; }
            /// <summary>
            /// BirthDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-birthdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BirthDate { get; set; }
            /// <summary>
            /// BusinessEmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-businessemailaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BusinessEmailAddress { get; set; }
            /// <summary>
            /// MailingCountry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingcountry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailingCountry { get; set; }
            /// <summary>
            /// PostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-postalcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PostalCode { get; set; }
            /// <summary>
            /// ShippingProvince
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingprovince
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShippingProvince { get; set; }
            /// <summary>
            /// MailingCounty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingcounty
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailingCounty { get; set; }
            /// <summary>
            /// MobilePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mobilephonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MobilePhoneNumber { get; set; }
            /// <summary>
            /// County
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-county
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic County { get; set; }
            /// <summary>
            /// MailingState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailingState { get; set; }
            /// <summary>
            /// HomePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-homephonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HomePhoneNumber { get; set; }
            /// <summary>
            /// Address4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-address4
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Address4 { get; set; }
            /// <summary>
            /// MailingPostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingpostalcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailingPostalCode { get; set; }
            /// <summary>
            /// MailingAddress3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingaddress3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailingAddress3 { get; set; }
            /// <summary>
            /// ShippingCountry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingcountry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShippingCountry { get; set; }
            /// <summary>
            /// MailingAddress4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingaddress4
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailingAddress4 { get; set; }
            /// <summary>
            /// ShippingCity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingcity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShippingCity { get; set; }
            /// <summary>
            /// MailingAddress1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingaddress1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailingAddress1 { get; set; }
            /// <summary>
            /// MailingAddress2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingaddress2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailingAddress2 { get; set; }
            /// <summary>
            /// PartyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-partytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PartyType { get; set; }
            /// <summary>
            /// AdditionalInformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-additionalinformation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdditionalInformation { get; set; }
            /// <summary>
            /// MailingProvince
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingprovince
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailingProvince { get; set; }
            /// <summary>
            /// BillingAddress1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingaddress1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingAddress1 { get; set; }
            /// <summary>
            /// BillingAddress2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingaddress2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingAddress2 { get; set; }
            /// <summary>
            /// FirstName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-firstname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FirstName { get; set; }
            /// <summary>
            /// BillingAddress3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingaddress3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingAddress3 { get; set; }
            /// <summary>
            /// BillingAddress4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingaddress4
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingAddress4 { get; set; }
            /// <summary>
            /// Address2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-address2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Address2 { get; set; }
            /// <summary>
            /// Address3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-address3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Address3 { get; set; }
            /// <summary>
            /// Custom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-custom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Custom { get; set; }
            /// <summary>
            /// Address1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-address1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Address1 { get; set; }
            /// <summary>
            /// MiddleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-middlename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MiddleName { get; set; }
            /// <summary>
            /// AccountNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-accountnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountNumber { get; set; }
            /// <summary>
            /// ShippingCounty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingcounty
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShippingCounty { get; set; }
            /// <summary>
            /// BillingCountry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingcountry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingCountry { get; set; }
            /// <summary>
            /// PhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-phonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PhoneNumber { get; set; }
        }

        public class EmailMessageTemplateContent : Humidifier.Base.BaseSubResource, IHaveSubject
        {
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplatecontent.html#cfn-wisdom-messagetemplate-emailmessagetemplatecontent-headers
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EmailMessageTemplateHeader
            /// </summary>
            public List<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateHeader> Headers { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplatecontent.html#cfn-wisdom-messagetemplate-emailmessagetemplatecontent-body
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EmailMessageTemplateContentBody
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody Body { get; set; }
            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplatecontent.html#cfn-wisdom-messagetemplate-emailmessagetemplatecontent-subject
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Subject { get; set; }
        }

        public class EmailMessageTemplateContentBody : Humidifier.Base.BaseSubResource, IHaveWisdomMessageTemplateTypesMessageTemplateBodyContentProviderPlainText
        {
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplatecontentbody.html#cfn-wisdom-messagetemplate-emailmessagetemplatecontentbody-plaintext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MessageTemplateBodyContentProvider
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider PlainText { get; set; }
            /// <summary>
            /// Html
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplatecontentbody.html#cfn-wisdom-messagetemplate-emailmessagetemplatecontentbody-html
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MessageTemplateBodyContentProvider
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider Html { get; set; }
        }

        public class EmailMessageTemplateHeader : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplateheader.html#cfn-wisdom-messagetemplate-emailmessagetemplateheader-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplateheader.html#cfn-wisdom-messagetemplate-emailmessagetemplateheader-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class GroupingConfiguration : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-groupingconfiguration.html#cfn-wisdom-messagetemplate-groupingconfiguration-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Criteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-groupingconfiguration.html#cfn-wisdom-messagetemplate-groupingconfiguration-criteria
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Criteria { get; set; }
        }

        public class MessageTemplateAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SystemAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplateattributes.html#cfn-wisdom-messagetemplate-messagetemplateattributes-systemattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SystemAttributes
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.SystemAttributes SystemAttributes { get; set; }
            /// <summary>
            /// CustomAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplateattributes.html#cfn-wisdom-messagetemplate-messagetemplateattributes-customattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> CustomAttributes { get; set; }
            /// <summary>
            /// AgentAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplateattributes.html#cfn-wisdom-messagetemplate-messagetemplateattributes-agentattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentAttributes
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.AgentAttributes AgentAttributes { get; set; }
            /// <summary>
            /// CustomerProfileAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplateattributes.html#cfn-wisdom-messagetemplate-messagetemplateattributes-customerprofileattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerProfileAttributes
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.CustomerProfileAttributes CustomerProfileAttributes { get; set; }
        }

        public class MessageTemplateBodyContentProvider : Humidifier.Base.BaseSubResource, IHaveContent
        {
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplatebodycontentprovider.html#cfn-wisdom-messagetemplate-messagetemplatebodycontentprovider-content
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Content { get; set; }
        }

        public class SmsMessageTemplateContent : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-smsmessagetemplatecontent.html#cfn-wisdom-messagetemplate-smsmessagetemplatecontent-body
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SmsMessageTemplateContentBody
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody Body { get; set; }
        }

        public class SmsMessageTemplateContentBody : Humidifier.Base.BaseSubResource, IHaveWisdomMessageTemplateTypesMessageTemplateBodyContentProviderPlainText
        {
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-smsmessagetemplatecontentbody.html#cfn-wisdom-messagetemplate-smsmessagetemplatecontentbody-plaintext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MessageTemplateBodyContentProvider
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider PlainText { get; set; }
        }

        public class SystemAttributes : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// CustomerEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-systemattributes.html#cfn-wisdom-messagetemplate-systemattributes-customerendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SystemEndpointAttributes
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.SystemEndpointAttributes CustomerEndpoint { get; set; }
            /// <summary>
            /// SystemEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-systemattributes.html#cfn-wisdom-messagetemplate-systemattributes-systemendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SystemEndpointAttributes
            /// </summary>
            public Humidifier.Wisdom.MessageTemplateTypes.SystemEndpointAttributes SystemEndpoint { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-systemattributes.html#cfn-wisdom-messagetemplate-systemattributes-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SystemEndpointAttributes : Humidifier.Base.BaseSubResource, IHaveAddress
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-systemendpointattributes.html#cfn-wisdom-messagetemplate-systemendpointattributes-address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Address { get; set; }
        }
    }
}