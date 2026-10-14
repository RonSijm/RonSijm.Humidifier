namespace Humidifier.RTBFabric
{
    using global::System.Collections.Generic;
    using OutboundExternalLinkTypes;

    public class OutboundExternalLink : Humidifier.Base.BaseResource, IHaveTags, IHaveGatewayId
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
        public Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes LinkAttributes { get; set; }

        /// <summary>
        /// LinkLogSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-outboundexternallink.html#cfn-rtbfabric-outboundexternallink-linklogsettings
        /// Required: True
        /// UpdateType: Conditional
        /// Type: LinkLogSettings
        /// </summary>
        [Required]
        public Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings LinkLogSettings { get; set; }

        /// <summary>
        /// PublicEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-outboundexternallink.html#cfn-rtbfabric-outboundexternallink-publicendpoint
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PublicEndpoint { get; set; }

        /// <summary>
        /// GatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-outboundexternallink.html#cfn-rtbfabric-outboundexternallink-gatewayid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GatewayId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-outboundexternallink.html#cfn-rtbfabric-outboundexternallink-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace OutboundExternalLinkTypes
    {
        public class ApplicationLogs : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LinkApplicationLogSampling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-applicationlogs.html#cfn-rtbfabric-outboundexternallink-applicationlogs-linkapplicationlogsampling
            /// Required: True
            /// UpdateType: Conditional
            /// Type: LinkApplicationLogSampling
            /// </summary>
            public Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling LinkApplicationLogSampling { get; set; }
        }

        public class LinkApplicationLogSampling : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FilterLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-linkapplicationlogsampling.html#cfn-rtbfabric-outboundexternallink-linkapplicationlogsampling-filterlog
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public dynamic FilterLog { get; set; }
            /// <summary>
            /// ErrorLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-linkapplicationlogsampling.html#cfn-rtbfabric-outboundexternallink-linkapplicationlogsampling-errorlog
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ErrorLog { get; set; }
        }

        public class LinkAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResponderErrorMasking
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-linkattributes.html#cfn-rtbfabric-outboundexternallink-linkattributes-respondererrormasking
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: ResponderErrorMaskingForHttpCode
            /// </summary>
            public List<Humidifier.RTBFabric.OutboundExternalLinkTypes.ResponderErrorMaskingForHttpCode> ResponderErrorMasking { get; set; }
            /// <summary>
            /// CustomerProvidedId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-linkattributes.html#cfn-rtbfabric-outboundexternallink-linkattributes-customerprovidedid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomerProvidedId { get; set; }
        }

        public class LinkLogSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApplicationLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-linklogsettings.html#cfn-rtbfabric-outboundexternallink-linklogsettings-applicationlogs
            /// Required: True
            /// UpdateType: Conditional
            /// Type: ApplicationLogs
            /// </summary>
            public Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs ApplicationLogs { get; set; }
        }

        public class ResponderErrorMaskingForHttpCode : Humidifier.Base.BaseSubResource, IHaveAction, IHaveHttpCode
        {
            /// <summary>
            /// HttpCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode-httpcode
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpCode { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode-action
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// ResponseLoggingPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode-responseloggingpercentage
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ResponseLoggingPercentage { get; set; }
            /// <summary>
            /// LoggingTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode.html#cfn-rtbfabric-outboundexternallink-respondererrormaskingforhttpcode-loggingtypes
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LoggingTypes { get; set; }
        }
    }
}