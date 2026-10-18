namespace Humidifier.RTBFabric
{
    using global::System.Collections.Generic;
    using LinkTypes;

    public class Link : Humidifier.Base.BaseResource, IHaveTags, IHaveRTBFabricLinkTypesLinkAttributesLinkAttributes, IHaveListOfRTBFabricLinkTypesModuleConfigurationModuleConfigurationList, IHaveHttpResponderAllowed_Boolean, IHaveRTBFabricLinkTypesLinkLogSettingsLinkLogSettings, IHavePeerGatewayId, IHaveGatewayId
    {
        public class Attributes
        {
            public static string LinkStatus =  "LinkStatus" ;
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string LinkDirection =  "LinkDirection" ;
            public static string Arn =  "Arn" ;
            public static string LinkId =  "LinkId" ;
        }

        public override string AWSTypeName { get => AWS.RTBFabric.Link; }
        /// <summary>
        /// LinkAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-link.html#cfn-rtbfabric-link-linkattributes
        /// Required: False
        /// UpdateType: Conditional
        /// Type: LinkAttributes
        /// </summary>
        public Union<Humidifier.RTBFabric.LinkTypes.LinkAttributes, BaseFunction>? LinkAttributes { get; set; }
        /// <summary>
        /// ModuleConfigurationList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-link.html#cfn-rtbfabric-link-moduleconfigurationlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ModuleConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration>, IReadOnlyList<Union<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration, BaseFunction>>, BaseFunction>? ModuleConfigurationList { get; set; }
        /// <summary>
        /// HttpResponderAllowed
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-link.html#cfn-rtbfabric-link-httpresponderallowed
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? HttpResponderAllowed { get; set; }

        /// <summary>
        /// LinkLogSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-link.html#cfn-rtbfabric-link-linklogsettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: LinkLogSettings
        /// </summary>
        [Required]
        public Union<Humidifier.RTBFabric.LinkTypes.LinkLogSettings, BaseFunction>? LinkLogSettings { get; set; }

        /// <summary>
        /// PeerGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-link.html#cfn-rtbfabric-link-peergatewayid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PeerGatewayId { get; set; }

        /// <summary>
        /// GatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-link.html#cfn-rtbfabric-link-gatewayid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GatewayId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-link.html#cfn-rtbfabric-link-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace LinkTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveRTBFabricLinkTypesNoBidActionNoBid, IHaveRTBFabricLinkTypesHeaderTagActionHeaderTag
        {
            /// <summary>
            /// NoBid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-action.html#cfn-rtbfabric-link-action-nobid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoBidAction
            /// </summary>
            public Union<Humidifier.RTBFabric.LinkTypes.NoBidAction, BaseFunction>? NoBid { get; set; }
            /// <summary>
            /// HeaderTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-action.html#cfn-rtbfabric-link-action-headertag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeaderTagAction
            /// </summary>
            public Union<Humidifier.RTBFabric.LinkTypes.HeaderTagAction, BaseFunction>? HeaderTag { get; set; }
        }

        public class ApplicationLogs : Humidifier.Base.BaseSubResource, IHaveRTBFabricLinkTypesLinkApplicationLogSamplingLinkApplicationLogSampling
        {
            /// <summary>
            /// LinkApplicationLogSampling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-applicationlogs.html#cfn-rtbfabric-link-applicationlogs-linkapplicationlogsampling
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LinkApplicationLogSampling
            /// </summary>
            public Union<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling, BaseFunction>? LinkApplicationLogSampling { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveListOfRTBFabricLinkTypesFilterCriterionCriteria
        {
            /// <summary>
            /// Criteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-filter.html#cfn-rtbfabric-link-filter-criteria
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterCriterion
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RTBFabric.LinkTypes.FilterCriterion>, IReadOnlyList<Union<Humidifier.RTBFabric.LinkTypes.FilterCriterion, BaseFunction>>, BaseFunction>? Criteria { get; set; }
        }

        public class FilterCriterion : Humidifier.Base.BaseSubResource, IHavePath, IHaveStringListOfValues
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-filtercriterion.html#cfn-rtbfabric-link-filtercriterion-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-filtercriterion.html#cfn-rtbfabric-link-filtercriterion-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class HeaderTagAction : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-headertagaction.html#cfn-rtbfabric-link-headertagaction-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-headertagaction.html#cfn-rtbfabric-link-headertagaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LinkApplicationLogSampling : Humidifier.Base.BaseSubResource, IHaveFilterLog_Double, IHaveErrorLog_Double
        {
            /// <summary>
            /// FilterLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-linkapplicationlogsampling.html#cfn-rtbfabric-link-linkapplicationlogsampling-filterlog
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? FilterLog { get; set; }
            /// <summary>
            /// ErrorLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-linkapplicationlogsampling.html#cfn-rtbfabric-link-linkapplicationlogsampling-errorlog
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ErrorLog { get; set; }
        }

        public class LinkAttributes : Humidifier.Base.BaseSubResource, IHaveListOfRTBFabricLinkTypesResponderErrorMaskingForHttpCodeResponderErrorMasking, IHaveCustomerProvidedId
        {
            /// <summary>
            /// ResponderErrorMasking
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-linkattributes.html#cfn-rtbfabric-link-linkattributes-respondererrormasking
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: ResponderErrorMaskingForHttpCode
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RTBFabric.LinkTypes.ResponderErrorMaskingForHttpCode>, IReadOnlyList<Union<Humidifier.RTBFabric.LinkTypes.ResponderErrorMaskingForHttpCode, BaseFunction>>, BaseFunction>? ResponderErrorMasking { get; set; }
            /// <summary>
            /// CustomerProvidedId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-linkattributes.html#cfn-rtbfabric-link-linkattributes-customerprovidedid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomerProvidedId { get; set; }
        }

        public class LinkLogSettings : Humidifier.Base.BaseSubResource, IHaveRTBFabricLinkTypesApplicationLogsApplicationLogs
        {
            /// <summary>
            /// ApplicationLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-linklogsettings.html#cfn-rtbfabric-link-linklogsettings-applicationlogs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ApplicationLogs
            /// </summary>
            public Union<Humidifier.RTBFabric.LinkTypes.ApplicationLogs, BaseFunction>? ApplicationLogs { get; set; }
        }

        public class ModuleConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfDependsOn, IHaveVersion, IHaveRTBFabricLinkTypesModuleParametersModuleParameters, IHaveName
        {
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-moduleconfiguration.html#cfn-rtbfabric-link-moduleconfiguration-dependson
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DependsOn { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-moduleconfiguration.html#cfn-rtbfabric-link-moduleconfiguration-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// ModuleParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-moduleconfiguration.html#cfn-rtbfabric-link-moduleconfiguration-moduleparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModuleParameters
            /// </summary>
            public Union<Humidifier.RTBFabric.LinkTypes.ModuleParameters, BaseFunction>? ModuleParameters { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-moduleconfiguration.html#cfn-rtbfabric-link-moduleconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ModuleParameters : Humidifier.Base.BaseSubResource, IHaveRTBFabricLinkTypesNoBidModuleParametersNoBid, IHaveRTBFabricLinkTypesOpenRtbAttributeModuleParametersOpenRtbAttribute
        {
            /// <summary>
            /// NoBid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-moduleparameters.html#cfn-rtbfabric-link-moduleparameters-nobid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoBidModuleParameters
            /// </summary>
            public Union<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters, BaseFunction>? NoBid { get; set; }
            /// <summary>
            /// OpenRtbAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-moduleparameters.html#cfn-rtbfabric-link-moduleparameters-openrtbattribute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenRtbAttributeModuleParameters
            /// </summary>
            public Union<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters, BaseFunction>? OpenRtbAttribute { get; set; }
        }

        public class NoBidAction : Humidifier.Base.BaseSubResource, IHaveNoBidReasonCode_Integer
        {
            /// <summary>
            /// NoBidReasonCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-nobidaction.html#cfn-rtbfabric-link-nobidaction-nobidreasoncode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NoBidReasonCode { get; set; }
        }

        public class NoBidModuleParameters : Humidifier.Base.BaseSubResource, IHavePassThroughPercentage_Double, IHaveReasonCode_Integer, IHaveReason
        {
            /// <summary>
            /// PassThroughPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-nobidmoduleparameters.html#cfn-rtbfabric-link-nobidmoduleparameters-passthroughpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PassThroughPercentage { get; set; }
            /// <summary>
            /// ReasonCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-nobidmoduleparameters.html#cfn-rtbfabric-link-nobidmoduleparameters-reasoncode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReasonCode { get; set; }
            /// <summary>
            /// Reason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-nobidmoduleparameters.html#cfn-rtbfabric-link-nobidmoduleparameters-reason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Reason { get; set; }
        }

        public class OpenRtbAttributeModuleParameters : Humidifier.Base.BaseSubResource, IHaveFilterType, IHaveRTBFabricLinkTypesActionAction, IHaveHoldbackPercentage_Double, IHaveListOfRTBFabricLinkTypesFilterFilterConfiguration
        {
            /// <summary>
            /// FilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-openrtbattributemoduleparameters.html#cfn-rtbfabric-link-openrtbattributemoduleparameters-filtertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterType { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-openrtbattributemoduleparameters.html#cfn-rtbfabric-link-openrtbattributemoduleparameters-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Action
            /// </summary>
            public Union<Humidifier.RTBFabric.LinkTypes.Action, BaseFunction>? Action { get; set; }
            /// <summary>
            /// HoldbackPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-openrtbattributemoduleparameters.html#cfn-rtbfabric-link-openrtbattributemoduleparameters-holdbackpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? HoldbackPercentage { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-openrtbattributemoduleparameters.html#cfn-rtbfabric-link-openrtbattributemoduleparameters-filterconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RTBFabric.LinkTypes.Filter>, IReadOnlyList<Union<Humidifier.RTBFabric.LinkTypes.Filter, BaseFunction>>, BaseFunction>? FilterConfiguration { get; set; }
        }

        public class ResponderErrorMaskingForHttpCode : Humidifier.Base.BaseSubResource, IHaveHttpCode, IHaveAction, IHaveResponseLoggingPercentage_Double, IHaveStringListOfLoggingTypes
        {
            /// <summary>
            /// HttpCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-respondererrormaskingforhttpcode.html#cfn-rtbfabric-link-respondererrormaskingforhttpcode-httpcode
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpCode { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-respondererrormaskingforhttpcode.html#cfn-rtbfabric-link-respondererrormaskingforhttpcode-action
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// ResponseLoggingPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-respondererrormaskingforhttpcode.html#cfn-rtbfabric-link-respondererrormaskingforhttpcode-responseloggingpercentage
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ResponseLoggingPercentage { get; set; }
            /// <summary>
            /// LoggingTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-link-respondererrormaskingforhttpcode.html#cfn-rtbfabric-link-respondererrormaskingforhttpcode-loggingtypes
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LoggingTypes { get; set; }
        }
    }
}