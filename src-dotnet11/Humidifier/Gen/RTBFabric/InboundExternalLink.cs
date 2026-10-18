namespace Humidifier.RTBFabric
{
    using global::System.Collections.Generic;
    using InboundExternalLinkTypes;

    public class InboundExternalLink : Humidifier.Base.BaseResource, IHaveTags, IHaveRTBFabricInboundExternalLinkTypesLinkAttributesLinkAttributes, IHaveRTBFabricInboundExternalLinkTypesLinkLogSettingsLinkLogSettings, IHaveGatewayId
    {
        public class Attributes
        {
            public static string LinkStatus =  "LinkStatus" ;
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string DomainName =  "DomainName" ;
            public static string Arn =  "Arn" ;
            public static string LinkId =  "LinkId" ;
        }

        public override string AWSTypeName { get => AWS.RTBFabric.InboundExternalLink; }
        /// <summary>
        /// LinkAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-inboundexternallink.html#cfn-rtbfabric-inboundexternallink-linkattributes
        /// Required: False
        /// UpdateType: Conditional
        /// Type: LinkAttributes
        /// </summary>
        public Union<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes, BaseFunction>? LinkAttributes { get; set; }

        /// <summary>
        /// LinkLogSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-inboundexternallink.html#cfn-rtbfabric-inboundexternallink-linklogsettings
        /// Required: True
        /// UpdateType: Conditional
        /// Type: LinkLogSettings
        /// </summary>
        [Required]
        public Union<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings, BaseFunction>? LinkLogSettings { get; set; }

        /// <summary>
        /// GatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-inboundexternallink.html#cfn-rtbfabric-inboundexternallink-gatewayid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GatewayId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-inboundexternallink.html#cfn-rtbfabric-inboundexternallink-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace InboundExternalLinkTypes
    {
        public class ApplicationLogs : Humidifier.Base.BaseSubResource, IHaveRTBFabricInboundExternalLinkTypesLinkApplicationLogSamplingLinkApplicationLogSampling
        {
            /// <summary>
            /// LinkApplicationLogSampling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-inboundexternallink-applicationlogs.html#cfn-rtbfabric-inboundexternallink-applicationlogs-linkapplicationlogsampling
            /// Required: True
            /// UpdateType: Conditional
            /// Type: LinkApplicationLogSampling
            /// </summary>
            public Union<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling, BaseFunction>? LinkApplicationLogSampling { get; set; }
        }

        public class LinkApplicationLogSampling : Humidifier.Base.BaseSubResource, IHaveFilterLog_Double, IHaveErrorLog_Double
        {
            /// <summary>
            /// FilterLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-inboundexternallink-linkapplicationlogsampling.html#cfn-rtbfabric-inboundexternallink-linkapplicationlogsampling-filterlog
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? FilterLog { get; set; }
            /// <summary>
            /// ErrorLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-inboundexternallink-linkapplicationlogsampling.html#cfn-rtbfabric-inboundexternallink-linkapplicationlogsampling-errorlog
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ErrorLog { get; set; }
        }

        public class LinkAttributes : Humidifier.Base.BaseSubResource, IHaveListOfRTBFabricInboundExternalLinkTypesResponderErrorMaskingForHttpCodeResponderErrorMasking, IHaveCustomerProvidedId
        {
            /// <summary>
            /// ResponderErrorMasking
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-inboundexternallink-linkattributes.html#cfn-rtbfabric-inboundexternallink-linkattributes-respondererrormasking
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: ResponderErrorMaskingForHttpCode
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RTBFabric.InboundExternalLinkTypes.ResponderErrorMaskingForHttpCode>, IReadOnlyList<Union<Humidifier.RTBFabric.InboundExternalLinkTypes.ResponderErrorMaskingForHttpCode, BaseFunction>>, BaseFunction>? ResponderErrorMasking { get; set; }
            /// <summary>
            /// CustomerProvidedId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-inboundexternallink-linkattributes.html#cfn-rtbfabric-inboundexternallink-linkattributes-customerprovidedid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomerProvidedId { get; set; }
        }

        public class LinkLogSettings : Humidifier.Base.BaseSubResource, IHaveRTBFabricInboundExternalLinkTypesApplicationLogsApplicationLogs
        {
            /// <summary>
            /// ApplicationLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-inboundexternallink-linklogsettings.html#cfn-rtbfabric-inboundexternallink-linklogsettings-applicationlogs
            /// Required: True
            /// UpdateType: Conditional
            /// Type: ApplicationLogs
            /// </summary>
            public Union<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs, BaseFunction>? ApplicationLogs { get; set; }
        }

        public class ResponderErrorMaskingForHttpCode : Humidifier.Base.BaseSubResource, IHaveHttpCode, IHaveAction, IHaveResponseLoggingPercentage_Double, IHaveStringListOfLoggingTypes
        {
            /// <summary>
            /// HttpCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-inboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-inboundexternallink-respondererrormaskingforhttpcode-httpcode
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpCode { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-inboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-inboundexternallink-respondererrormaskingforhttpcode-action
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// ResponseLoggingPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-inboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-inboundexternallink-respondererrormaskingforhttpcode-responseloggingpercentage
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ResponseLoggingPercentage { get; set; }
            /// <summary>
            /// LoggingTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-inboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-inboundexternallink-respondererrormaskingforhttpcode-loggingtypes
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LoggingTypes { get; set; }
        }
    }
}