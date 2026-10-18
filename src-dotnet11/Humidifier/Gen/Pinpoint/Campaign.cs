namespace Humidifier.Pinpoint
{
    using global::System.Collections.Generic;
    using CampaignTypes;

    public class Campaign : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveSegmentId, IHavePriority_Integer, IHavePinpointCampaignTypesTemplateConfigurationTemplateConfiguration, IHaveIsPaused_Boolean, IHaveListOfPinpointCampaignTypesWriteTreatmentResourceAdditionalTreatments, IHaveName, IHaveSegmentVersion_Integer, IHaveTreatmentDescription, IHavePinpointCampaignTypesMessageConfigurationMessageConfiguration, IHavePinpointCampaignTypesLimitsLimits, IHaveHoldoutPercent_Integer, IHavePinpointCampaignTypesScheduleSchedule, IHavePinpointCampaignTypesCustomDeliveryConfigurationCustomDeliveryConfiguration, IHaveApplicationId, IHavePinpointCampaignTypesCampaignHookCampaignHook, IHaveTags_Json, IHaveTreatmentName
    {
        public class Attributes
        {
            public static string CampaignId =  "CampaignId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Pinpoint.Campaign; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// SegmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-segmentid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SegmentId { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-priority
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// TemplateConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-templateconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TemplateConfiguration
        /// </summary>
        public Union<Humidifier.Pinpoint.CampaignTypes.TemplateConfiguration, BaseFunction>? TemplateConfiguration { get; set; }
        /// <summary>
        /// IsPaused
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-ispaused
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsPaused { get; set; }
        /// <summary>
        /// AdditionalTreatments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-additionaltreatments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: WriteTreatmentResource
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Pinpoint.CampaignTypes.WriteTreatmentResource>, IReadOnlyList<Union<Humidifier.Pinpoint.CampaignTypes.WriteTreatmentResource, BaseFunction>>, BaseFunction>? AdditionalTreatments { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SegmentVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-segmentversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SegmentVersion { get; set; }
        /// <summary>
        /// TreatmentDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-treatmentdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TreatmentDescription { get; set; }
        /// <summary>
        /// MessageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-messageconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MessageConfiguration
        /// </summary>
        public Union<Humidifier.Pinpoint.CampaignTypes.MessageConfiguration, BaseFunction>? MessageConfiguration { get; set; }
        /// <summary>
        /// Limits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-limits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Limits
        /// </summary>
        public Union<Humidifier.Pinpoint.CampaignTypes.Limits, BaseFunction>? Limits { get; set; }
        /// <summary>
        /// HoldoutPercent
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-holdoutpercent
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? HoldoutPercent { get; set; }

        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-schedule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        [Required]
        public Union<Humidifier.Pinpoint.CampaignTypes.Schedule, BaseFunction>? Schedule { get; set; }
        /// <summary>
        /// CustomDeliveryConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-customdeliveryconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomDeliveryConfiguration
        /// </summary>
        public Union<Humidifier.Pinpoint.CampaignTypes.CustomDeliveryConfiguration, BaseFunction>? CustomDeliveryConfiguration { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// CampaignHook
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-campaignhook
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CampaignHook
        /// </summary>
        public Union<Humidifier.Pinpoint.CampaignTypes.CampaignHook, BaseFunction>? CampaignHook { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TreatmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-treatmentname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TreatmentName { get; set; }
    }

    namespace CampaignTypes
    {
        public class AttributeDimension : Humidifier.Base.BaseSubResource, IHaveAttributeType, IHaveStringListOfValues
        {
            /// <summary>
            /// AttributeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-attributedimension.html#cfn-pinpoint-campaign-attributedimension-attributetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-attributedimension.html#cfn-pinpoint-campaign-attributedimension-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class CampaignCustomMessage : Humidifier.Base.BaseSubResource, IHaveData
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaigncustommessage.html#cfn-pinpoint-campaign-campaigncustommessage-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
        }

        public class CampaignEmailMessage : Humidifier.Base.BaseSubResource, IHaveFromAddress, IHaveHtmlBody, IHaveTitle, IHaveBody
        {
            /// <summary>
            /// FromAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignemailmessage.html#cfn-pinpoint-campaign-campaignemailmessage-fromaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FromAddress { get; set; }
            /// <summary>
            /// HtmlBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignemailmessage.html#cfn-pinpoint-campaign-campaignemailmessage-htmlbody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HtmlBody { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignemailmessage.html#cfn-pinpoint-campaign-campaignemailmessage-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignemailmessage.html#cfn-pinpoint-campaign-campaignemailmessage-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Body { get; set; }
        }

        public class CampaignEventFilter : Humidifier.Base.BaseSubResource, IHaveFilterType, IHavePinpointCampaignTypesEventDimensionsDimensions
        {
            /// <summary>
            /// FilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaigneventfilter.html#cfn-pinpoint-campaign-campaigneventfilter-filtertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterType { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaigneventfilter.html#cfn-pinpoint-campaign-campaigneventfilter-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventDimensions
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.EventDimensions, BaseFunction>? Dimensions { get; set; }
        }

        public class CampaignHook : Humidifier.Base.BaseSubResource, IHaveMode, IHaveWebUrl, IHaveLambdaFunctionName
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignhook.html#cfn-pinpoint-campaign-campaignhook-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// WebUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignhook.html#cfn-pinpoint-campaign-campaignhook-weburl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WebUrl { get; set; }
            /// <summary>
            /// LambdaFunctionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignhook.html#cfn-pinpoint-campaign-campaignhook-lambdafunctionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaFunctionName { get; set; }
        }

        public class CampaignInAppMessage : Humidifier.Base.BaseSubResource, IHaveCustomConfig_Json, IHaveLayout, IHaveListOfPinpointCampaignTypesInAppMessageContentContent
        {
            /// <summary>
            /// CustomConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaigninappmessage.html#cfn-pinpoint-campaign-campaigninappmessage-customconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? CustomConfig { get; set; }
            /// <summary>
            /// Layout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaigninappmessage.html#cfn-pinpoint-campaign-campaigninappmessage-layout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Layout { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaigninappmessage.html#cfn-pinpoint-campaign-campaigninappmessage-content
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InAppMessageContent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pinpoint.CampaignTypes.InAppMessageContent>, IReadOnlyList<Union<Humidifier.Pinpoint.CampaignTypes.InAppMessageContent, BaseFunction>>, BaseFunction>? Content { get; set; }
        }

        public class CampaignSmsMessage : Humidifier.Base.BaseSubResource, IHaveEntityId, IHaveOriginationNumber, IHaveSenderId, IHaveBody, IHaveMessageType, IHaveTemplateId
        {
            /// <summary>
            /// EntityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignsmsmessage.html#cfn-pinpoint-campaign-campaignsmsmessage-entityid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityId { get; set; }
            /// <summary>
            /// OriginationNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignsmsmessage.html#cfn-pinpoint-campaign-campaignsmsmessage-originationnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginationNumber { get; set; }
            /// <summary>
            /// SenderId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignsmsmessage.html#cfn-pinpoint-campaign-campaignsmsmessage-senderid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SenderId { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignsmsmessage.html#cfn-pinpoint-campaign-campaignsmsmessage-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Body { get; set; }
            /// <summary>
            /// MessageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignsmsmessage.html#cfn-pinpoint-campaign-campaignsmsmessage-messagetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageType { get; set; }
            /// <summary>
            /// TemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignsmsmessage.html#cfn-pinpoint-campaign-campaignsmsmessage-templateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateId { get; set; }
        }

        public class CustomDeliveryConfiguration : Humidifier.Base.BaseSubResource, IHaveDeliveryUri, IHaveStringListOfEndpointTypes
        {
            /// <summary>
            /// DeliveryUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-customdeliveryconfiguration.html#cfn-pinpoint-campaign-customdeliveryconfiguration-deliveryuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryUri { get; set; }
            /// <summary>
            /// EndpointTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-customdeliveryconfiguration.html#cfn-pinpoint-campaign-customdeliveryconfiguration-endpointtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EndpointTypes { get; set; }
        }

        public class DefaultButtonConfiguration : Humidifier.Base.BaseSubResource, IHaveButtonAction, IHaveBorderRadius_Integer, IHaveText, IHaveTextColor, IHaveLink, IHaveBackgroundColor
        {
            /// <summary>
            /// ButtonAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-defaultbuttonconfiguration.html#cfn-pinpoint-campaign-defaultbuttonconfiguration-buttonaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ButtonAction { get; set; }
            /// <summary>
            /// BorderRadius
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-defaultbuttonconfiguration.html#cfn-pinpoint-campaign-defaultbuttonconfiguration-borderradius
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BorderRadius { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-defaultbuttonconfiguration.html#cfn-pinpoint-campaign-defaultbuttonconfiguration-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-defaultbuttonconfiguration.html#cfn-pinpoint-campaign-defaultbuttonconfiguration-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextColor { get; set; }
            /// <summary>
            /// Link
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-defaultbuttonconfiguration.html#cfn-pinpoint-campaign-defaultbuttonconfiguration-link
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Link { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-defaultbuttonconfiguration.html#cfn-pinpoint-campaign-defaultbuttonconfiguration-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BackgroundColor { get; set; }
        }

        public class EventDimensions : Humidifier.Base.BaseSubResource, IHaveMetrics_Json, IHavePinpointCampaignTypesSetDimensionEventType, IHaveAttributes__Json
        {
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-eventdimensions.html#cfn-pinpoint-campaign-eventdimensions-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Metrics { get; set; }
            /// <summary>
            /// EventType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-eventdimensions.html#cfn-pinpoint-campaign-eventdimensions-eventtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.SetDimension, BaseFunction>? EventType { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-eventdimensions.html#cfn-pinpoint-campaign-eventdimensions-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Attributes_ { get; set; }
        }

        public class InAppMessageBodyConfig : Humidifier.Base.BaseSubResource, IHaveAlignment, IHaveTextColor, IHaveBody
        {
            /// <summary>
            /// Alignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagebodyconfig.html#cfn-pinpoint-campaign-inappmessagebodyconfig-alignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alignment { get; set; }
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagebodyconfig.html#cfn-pinpoint-campaign-inappmessagebodyconfig-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextColor { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagebodyconfig.html#cfn-pinpoint-campaign-inappmessagebodyconfig-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Body { get; set; }
        }

        public class InAppMessageButton : Humidifier.Base.BaseSubResource, IHavePinpointCampaignTypesOverrideButtonConfigurationWeb, IHavePinpointCampaignTypesDefaultButtonConfigurationDefaultConfig, IHavePinpointCampaignTypesOverrideButtonConfigurationIOS, IHavePinpointCampaignTypesOverrideButtonConfigurationAndroid
        {
            /// <summary>
            /// Web
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagebutton.html#cfn-pinpoint-campaign-inappmessagebutton-web
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OverrideButtonConfiguration
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.OverrideButtonConfiguration, BaseFunction>? Web { get; set; }
            /// <summary>
            /// DefaultConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagebutton.html#cfn-pinpoint-campaign-inappmessagebutton-defaultconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultButtonConfiguration
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.DefaultButtonConfiguration, BaseFunction>? DefaultConfig { get; set; }
            /// <summary>
            /// IOS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagebutton.html#cfn-pinpoint-campaign-inappmessagebutton-ios
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OverrideButtonConfiguration
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.OverrideButtonConfiguration, BaseFunction>? IOS { get; set; }
            /// <summary>
            /// Android
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagebutton.html#cfn-pinpoint-campaign-inappmessagebutton-android
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OverrideButtonConfiguration
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.OverrideButtonConfiguration, BaseFunction>? Android { get; set; }
        }

        public class InAppMessageContent : Humidifier.Base.BaseSubResource, IHavePinpointCampaignTypesInAppMessageBodyConfigBodyConfig, IHavePinpointCampaignTypesInAppMessageButtonSecondaryBtn, IHaveImageUrl, IHavePinpointCampaignTypesInAppMessageButtonPrimaryBtn, IHavePinpointCampaignTypesInAppMessageHeaderConfigHeaderConfig, IHaveBackgroundColor
        {
            /// <summary>
            /// BodyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagecontent.html#cfn-pinpoint-campaign-inappmessagecontent-bodyconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InAppMessageBodyConfig
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.InAppMessageBodyConfig, BaseFunction>? BodyConfig { get; set; }
            /// <summary>
            /// SecondaryBtn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagecontent.html#cfn-pinpoint-campaign-inappmessagecontent-secondarybtn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InAppMessageButton
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.InAppMessageButton, BaseFunction>? SecondaryBtn { get; set; }
            /// <summary>
            /// ImageUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagecontent.html#cfn-pinpoint-campaign-inappmessagecontent-imageurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUrl { get; set; }
            /// <summary>
            /// PrimaryBtn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagecontent.html#cfn-pinpoint-campaign-inappmessagecontent-primarybtn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InAppMessageButton
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.InAppMessageButton, BaseFunction>? PrimaryBtn { get; set; }
            /// <summary>
            /// HeaderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagecontent.html#cfn-pinpoint-campaign-inappmessagecontent-headerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InAppMessageHeaderConfig
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.InAppMessageHeaderConfig, BaseFunction>? HeaderConfig { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessagecontent.html#cfn-pinpoint-campaign-inappmessagecontent-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BackgroundColor { get; set; }
        }

        public class InAppMessageHeaderConfig : Humidifier.Base.BaseSubResource, IHaveAlignment, IHaveHeader, IHaveTextColor
        {
            /// <summary>
            /// Alignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessageheaderconfig.html#cfn-pinpoint-campaign-inappmessageheaderconfig-alignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alignment { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessageheaderconfig.html#cfn-pinpoint-campaign-inappmessageheaderconfig-header
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Header { get; set; }
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-inappmessageheaderconfig.html#cfn-pinpoint-campaign-inappmessageheaderconfig-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextColor { get; set; }
        }

        public class Limits : Humidifier.Base.BaseSubResource, IHaveDaily_Integer, IHaveMaximumDuration_Integer, IHaveTotal_Integer, IHaveMessagesPerSecond_Integer, IHaveSession_Integer
        {
            /// <summary>
            /// Daily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-limits.html#cfn-pinpoint-campaign-limits-daily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Daily { get; set; }
            /// <summary>
            /// MaximumDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-limits.html#cfn-pinpoint-campaign-limits-maximumduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumDuration { get; set; }
            /// <summary>
            /// Total
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-limits.html#cfn-pinpoint-campaign-limits-total
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Total { get; set; }
            /// <summary>
            /// MessagesPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-limits.html#cfn-pinpoint-campaign-limits-messagespersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MessagesPerSecond { get; set; }
            /// <summary>
            /// Session
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-limits.html#cfn-pinpoint-campaign-limits-session
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Session { get; set; }
        }

        public class Message : Humidifier.Base.BaseSubResource, IHaveJsonBody, IHaveAction, IHaveMediaUrl, IHaveTimeToLive_Integer, IHaveImageSmallIconUrl, IHaveImageUrl, IHaveTitle, IHaveImageIconUrl, IHaveSilentPush_Boolean, IHaveBody, IHaveRawContent, IHaveUrl
        {
            /// <summary>
            /// JsonBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-jsonbody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JsonBody { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// MediaUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-mediaurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaUrl { get; set; }
            /// <summary>
            /// TimeToLive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-timetolive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeToLive { get; set; }
            /// <summary>
            /// ImageSmallIconUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-imagesmalliconurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageSmallIconUrl { get; set; }
            /// <summary>
            /// ImageUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-imageurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUrl { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// ImageIconUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-imageiconurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageIconUrl { get; set; }
            /// <summary>
            /// SilentPush
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-silentpush
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SilentPush { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Body { get; set; }
            /// <summary>
            /// RawContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-rawcontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RawContent { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class MessageConfiguration : Humidifier.Base.BaseSubResource, IHavePinpointCampaignTypesMessageAPNSMessage, IHavePinpointCampaignTypesMessageBaiduMessage, IHavePinpointCampaignTypesMessageDefaultMessage, IHavePinpointCampaignTypesCampaignInAppMessageInAppMessage, IHavePinpointCampaignTypesCampaignEmailMessageEmailMessage, IHavePinpointCampaignTypesMessageGCMMessage, IHavePinpointCampaignTypesCampaignSmsMessageSMSMessage, IHavePinpointCampaignTypesCampaignCustomMessageCustomMessage, IHavePinpointCampaignTypesMessageADMMessage
        {
            /// <summary>
            /// APNSMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-apnsmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.Message, BaseFunction>? APNSMessage { get; set; }
            /// <summary>
            /// BaiduMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-baidumessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.Message, BaseFunction>? BaiduMessage { get; set; }
            /// <summary>
            /// DefaultMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-defaultmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.Message, BaseFunction>? DefaultMessage { get; set; }
            /// <summary>
            /// InAppMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-inappmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CampaignInAppMessage
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.CampaignInAppMessage, BaseFunction>? InAppMessage { get; set; }
            /// <summary>
            /// EmailMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-emailmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CampaignEmailMessage
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.CampaignEmailMessage, BaseFunction>? EmailMessage { get; set; }
            /// <summary>
            /// GCMMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-gcmmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.Message, BaseFunction>? GCMMessage { get; set; }
            /// <summary>
            /// SMSMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-smsmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CampaignSmsMessage
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.CampaignSmsMessage, BaseFunction>? SMSMessage { get; set; }
            /// <summary>
            /// CustomMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-custommessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CampaignCustomMessage
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.CampaignCustomMessage, BaseFunction>? CustomMessage { get; set; }
            /// <summary>
            /// ADMMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-admmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.Message, BaseFunction>? ADMMessage { get; set; }
        }

        public class MetricDimension : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveValue_Double
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-metricdimension.html#cfn-pinpoint-campaign-metricdimension-comparisonoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-metricdimension.html#cfn-pinpoint-campaign-metricdimension-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
        }

        public class OverrideButtonConfiguration : Humidifier.Base.BaseSubResource, IHaveButtonAction, IHaveLink
        {
            /// <summary>
            /// ButtonAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-overridebuttonconfiguration.html#cfn-pinpoint-campaign-overridebuttonconfiguration-buttonaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ButtonAction { get; set; }
            /// <summary>
            /// Link
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-overridebuttonconfiguration.html#cfn-pinpoint-campaign-overridebuttonconfiguration-link
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Link { get; set; }
        }

        public class QuietTime : Humidifier.Base.BaseSubResource, IHaveStart, IHaveEnd
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule-quiettime.html#cfn-pinpoint-campaign-schedule-quiettime-start
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule-quiettime.html#cfn-pinpoint-campaign-schedule-quiettime-end
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? End { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveTimeZone, IHavePinpointCampaignTypesQuietTimeQuietTime, IHaveEndTime, IHaveStartTime, IHaveFrequency, IHavePinpointCampaignTypesCampaignEventFilterEventFilter, IHaveIsLocalTime_Boolean
        {
            /// <summary>
            /// TimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeZone { get; set; }
            /// <summary>
            /// QuietTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-quiettime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QuietTime
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.QuietTime, BaseFunction>? QuietTime { get; set; }
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-endtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// Frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-frequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Frequency { get; set; }
            /// <summary>
            /// EventFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-eventfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CampaignEventFilter
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter, BaseFunction>? EventFilter { get; set; }
            /// <summary>
            /// IsLocalTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-islocaltime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsLocalTime { get; set; }
        }

        public class SetDimension : Humidifier.Base.BaseSubResource, IHaveDimensionType, IHaveStringListOfValues
        {
            /// <summary>
            /// DimensionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-setdimension.html#cfn-pinpoint-campaign-setdimension-dimensiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DimensionType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-setdimension.html#cfn-pinpoint-campaign-setdimension-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class Template : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveName
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-template.html#cfn-pinpoint-campaign-template-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-template.html#cfn-pinpoint-campaign-template-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TemplateConfiguration : Humidifier.Base.BaseSubResource, IHavePinpointCampaignTypesTemplateSMSTemplate, IHavePinpointCampaignTypesTemplateEmailTemplate, IHavePinpointCampaignTypesTemplatePushTemplate, IHavePinpointCampaignTypesTemplateVoiceTemplate
        {
            /// <summary>
            /// SMSTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-templateconfiguration.html#cfn-pinpoint-campaign-templateconfiguration-smstemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Template
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.Template, BaseFunction>? SMSTemplate { get; set; }
            /// <summary>
            /// EmailTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-templateconfiguration.html#cfn-pinpoint-campaign-templateconfiguration-emailtemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Template
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.Template, BaseFunction>? EmailTemplate { get; set; }
            /// <summary>
            /// PushTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-templateconfiguration.html#cfn-pinpoint-campaign-templateconfiguration-pushtemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Template
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.Template, BaseFunction>? PushTemplate { get; set; }
            /// <summary>
            /// VoiceTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-templateconfiguration.html#cfn-pinpoint-campaign-templateconfiguration-voicetemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Template
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.Template, BaseFunction>? VoiceTemplate { get; set; }
        }

        public class WriteTreatmentResource : Humidifier.Base.BaseSubResource, IHaveTreatmentDescription, IHavePinpointCampaignTypesMessageConfigurationMessageConfiguration, IHavePinpointCampaignTypesScheduleSchedule, IHavePinpointCampaignTypesTemplateConfigurationTemplateConfiguration, IHavePinpointCampaignTypesCustomDeliveryConfigurationCustomDeliveryConfiguration, IHaveSizePercent_Integer, IHaveTreatmentName
        {
            /// <summary>
            /// TreatmentDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-treatmentdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TreatmentDescription { get; set; }
            /// <summary>
            /// MessageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-messageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MessageConfiguration
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.MessageConfiguration, BaseFunction>? MessageConfiguration { get; set; }
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-schedule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Schedule
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.Schedule, BaseFunction>? Schedule { get; set; }
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-templateconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TemplateConfiguration
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.TemplateConfiguration, BaseFunction>? TemplateConfiguration { get; set; }
            /// <summary>
            /// CustomDeliveryConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-customdeliveryconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomDeliveryConfiguration
            /// </summary>
            public Union<Humidifier.Pinpoint.CampaignTypes.CustomDeliveryConfiguration, BaseFunction>? CustomDeliveryConfiguration { get; set; }
            /// <summary>
            /// SizePercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-sizepercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizePercent { get; set; }
            /// <summary>
            /// TreatmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-treatmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TreatmentName { get; set; }
        }
    }
}