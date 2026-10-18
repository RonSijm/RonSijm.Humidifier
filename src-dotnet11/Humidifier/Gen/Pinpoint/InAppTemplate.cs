namespace Humidifier.Pinpoint
{
    using global::System.Collections.Generic;
    using InAppTemplateTypes;

    public class InAppTemplate : Humidifier.Base.BaseResource, IHaveCustomConfig_Json, IHaveLayout, IHaveListOfPinpointInAppTemplateTypesInAppMessageContentContent, IHaveTemplateName, IHaveTemplateDescription, IHaveTags_Json
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Pinpoint.InAppTemplate; }
        /// <summary>
        /// CustomConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-inapptemplate.html#cfn-pinpoint-inapptemplate-customconfig
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? CustomConfig { get; set; }
        /// <summary>
        /// Layout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-inapptemplate.html#cfn-pinpoint-inapptemplate-layout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Layout { get; set; }
        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-inapptemplate.html#cfn-pinpoint-inapptemplate-content
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InAppMessageContent
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent>, IReadOnlyList<Union<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent, BaseFunction>>, BaseFunction>? Content { get; set; }

        /// <summary>
        /// TemplateName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-inapptemplate.html#cfn-pinpoint-inapptemplate-templatename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TemplateName { get; set; }
        /// <summary>
        /// TemplateDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-inapptemplate.html#cfn-pinpoint-inapptemplate-templatedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateDescription { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-inapptemplate.html#cfn-pinpoint-inapptemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
    }

    namespace InAppTemplateTypes
    {
        public class BodyConfig : Humidifier.Base.BaseSubResource, IHaveAlignment, IHaveTextColor, IHaveBody
        {
            /// <summary>
            /// Alignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-bodyconfig.html#cfn-pinpoint-inapptemplate-bodyconfig-alignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alignment { get; set; }
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-bodyconfig.html#cfn-pinpoint-inapptemplate-bodyconfig-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextColor { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-bodyconfig.html#cfn-pinpoint-inapptemplate-bodyconfig-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Body { get; set; }
        }

        public class ButtonConfig : Humidifier.Base.BaseSubResource, IHavePinpointInAppTemplateTypesOverrideButtonConfigurationIOS, IHavePinpointInAppTemplateTypesOverrideButtonConfigurationWeb, IHavePinpointInAppTemplateTypesDefaultButtonConfigurationDefaultConfig, IHavePinpointInAppTemplateTypesOverrideButtonConfigurationAndroid
        {
            /// <summary>
            /// IOS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-buttonconfig.html#cfn-pinpoint-inapptemplate-buttonconfig-ios
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OverrideButtonConfiguration
            /// </summary>
            public Union<Humidifier.Pinpoint.InAppTemplateTypes.OverrideButtonConfiguration, BaseFunction>? IOS { get; set; }
            /// <summary>
            /// Web
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-buttonconfig.html#cfn-pinpoint-inapptemplate-buttonconfig-web
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OverrideButtonConfiguration
            /// </summary>
            public Union<Humidifier.Pinpoint.InAppTemplateTypes.OverrideButtonConfiguration, BaseFunction>? Web { get; set; }
            /// <summary>
            /// DefaultConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-buttonconfig.html#cfn-pinpoint-inapptemplate-buttonconfig-defaultconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultButtonConfiguration
            /// </summary>
            public Union<Humidifier.Pinpoint.InAppTemplateTypes.DefaultButtonConfiguration, BaseFunction>? DefaultConfig { get; set; }
            /// <summary>
            /// Android
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-buttonconfig.html#cfn-pinpoint-inapptemplate-buttonconfig-android
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OverrideButtonConfiguration
            /// </summary>
            public Union<Humidifier.Pinpoint.InAppTemplateTypes.OverrideButtonConfiguration, BaseFunction>? Android { get; set; }
        }

        public class DefaultButtonConfiguration : Humidifier.Base.BaseSubResource, IHaveBorderRadius_Integer, IHaveButtonAction, IHaveText, IHaveTextColor, IHaveLink, IHaveBackgroundColor
        {
            /// <summary>
            /// BorderRadius
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-defaultbuttonconfiguration.html#cfn-pinpoint-inapptemplate-defaultbuttonconfiguration-borderradius
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BorderRadius { get; set; }
            /// <summary>
            /// ButtonAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-defaultbuttonconfiguration.html#cfn-pinpoint-inapptemplate-defaultbuttonconfiguration-buttonaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ButtonAction { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-defaultbuttonconfiguration.html#cfn-pinpoint-inapptemplate-defaultbuttonconfiguration-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-defaultbuttonconfiguration.html#cfn-pinpoint-inapptemplate-defaultbuttonconfiguration-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextColor { get; set; }
            /// <summary>
            /// Link
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-defaultbuttonconfiguration.html#cfn-pinpoint-inapptemplate-defaultbuttonconfiguration-link
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Link { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-defaultbuttonconfiguration.html#cfn-pinpoint-inapptemplate-defaultbuttonconfiguration-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BackgroundColor { get; set; }
        }

        public class HeaderConfig : Humidifier.Base.BaseSubResource, IHaveAlignment, IHaveHeader, IHaveTextColor
        {
            /// <summary>
            /// Alignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-headerconfig.html#cfn-pinpoint-inapptemplate-headerconfig-alignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alignment { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-headerconfig.html#cfn-pinpoint-inapptemplate-headerconfig-header
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Header { get; set; }
            /// <summary>
            /// TextColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-headerconfig.html#cfn-pinpoint-inapptemplate-headerconfig-textcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextColor { get; set; }
        }

        public class InAppMessageContent : Humidifier.Base.BaseSubResource, IHavePinpointInAppTemplateTypesBodyConfigBodyConfig, IHavePinpointInAppTemplateTypesButtonConfigSecondaryBtn, IHaveImageUrl, IHavePinpointInAppTemplateTypesButtonConfigPrimaryBtn, IHavePinpointInAppTemplateTypesHeaderConfigHeaderConfig, IHaveBackgroundColor
        {
            /// <summary>
            /// BodyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-inappmessagecontent.html#cfn-pinpoint-inapptemplate-inappmessagecontent-bodyconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BodyConfig
            /// </summary>
            public Union<Humidifier.Pinpoint.InAppTemplateTypes.BodyConfig, BaseFunction>? BodyConfig { get; set; }
            /// <summary>
            /// SecondaryBtn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-inappmessagecontent.html#cfn-pinpoint-inapptemplate-inappmessagecontent-secondarybtn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ButtonConfig
            /// </summary>
            public Union<Humidifier.Pinpoint.InAppTemplateTypes.ButtonConfig, BaseFunction>? SecondaryBtn { get; set; }
            /// <summary>
            /// ImageUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-inappmessagecontent.html#cfn-pinpoint-inapptemplate-inappmessagecontent-imageurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUrl { get; set; }
            /// <summary>
            /// PrimaryBtn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-inappmessagecontent.html#cfn-pinpoint-inapptemplate-inappmessagecontent-primarybtn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ButtonConfig
            /// </summary>
            public Union<Humidifier.Pinpoint.InAppTemplateTypes.ButtonConfig, BaseFunction>? PrimaryBtn { get; set; }
            /// <summary>
            /// HeaderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-inappmessagecontent.html#cfn-pinpoint-inapptemplate-inappmessagecontent-headerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeaderConfig
            /// </summary>
            public Union<Humidifier.Pinpoint.InAppTemplateTypes.HeaderConfig, BaseFunction>? HeaderConfig { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-inappmessagecontent.html#cfn-pinpoint-inapptemplate-inappmessagecontent-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BackgroundColor { get; set; }
        }

        public class OverrideButtonConfiguration : Humidifier.Base.BaseSubResource, IHaveButtonAction, IHaveLink
        {
            /// <summary>
            /// ButtonAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-overridebuttonconfiguration.html#cfn-pinpoint-inapptemplate-overridebuttonconfiguration-buttonaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ButtonAction { get; set; }
            /// <summary>
            /// Link
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-inapptemplate-overridebuttonconfiguration.html#cfn-pinpoint-inapptemplate-overridebuttonconfiguration-link
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Link { get; set; }
        }
    }
}