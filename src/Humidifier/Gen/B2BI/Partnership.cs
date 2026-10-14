namespace Humidifier.B2BI
{
    using global::System.Collections.Generic;
    using PartnershipTypes;

    public class Partnership : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveEmail, IHaveProfileId, IHaveCapabilities, IHavePhone
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
        public dynamic ProfileId { get; set; }

        /// <summary>
        /// Email
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-partnership.html#cfn-b2bi-partnership-email
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Email { get; set; }

        /// <summary>
        /// Capabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-partnership.html#cfn-b2bi-partnership-capabilities
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic Capabilities { get; set; }
        /// <summary>
        /// Phone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-partnership.html#cfn-b2bi-partnership-phone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Phone { get; set; }
        /// <summary>
        /// CapabilityOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-partnership.html#cfn-b2bi-partnership-capabilityoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapabilityOptions
        /// </summary>
        public Humidifier.B2BI.PartnershipTypes.CapabilityOptions CapabilityOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-partnership.html#cfn-b2bi-partnership-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace PartnershipTypes
    {
        public class CapabilityOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InboundEdi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-capabilityoptions.html#cfn-b2bi-partnership-capabilityoptions-inboundedi
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InboundEdiOptions
            /// </summary>
            public Humidifier.B2BI.PartnershipTypes.InboundEdiOptions InboundEdi { get; set; }
            /// <summary>
            /// OutboundEdi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-capabilityoptions.html#cfn-b2bi-partnership-capabilityoptions-outboundedi
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutboundEdiOptions
            /// </summary>
            public Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions OutboundEdi { get; set; }
        }

        public class InboundEdiOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// X12
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-inboundedioptions.html#cfn-b2bi-partnership-inboundedioptions-x12
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12InboundEdiOptions
            /// </summary>
            public Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions X12 { get; set; }
        }

        public class OutboundEdiOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// X12
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-outboundedioptions.html#cfn-b2bi-partnership-outboundedioptions-x12
            /// Required: True
            /// UpdateType: Mutable
            /// Type: X12Envelope
            /// </summary>
            public Humidifier.B2BI.PartnershipTypes.X12Envelope X12 { get; set; }
        }

        public class WrapOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LineLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-wrapoptions.html#cfn-b2bi-partnership-wrapoptions-linelength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LineLength { get; set; }
            /// <summary>
            /// WrapBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-wrapoptions.html#cfn-b2bi-partnership-wrapoptions-wrapby
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WrapBy { get; set; }
            /// <summary>
            /// LineTerminator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-wrapoptions.html#cfn-b2bi-partnership-wrapoptions-lineterminator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LineTerminator { get; set; }
        }

        public class X12AcknowledgmentOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TechnicalAcknowledgment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12acknowledgmentoptions.html#cfn-b2bi-partnership-x12acknowledgmentoptions-technicalacknowledgment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TechnicalAcknowledgment { get; set; }
            /// <summary>
            /// FunctionalAcknowledgment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12acknowledgmentoptions.html#cfn-b2bi-partnership-x12acknowledgmentoptions-functionalacknowledgment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionalAcknowledgment { get; set; }
        }

        public class X12ControlNumbers : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StartingFunctionalGroupControlNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12controlnumbers.html#cfn-b2bi-partnership-x12controlnumbers-startingfunctionalgroupcontrolnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartingFunctionalGroupControlNumber { get; set; }
            /// <summary>
            /// StartingInterchangeControlNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12controlnumbers.html#cfn-b2bi-partnership-x12controlnumbers-startinginterchangecontrolnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartingInterchangeControlNumber { get; set; }
            /// <summary>
            /// StartingTransactionSetControlNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12controlnumbers.html#cfn-b2bi-partnership-x12controlnumbers-startingtransactionsetcontrolnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartingTransactionSetControlNumber { get; set; }
        }

        public class X12Delimiters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SegmentTerminator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12delimiters.html#cfn-b2bi-partnership-x12delimiters-segmentterminator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SegmentTerminator { get; set; }
            /// <summary>
            /// ComponentSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12delimiters.html#cfn-b2bi-partnership-x12delimiters-componentseparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComponentSeparator { get; set; }
            /// <summary>
            /// DataElementSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12delimiters.html#cfn-b2bi-partnership-x12delimiters-dataelementseparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataElementSeparator { get; set; }
        }

        public class X12Envelope : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WrapOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12envelope.html#cfn-b2bi-partnership-x12envelope-wrapoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WrapOptions
            /// </summary>
            public Humidifier.B2BI.PartnershipTypes.WrapOptions WrapOptions { get; set; }
            /// <summary>
            /// Common
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12envelope.html#cfn-b2bi-partnership-x12envelope-common
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12OutboundEdiHeaders
            /// </summary>
            public Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders Common { get; set; }
        }

        public class X12FunctionalGroupHeaders : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApplicationSenderCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12functionalgroupheaders.html#cfn-b2bi-partnership-x12functionalgroupheaders-applicationsendercode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationSenderCode { get; set; }
            /// <summary>
            /// ApplicationReceiverCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12functionalgroupheaders.html#cfn-b2bi-partnership-x12functionalgroupheaders-applicationreceivercode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationReceiverCode { get; set; }
            /// <summary>
            /// ResponsibleAgencyCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12functionalgroupheaders.html#cfn-b2bi-partnership-x12functionalgroupheaders-responsibleagencycode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResponsibleAgencyCode { get; set; }
        }

        public class X12InboundEdiOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AcknowledgmentOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12inboundedioptions.html#cfn-b2bi-partnership-x12inboundedioptions-acknowledgmentoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12AcknowledgmentOptions
            /// </summary>
            public Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions AcknowledgmentOptions { get; set; }
        }

        public class X12InterchangeControlHeaders : Humidifier.Base.BaseSubResource, IHaveSenderId
        {
            /// <summary>
            /// ReceiverId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-receiverid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReceiverId { get; set; }
            /// <summary>
            /// AcknowledgmentRequestedCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-acknowledgmentrequestedcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AcknowledgmentRequestedCode { get; set; }
            /// <summary>
            /// SenderIdQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-senderidqualifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SenderIdQualifier { get; set; }
            /// <summary>
            /// UsageIndicatorCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-usageindicatorcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UsageIndicatorCode { get; set; }
            /// <summary>
            /// RepetitionSeparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-repetitionseparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RepetitionSeparator { get; set; }
            /// <summary>
            /// SenderId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-senderid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SenderId { get; set; }
            /// <summary>
            /// ReceiverIdQualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12interchangecontrolheaders.html#cfn-b2bi-partnership-x12interchangecontrolheaders-receiveridqualifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReceiverIdQualifier { get; set; }
        }

        public class X12OutboundEdiHeaders : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Delimiters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-delimiters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12Delimiters
            /// </summary>
            public Humidifier.B2BI.PartnershipTypes.X12Delimiters Delimiters { get; set; }
            /// <summary>
            /// ControlNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-controlnumbers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12ControlNumbers
            /// </summary>
            public Humidifier.B2BI.PartnershipTypes.X12ControlNumbers ControlNumbers { get; set; }
            /// <summary>
            /// FunctionalGroupHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-functionalgroupheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12FunctionalGroupHeaders
            /// </summary>
            public Humidifier.B2BI.PartnershipTypes.X12FunctionalGroupHeaders FunctionalGroupHeaders { get; set; }
            /// <summary>
            /// InterchangeControlHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-interchangecontrolheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: X12InterchangeControlHeaders
            /// </summary>
            public Humidifier.B2BI.PartnershipTypes.X12InterchangeControlHeaders InterchangeControlHeaders { get; set; }
            /// <summary>
            /// ValidateEdi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-validateedi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ValidateEdi { get; set; }
            /// <summary>
            /// Gs05TimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-partnership-x12outboundediheaders.html#cfn-b2bi-partnership-x12outboundediheaders-gs05timeformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Gs05TimeFormat { get; set; }
        }
    }
}