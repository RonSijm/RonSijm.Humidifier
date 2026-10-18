namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;
    using MessageTemplateTypes;

    public class MessageTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfWisdomMessageTemplateTypesMessageTemplateAttachmentMessageTemplateAttachments, IHaveDescription, IHaveLanguage, IHaveWisdomMessageTemplateTypesContentContent, IHaveWisdomMessageTemplateTypesGroupingConfigurationGroupingConfiguration, IHaveKnowledgeBaseArn, IHaveChannelSubtype, IHaveWisdomMessageTemplateTypesMessageTemplateAttributesDefaultAttributes, IHaveName
    {
        public class Attributes
        {
            public static string MessageTemplateArn =  "MessageTemplateArn" ;
            public static string MessageTemplateContentSha256 =  "MessageTemplateContentSha256" ;
            public static string MessageTemplateId =  "MessageTemplateId" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.MessageTemplate; }
        /// <summary>
        /// MessageTemplateAttachments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-messagetemplateattachments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MessageTemplateAttachment
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateAttachment>, IReadOnlyList<Union<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateAttachment, BaseFunction>>, BaseFunction>? MessageTemplateAttachments { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Language
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-language
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Language { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-content
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Content
        /// </summary>
        [Required]
        public Union<Humidifier.Wisdom.MessageTemplateTypes.Content, BaseFunction>? Content { get; set; }
        /// <summary>
        /// GroupingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-groupingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GroupingConfiguration
        /// </summary>
        public Union<Humidifier.Wisdom.MessageTemplateTypes.GroupingConfiguration, BaseFunction>? GroupingConfiguration { get; set; }

        /// <summary>
        /// KnowledgeBaseArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-knowledgebasearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KnowledgeBaseArn { get; set; }

        /// <summary>
        /// ChannelSubtype
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-channelsubtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelSubtype { get; set; }
        /// <summary>
        /// DefaultAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-defaultattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MessageTemplateAttributes
        /// </summary>
        public Union<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateAttributes, BaseFunction>? DefaultAttributes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-messagetemplate.html#cfn-wisdom-messagetemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
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
            public Union<string, BaseFunction>? FirstName { get; set; }
            /// <summary>
            /// LastName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-agentattributes.html#cfn-wisdom-messagetemplate-agentattributes-lastname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastName { get; set; }
        }

        public class Content : Humidifier.Base.BaseSubResource, IHaveWisdomMessageTemplateTypesEmailMessageTemplateContentEmailMessageTemplateContent, IHaveWisdomMessageTemplateTypesSmsMessageTemplateContentSmsMessageTemplateContent
        {
            /// <summary>
            /// EmailMessageTemplateContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-content.html#cfn-wisdom-messagetemplate-content-emailmessagetemplatecontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmailMessageTemplateContent
            /// </summary>
            public Union<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContent, BaseFunction>? EmailMessageTemplateContent { get; set; }
            /// <summary>
            /// SmsMessageTemplateContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-content.html#cfn-wisdom-messagetemplate-content-smsmessagetemplatecontent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SmsMessageTemplateContent
            /// </summary>
            public Union<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContent, BaseFunction>? SmsMessageTemplateContent { get; set; }
        }

        public class CustomerProfileAttributes : Humidifier.Base.BaseSubResource, IHaveProfileId, IHaveBillingCity, IHaveGender, IHaveProfileARN, IHaveBillingProvince, IHaveBillingPostalCode, IHaveShippingAddress1, IHaveBusinessName, IHaveShippingAddress4, IHaveShippingAddress3, IHaveShippingAddress2, IHaveMailingCity, IHaveBusinessPhoneNumber, IHaveCity, IHaveEmailAddress, IHaveProvince, IHaveState, IHaveShippingPostalCode, IHaveCountry, IHaveShippingState, IHaveLastName, IHaveBillingCounty, IHaveBillingState, IHaveBirthDate, IHaveBusinessEmailAddress, IHaveMailingCountry, IHavePostalCode, IHaveShippingProvince, IHaveMailingCounty, IHaveMobilePhoneNumber, IHaveCounty, IHaveMailingState, IHaveHomePhoneNumber, IHaveAddress4, IHaveMailingPostalCode, IHaveMailingAddress3, IHaveShippingCountry, IHaveMailingAddress4, IHaveShippingCity, IHaveMailingAddress1, IHaveMailingAddress2, IHavePartyType, IHaveAdditionalInformation, IHaveMailingProvince, IHaveBillingAddress1, IHaveBillingAddress2, IHaveFirstName, IHaveBillingAddress3, IHaveBillingAddress4, IHaveAddress2, IHaveAddress3, IHaveStringDictionaryOfCustom, IHaveAddress1, IHaveMiddleName, IHaveAccountNumber, IHaveShippingCounty, IHaveBillingCountry, IHavePhoneNumber
        {
            /// <summary>
            /// ProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-profileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProfileId { get; set; }
            /// <summary>
            /// BillingCity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingcity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingCity { get; set; }
            /// <summary>
            /// Gender
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-gender
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Gender { get; set; }
            /// <summary>
            /// ProfileARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-profilearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProfileARN { get; set; }
            /// <summary>
            /// BillingProvince
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingprovince
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingProvince { get; set; }
            /// <summary>
            /// BillingPostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingpostalcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingPostalCode { get; set; }
            /// <summary>
            /// ShippingAddress1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingaddress1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShippingAddress1 { get; set; }
            /// <summary>
            /// BusinessName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-businessname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BusinessName { get; set; }
            /// <summary>
            /// ShippingAddress4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingaddress4
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShippingAddress4 { get; set; }
            /// <summary>
            /// ShippingAddress3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingaddress3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShippingAddress3 { get; set; }
            /// <summary>
            /// ShippingAddress2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingaddress2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShippingAddress2 { get; set; }
            /// <summary>
            /// MailingCity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingcity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailingCity { get; set; }
            /// <summary>
            /// BusinessPhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-businessphonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BusinessPhoneNumber { get; set; }
            /// <summary>
            /// City
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-city
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? City { get; set; }
            /// <summary>
            /// EmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-emailaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailAddress { get; set; }
            /// <summary>
            /// Province
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-province
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Province { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// ShippingPostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingpostalcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShippingPostalCode { get; set; }
            /// <summary>
            /// Country
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-country
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Country { get; set; }
            /// <summary>
            /// ShippingState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShippingState { get; set; }
            /// <summary>
            /// LastName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-lastname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastName { get; set; }
            /// <summary>
            /// BillingCounty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingcounty
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingCounty { get; set; }
            /// <summary>
            /// BillingState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingState { get; set; }
            /// <summary>
            /// BirthDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-birthdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BirthDate { get; set; }
            /// <summary>
            /// BusinessEmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-businessemailaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BusinessEmailAddress { get; set; }
            /// <summary>
            /// MailingCountry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingcountry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailingCountry { get; set; }
            /// <summary>
            /// PostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-postalcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PostalCode { get; set; }
            /// <summary>
            /// ShippingProvince
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingprovince
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShippingProvince { get; set; }
            /// <summary>
            /// MailingCounty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingcounty
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailingCounty { get; set; }
            /// <summary>
            /// MobilePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mobilephonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MobilePhoneNumber { get; set; }
            /// <summary>
            /// County
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-county
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? County { get; set; }
            /// <summary>
            /// MailingState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailingState { get; set; }
            /// <summary>
            /// HomePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-homephonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HomePhoneNumber { get; set; }
            /// <summary>
            /// Address4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-address4
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address4 { get; set; }
            /// <summary>
            /// MailingPostalCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingpostalcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailingPostalCode { get; set; }
            /// <summary>
            /// MailingAddress3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingaddress3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailingAddress3 { get; set; }
            /// <summary>
            /// ShippingCountry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingcountry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShippingCountry { get; set; }
            /// <summary>
            /// MailingAddress4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingaddress4
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailingAddress4 { get; set; }
            /// <summary>
            /// ShippingCity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingcity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShippingCity { get; set; }
            /// <summary>
            /// MailingAddress1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingaddress1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailingAddress1 { get; set; }
            /// <summary>
            /// MailingAddress2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingaddress2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailingAddress2 { get; set; }
            /// <summary>
            /// PartyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-partytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartyType { get; set; }
            /// <summary>
            /// AdditionalInformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-additionalinformation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdditionalInformation { get; set; }
            /// <summary>
            /// MailingProvince
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-mailingprovince
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailingProvince { get; set; }
            /// <summary>
            /// BillingAddress1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingaddress1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingAddress1 { get; set; }
            /// <summary>
            /// BillingAddress2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingaddress2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingAddress2 { get; set; }
            /// <summary>
            /// FirstName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-firstname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FirstName { get; set; }
            /// <summary>
            /// BillingAddress3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingaddress3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingAddress3 { get; set; }
            /// <summary>
            /// BillingAddress4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingaddress4
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingAddress4 { get; set; }
            /// <summary>
            /// Address2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-address2
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address2 { get; set; }
            /// <summary>
            /// Address3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-address3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address3 { get; set; }
            /// <summary>
            /// Custom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-custom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Custom { get; set; }
            /// <summary>
            /// Address1
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-address1
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address1 { get; set; }
            /// <summary>
            /// MiddleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-middlename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MiddleName { get; set; }
            /// <summary>
            /// AccountNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-accountnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountNumber { get; set; }
            /// <summary>
            /// ShippingCounty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-shippingcounty
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShippingCounty { get; set; }
            /// <summary>
            /// BillingCountry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-billingcountry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingCountry { get; set; }
            /// <summary>
            /// PhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-customerprofileattributes.html#cfn-wisdom-messagetemplate-customerprofileattributes-phonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PhoneNumber { get; set; }
        }

        public class EmailMessageTemplateContent : Humidifier.Base.BaseSubResource, IHaveListOfWisdomMessageTemplateTypesEmailMessageTemplateHeaderHeaders, IHaveWisdomMessageTemplateTypesEmailMessageTemplateContentBodyBody, IHaveSubject
        {
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplatecontent.html#cfn-wisdom-messagetemplate-emailmessagetemplatecontent-headers
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EmailMessageTemplateHeader
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateHeader>, IReadOnlyList<Union<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateHeader, BaseFunction>>, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplatecontent.html#cfn-wisdom-messagetemplate-emailmessagetemplatecontent-body
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EmailMessageTemplateContentBody
            /// </summary>
            public Union<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody, BaseFunction>? Body { get; set; }
            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplatecontent.html#cfn-wisdom-messagetemplate-emailmessagetemplatecontent-subject
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Subject { get; set; }
        }

        public class EmailMessageTemplateContentBody : Humidifier.Base.BaseSubResource, IHaveWisdomMessageTemplateTypesMessageTemplateBodyContentProviderPlainText, IHaveWisdomMessageTemplateTypesMessageTemplateBodyContentProviderHtml
        {
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplatecontentbody.html#cfn-wisdom-messagetemplate-emailmessagetemplatecontentbody-plaintext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MessageTemplateBodyContentProvider
            /// </summary>
            public Union<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider, BaseFunction>? PlainText { get; set; }
            /// <summary>
            /// Html
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplatecontentbody.html#cfn-wisdom-messagetemplate-emailmessagetemplatecontentbody-html
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MessageTemplateBodyContentProvider
            /// </summary>
            public Union<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider, BaseFunction>? Html { get; set; }
        }

        public class EmailMessageTemplateHeader : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplateheader.html#cfn-wisdom-messagetemplate-emailmessagetemplateheader-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-emailmessagetemplateheader.html#cfn-wisdom-messagetemplate-emailmessagetemplateheader-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class GroupingConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveCriteria
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-groupingconfiguration.html#cfn-wisdom-messagetemplate-groupingconfiguration-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Criteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-groupingconfiguration.html#cfn-wisdom-messagetemplate-groupingconfiguration-criteria
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Criteria { get; set; }
        }

        public class MessageTemplateAttachment : Humidifier.Base.BaseSubResource, IHaveAttachmentName, IHaveS3PresignedUrl, IHaveAttachmentId
        {
            /// <summary>
            /// AttachmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplateattachment.html#cfn-wisdom-messagetemplate-messagetemplateattachment-attachmentname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttachmentName { get; set; }
            /// <summary>
            /// S3PresignedUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplateattachment.html#cfn-wisdom-messagetemplate-messagetemplateattachment-s3presignedurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3PresignedUrl { get; set; }
            /// <summary>
            /// AttachmentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplateattachment.html#cfn-wisdom-messagetemplate-messagetemplateattachment-attachmentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttachmentId { get; set; }
        }

        public class MessageTemplateAttributes : Humidifier.Base.BaseSubResource, IHaveWisdomMessageTemplateTypesSystemAttributesSystemAttributes, IHaveStringDictionaryOfCustomAttributes, IHaveWisdomMessageTemplateTypesAgentAttributesAgentAttributes, IHaveWisdomMessageTemplateTypesCustomerProfileAttributesCustomerProfileAttributes
        {
            /// <summary>
            /// SystemAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplateattributes.html#cfn-wisdom-messagetemplate-messagetemplateattributes-systemattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SystemAttributes
            /// </summary>
            public Union<Humidifier.Wisdom.MessageTemplateTypes.SystemAttributes, BaseFunction>? SystemAttributes { get; set; }
            /// <summary>
            /// CustomAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplateattributes.html#cfn-wisdom-messagetemplate-messagetemplateattributes-customattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomAttributes { get; set; }
            /// <summary>
            /// AgentAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplateattributes.html#cfn-wisdom-messagetemplate-messagetemplateattributes-agentattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentAttributes
            /// </summary>
            public Union<Humidifier.Wisdom.MessageTemplateTypes.AgentAttributes, BaseFunction>? AgentAttributes { get; set; }
            /// <summary>
            /// CustomerProfileAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-messagetemplateattributes.html#cfn-wisdom-messagetemplate-messagetemplateattributes-customerprofileattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerProfileAttributes
            /// </summary>
            public Union<Humidifier.Wisdom.MessageTemplateTypes.CustomerProfileAttributes, BaseFunction>? CustomerProfileAttributes { get; set; }
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
            public Union<string, BaseFunction>? Content { get; set; }
        }

        public class SmsMessageTemplateContent : Humidifier.Base.BaseSubResource, IHaveWisdomMessageTemplateTypesSmsMessageTemplateContentBodyBody
        {
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-smsmessagetemplatecontent.html#cfn-wisdom-messagetemplate-smsmessagetemplatecontent-body
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SmsMessageTemplateContentBody
            /// </summary>
            public Union<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody, BaseFunction>? Body { get; set; }
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
            public Union<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider, BaseFunction>? PlainText { get; set; }
        }

        public class SystemAttributes : Humidifier.Base.BaseSubResource, IHaveWisdomMessageTemplateTypesSystemEndpointAttributesCustomerEndpoint, IHaveWisdomMessageTemplateTypesSystemEndpointAttributesSystemEndpoint, IHaveName
        {
            /// <summary>
            /// CustomerEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-systemattributes.html#cfn-wisdom-messagetemplate-systemattributes-customerendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SystemEndpointAttributes
            /// </summary>
            public Union<Humidifier.Wisdom.MessageTemplateTypes.SystemEndpointAttributes, BaseFunction>? CustomerEndpoint { get; set; }
            /// <summary>
            /// SystemEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-systemattributes.html#cfn-wisdom-messagetemplate-systemattributes-systemendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SystemEndpointAttributes
            /// </summary>
            public Union<Humidifier.Wisdom.MessageTemplateTypes.SystemEndpointAttributes, BaseFunction>? SystemEndpoint { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-messagetemplate-systemattributes.html#cfn-wisdom-messagetemplate-systemattributes-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
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
            public Union<string, BaseFunction>? Address { get; set; }
        }
    }
}