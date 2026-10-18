namespace Humidifier.B2BI
{
    using global::System.Collections.Generic;
    using PartnershipTypes;

    public class Partnership : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProfileId, IHaveEmail, IHaveStringListOfCapabilities, IHavePhone, IHaveB2BIPartnershipTypesCapabilityOptionsCapabilityOptions, IHaveName
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string TradingPartnerId =  "TradingPartnerId" ;
            public static string PartnershipId =  "PartnershipId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string PartnershipArn =  "PartnershipArn" ;
        }

        public override string AWSTypeName { get => AWS.B2BI.Partnership; }

        /// <summary>
        /// ProfileId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-partnership.html#cfn-b2bi-partnership-profileid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProfileId { get; set; }

        /// <summary>
        /// Email
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-partnership.html#cfn-b2bi-partnership-email
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Email { get; set; }

        /// <summary>
        /// Capabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-partnership.html#cfn-b2bi-partnership-capabilities
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Capabilities { get; set; }
        /// <summary>
        /// Phone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-partnership.html#cfn-b2bi-partnership-phone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Phone { get; set; }
        /// <summary>
        /// CapabilityOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-partnership.html#cfn-b2bi-partnership-capabilityoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapabilityOptions
        /// </summary>
        public Union<Humidifier.B2BI.PartnershipTypes.CapabilityOptions, BaseFunction>? CapabilityOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-partnership.html#cfn-b2bi-partnership-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PartnershipTypes
    {
        public class CapabilityOptions : Humidifier.Base.BaseSubResource, IHaveB2BIPartnershipTypesInboundEdiOptionsInboundEdi, IHaveB2BIPartnershipTypesOutboundEdiOptionsOutboundEdi
        {
            /// <summary>
            /// InboundEdi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-capabilityoptions.html#cfn-b2bi-partnership-capabilityoptions-inboundedi
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InboundEdiOptions
            /// </summary>
            public Union<Humidifier.B2BI.PartnershipTypes.InboundEdiOptions, BaseFunction>? InboundEdi { get; set; }
            /// <summary>
            /// OutboundEdi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-capabilityoptions.html#cfn-b2bi-partnership-capabilityoptions-outboundedi
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutboundEdiOptions
            /// </summary>
            public Union<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions, BaseFunction>? OutboundEdi { get; set; }
        }

        public class InboundEdiOptions : Humidifier.Base.BaseSubResource, IHaveB2BIPartnershipTypesX12InboundEdiOptionsX12
        {
            /// <summary>
            /// X12
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-inboundedioptions.html#cfn-b2bi-partnership-inboundedioptions-x12
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12InboundEdiOptions
            /// </summary>
            public Union<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions, BaseFunction>? X12 { get; set; }
        }

        public class OutboundEdiOptions : Humidifier.Base.BaseSubResource, IHaveB2BIPartnershipTypesX12EnvelopeX12
        {
            /// <summary>
            /// X12
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-outboundedioptions.html#cfn-b2bi-partnership-outboundedioptions-x12
            /// Required: True
            /// UpdateType: Mutable
            /// Type: X12Envelope
            /// </summary>
            public Union<Humidifier.B2BI.PartnershipTypes.X12Envelope, BaseFunction>? X12 { get; set; }
        }

        public class WrapOptions : Humidifier.Base.BaseSubResource, IHaveLineLength_Double, IHaveWrapBy, IHaveLineTerminator
        {
            /// <summary>
            /// LineLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-wrapoptions.html#cfn-b2bi-partnership-wrapoptions-linelength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LineLength { get; set; }
            /// <summary>
            /// WrapBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-wrapoptions.html#cfn-b2bi-partnership-wrapoptions-wrapby
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WrapBy { get; set; }
            /// <summary>
            /// LineTerminator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-wrapoptions.html#cfn-b2bi-partnership-wrapoptions-lineterminator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LineTerminator { get; set; }
        }

        public class X12AcknowledgmentOptions : Humidifier.Base.BaseSubResource, IHaveTechnicalAcknowledgment, IHaveFunctionalAcknowledgment
        {
            /// <summary>
            /// TechnicalAcknowledgment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12acknowledgmentoptions.html#cfn-b2bi-partnership-x12acknowledgmentoptions-technicalacknowledgment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TechnicalAcknowledgment { get; set; }
            /// <summary>
            /// FunctionalAcknowledgment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12acknowledgmentoptions.html#cfn-b2bi-partnership-x12acknowledgmentoptions-functionalacknowledgment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionalAcknowledgment { get; set; }
        }

        public class X12ControlNumbers : Humidifier.Base.BaseSubResource, IHaveStartingFunctionalGroupControlNumber_Double, IHaveStartingInterchangeControlNumber_Double, IHaveStartingTransactionSetControlNumber_Double
        {
            /// <summary>
            /// StartingFunctionalGroupControlNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12controlnumbers.html#cfn-b2bi-partnership-x12controlnumbers-startingfunctionalgroupcontrolnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? StartingFunctionalGroupControlNumber { get; set; }
            /// <summary>
            /// StartingInterchangeControlNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12controlnumbers.html#cfn-b2bi-partnership-x12controlnumbers-startinginterchangecontrolnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? StartingInterchangeControlNumber { get; set; }
            /// <summary>
            /// StartingTransactionSetControlNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12controlnumbers.html#cfn-b2bi-partnership-x12controlnumbers-startingtransactionsetcontrolnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? StartingTransactionSetControlNumber { get; set; }
        }

        public class X12Delimiters : Humidifier.Base.BaseSubResource, IHaveSegmentTerminator, IHaveComponentSeparator, IHaveDataElementSeparator
        {
            /// <summary>
            /// SegmentTerminator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12delimiters.html#cfn-b2bi-partnership-x12delimiters-segmentterminator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SegmentTerminator { get; set; }
            /// <summary>
            /// ComponentSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12delimiters.html#cfn-b2bi-partnership-x12delimiters-componentseparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentSeparator { get; set; }
            /// <summary>
            /// DataElementSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12delimiters.html#cfn-b2bi-partnership-x12delimiters-dataelementseparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataElementSeparator { get; set; }
        }

        public class X12Envelope : Humidifier.Base.BaseSubResource, IHaveB2BIPartnershipTypesWrapOptionsWrapOptions, IHaveB2BIPartnershipTypesX12OutboundEdiHeadersCommon
        {
            /// <summary>
            /// WrapOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12envelope.html#cfn-b2bi-partnership-x12envelope-wrapoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WrapOptions
            /// </summary>
            public Union<Humidifier.B2BI.PartnershipTypes.WrapOptions, BaseFunction>? WrapOptions { get; set; }
            /// <summary>
            /// Common
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12envelope.html#cfn-b2bi-partnership-x12envelope-common
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12OutboundEdiHeaders
            /// </summary>
            public Union<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders, BaseFunction>? Common { get; set; }
        }

        public class X12FunctionalGroupHeaders : Humidifier.Base.BaseSubResource, IHaveApplicationSenderCode, IHaveApplicationReceiverCode, IHaveResponsibleAgencyCode
        {
            /// <summary>
            /// ApplicationSenderCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12functionalgroupheaders.html#cfn-b2bi-partnership-x12functionalgroupheaders-applicationsendercode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationSenderCode { get; set; }
            /// <summary>
            /// ApplicationReceiverCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12functionalgroupheaders.html#cfn-b2bi-partnership-x12functionalgroupheaders-applicationreceivercode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationReceiverCode { get; set; }
            /// <summary>
            /// ResponsibleAgencyCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12functionalgroupheaders.html#cfn-b2bi-partnership-x12functionalgroupheaders-responsibleagencycode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResponsibleAgencyCode { get; set; }
        }

        public class X12InboundEdiOptions : Humidifier.Base.BaseSubResource, IHaveB2BIPartnershipTypesX12AcknowledgmentOptionsAcknowledgmentOptions
        {
            /// <summary>
            /// AcknowledgmentOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12inboundedioptions.html#cfn-b2bi-partnership-x12inboundedioptions-acknowledgmentoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12AcknowledgmentOptions
            /// </summary>
            public Union<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions, BaseFunction>? AcknowledgmentOptions { get; set; }
        }

        public class X12InterchangeControlHeaders : Humidifier.Base.BaseSubResource, IHaveReceiverId, IHaveAcknowledgmentRequestedCode, IHaveSenderIdQualifier, IHaveUsageIndicatorCode, IHaveRepetitionSeparator, IHaveSenderId, IHaveReceiverIdQualifier
        {
            /// <summary>
            /// ReceiverId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-receiverid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReceiverId { get; set; }
            /// <summary>
            /// AcknowledgmentRequestedCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-acknowledgmentrequestedcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AcknowledgmentRequestedCode { get; set; }
            /// <summary>
            /// SenderIdQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-senderidqualifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SenderIdQualifier { get; set; }
            /// <summary>
            /// UsageIndicatorCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-usageindicatorcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsageIndicatorCode { get; set; }
            /// <summary>
            /// RepetitionSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-repetitionseparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepetitionSeparator { get; set; }
            /// <summary>
            /// SenderId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-senderid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SenderId { get; set; }
            /// <summary>
            /// ReceiverIdQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-receiveridqualifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReceiverIdQualifier { get; set; }
        }

        public class X12OutboundEdiHeaders : Humidifier.Base.BaseSubResource, IHaveB2BIPartnershipTypesX12DelimitersDelimiters, IHaveB2BIPartnershipTypesX12ControlNumbersControlNumbers, IHaveB2BIPartnershipTypesX12FunctionalGroupHeadersFunctionalGroupHeaders, IHaveB2BIPartnershipTypesX12InterchangeControlHeadersInterchangeControlHeaders, IHaveValidateEdi_Boolean, IHaveGs05TimeFormat
        {
            /// <summary>
            /// Delimiters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-delimiters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12Delimiters
            /// </summary>
            public Union<Humidifier.B2BI.PartnershipTypes.X12Delimiters, BaseFunction>? Delimiters { get; set; }
            /// <summary>
            /// ControlNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-controlnumbers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12ControlNumbers
            /// </summary>
            public Union<Humidifier.B2BI.PartnershipTypes.X12ControlNumbers, BaseFunction>? ControlNumbers { get; set; }
            /// <summary>
            /// FunctionalGroupHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-functionalgroupheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12FunctionalGroupHeaders
            /// </summary>
            public Union<Humidifier.B2BI.PartnershipTypes.X12FunctionalGroupHeaders, BaseFunction>? FunctionalGroupHeaders { get; set; }
            /// <summary>
            /// InterchangeControlHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-interchangecontrolheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12InterchangeControlHeaders
            /// </summary>
            public Union<Humidifier.B2BI.PartnershipTypes.X12InterchangeControlHeaders, BaseFunction>? InterchangeControlHeaders { get; set; }
            /// <summary>
            /// ValidateEdi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-validateedi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ValidateEdi { get; set; }
            /// <summary>
            /// Gs05TimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-gs05timeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Gs05TimeFormat { get; set; }
        }
    }
}