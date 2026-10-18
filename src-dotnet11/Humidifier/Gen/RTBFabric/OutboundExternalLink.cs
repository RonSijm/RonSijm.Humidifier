namespace Humidifier.RTBFabric
{
    using global::System.Collections.Generic;
    using OutboundExternalLinkTypes;

    public class OutboundExternalLink : Humidifier.Base.BaseResource, IHaveTags, IHaveRTBFabricOutboundExternalLinkTypesLinkAttributesLinkAttributes, IHaveRTBFabricOutboundExternalLinkTypesLinkLogSettingsLinkLogSettings, IHavePublicEndpoint, IHaveGatewayId
    {
        public class Attributes
        {
            public static string LinkStatus =  "LinkStatus" ;
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string Arn =  "Arn" ;
            public static string LinkId =  "LinkId" ;
        }

        public override string AWSTypeName { get => AWS.RTBFabric.OutboundExternalLink; }
        /// <summary>
        /// LinkAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-outboundexternallink.html#cfn-rtbfabric-outboundexternallink-linkattributes
        /// Required: False
        /// UpdateType: Conditional
        /// Type: LinkAttributes
        /// </summary>
        public Union<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes, BaseFunction>? LinkAttributes { get; set; }

        /// <summary>
        /// LinkLogSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-outboundexternallink.html#cfn-rtbfabric-outboundexternallink-linklogsettings
        /// Required: True
        /// UpdateType: Conditional
        /// Type: LinkLogSettings
        /// </summary>
        [Required]
        public Union<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings, BaseFunction>? LinkLogSettings { get; set; }

        /// <summary>
        /// PublicEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-outboundexternallink.html#cfn-rtbfabric-outboundexternallink-publicendpoint
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PublicEndpoint { get; set; }

        /// <summary>
        /// GatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-outboundexternallink.html#cfn-rtbfabric-outboundexternallink-gatewayid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GatewayId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-outboundexternallink.html#cfn-rtbfabric-outboundexternallink-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace OutboundExternalLinkTypes
    {
        public class ApplicationLogs : Humidifier.Base.BaseSubResource, IHaveRTBFabricOutboundExternalLinkTypesLinkApplicationLogSamplingLinkApplicationLogSampling
        {
            /// <summary>
            /// LinkApplicationLogSampling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-applicationlogs.html#cfn-rtbfabric-outboundexternallink-applicationlogs-linkapplicationlogsampling
            /// Required: True
            /// UpdateType: Conditional
            /// Type: LinkApplicationLogSampling
            /// </summary>
            public Union<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling, BaseFunction>? LinkApplicationLogSampling { get; set; }
        }

        public class LinkApplicationLogSampling : Humidifier.Base.BaseSubResource, IHaveFilterLog_Double, IHaveErrorLog_Double
        {
            /// <summary>
            /// FilterLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-linkapplicationlogsampling.html#cfn-rtbfabric-outboundexternallink-linkapplicationlogsampling-filterlog
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? FilterLog { get; set; }
            /// <summary>
            /// ErrorLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-linkapplicationlogsampling.html#cfn-rtbfabric-outboundexternallink-linkapplicationlogsampling-errorlog
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ErrorLog { get; set; }
        }

        public class LinkAttributes : Humidifier.Base.BaseSubResource, IHaveListOfRTBFabricOutboundExternalLinkTypesResponderErrorMaskingForHttpCodeResponderErrorMasking, IHaveCustomerProvidedId
        {
            /// <summary>
            /// ResponderErrorMasking
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-linkattributes.html#cfn-rtbfabric-outboundexternallink-linkattributes-respondererrormasking
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: ResponderErrorMaskingForHttpCode
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RTBFabric.OutboundExternalLinkTypes.ResponderErrorMaskingForHttpCode>, IReadOnlyList<Union<Humidifier.RTBFabric.OutboundExternalLinkTypes.ResponderErrorMaskingForHttpCode, BaseFunction>>, BaseFunction>? ResponderErrorMasking { get; set; }
            /// <summary>
            /// CustomerProvidedId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-linkattributes.html#cfn-rtbfabric-outboundexternallink-linkattributes-customerprovidedid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomerProvidedId { get; set; }
        }

        public class LinkLogSettings : Humidifier.Base.BaseSubResource, IHaveRTBFabricOutboundExternalLinkTypesApplicationLogsApplicationLogs
        {
            /// <summary>
            /// ApplicationLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-linklogsettings.html#cfn-rtbfabric-outboundexternallink-linklogsettings-applicationlogs
            /// Required: True
            /// UpdateType: Conditional
            /// Type: ApplicationLogs
            /// </summary>
            public Union<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs, BaseFunction>? ApplicationLogs { get; set; }
        }

        public class ResponderErrorMaskingForHttpCode : Humidifier.Base.BaseSubResource, IHaveHttpCode, IHaveAction, IHaveResponseLoggingPercentage_Double, IHaveStringListOfLoggingTypes
        {
            /// <summary>
            /// HttpCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode-httpcode
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpCode { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode-action
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// ResponseLoggingPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode-responseloggingpercentage
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ResponseLoggingPercentage { get; set; }
            /// <summary>
            /// LoggingTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode-loggingtypes
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LoggingTypes { get; set; }
        }
    }
}