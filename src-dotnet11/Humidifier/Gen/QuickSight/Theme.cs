namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using ThemeTypes;

    public class Theme : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveThemeId, IHaveVersionDescription, IHaveQuickSightThemeTypesThemeConfigurationConfiguration, IHaveBaseThemeId, IHaveAwsAccountId, IHaveListOfQuickSightThemeTypesResourcePermissionPermissions, IHaveName
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Type =  "Type" ;
            public static string Version =  "Version" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Theme; }

        /// <summary>
        /// ThemeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-themeid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ThemeId { get; set; }
        /// <summary>
        /// VersionDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-versiondescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionDescription { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ThemeConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration, BaseFunction>? Configuration { get; set; }

        /// <summary>
        /// BaseThemeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-basethemeid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BaseThemeId { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.ThemeTypes.ResourcePermission>, IReadOnlyList<Union<Humidifier.QuickSight.ThemeTypes.ResourcePermission, BaseFunction>>, BaseFunction>? Permissions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ThemeTypes
    {
        public class BorderStyle : Humidifier.Base.BaseSubResource, IHaveColor, IHaveShow_Boolean, IHaveWidth
        {
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-borderstyle.html#cfn-quicksight-theme-borderstyle-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Color { get; set; }
            /// <summary>
            /// Show
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-borderstyle.html#cfn-quicksight-theme-borderstyle-show
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Show { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-borderstyle.html#cfn-quicksight-theme-borderstyle-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Width { get; set; }
        }

        public class DataColorPalette : Humidifier.Base.BaseSubResource, IHaveEmptyFillColor, IHaveStringListOfColors, IHaveStringListOfMinMaxGradient
        {
            /// <summary>
            /// EmptyFillColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-datacolorpalette.html#cfn-quicksight-theme-datacolorpalette-emptyfillcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmptyFillColor { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-datacolorpalette.html#cfn-quicksight-theme-datacolorpalette-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Colors { get; set; }
            /// <summary>
            /// MinMaxGradient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-datacolorpalette.html#cfn-quicksight-theme-datacolorpalette-minmaxgradient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MinMaxGradient { get; set; }
        }

        public class Font : Humidifier.Base.BaseSubResource, IHaveFontFamily
        {
            /// <summary>
            /// FontFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-font.html#cfn-quicksight-theme-font-fontfamily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FontFamily { get; set; }
        }

        public class FontConfiguration : Humidifier.Base.BaseSubResource, IHaveFontColor, IHaveFontFamily, IHaveFontStyle, IHaveQuickSightThemeTypesFontWeightFontWeight, IHaveQuickSightThemeTypesFontSizeFontSize, IHaveFontDecoration
        {
            /// <summary>
            /// FontColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-fontconfiguration.html#cfn-quicksight-theme-fontconfiguration-fontcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FontColor { get; set; }
            /// <summary>
            /// FontFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-fontconfiguration.html#cfn-quicksight-theme-fontconfiguration-fontfamily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FontFamily { get; set; }
            /// <summary>
            /// FontStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-fontconfiguration.html#cfn-quicksight-theme-fontconfiguration-fontstyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FontStyle { get; set; }
            /// <summary>
            /// FontWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-fontconfiguration.html#cfn-quicksight-theme-fontconfiguration-fontweight
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontWeight
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.FontWeight, BaseFunction>? FontWeight { get; set; }
            /// <summary>
            /// FontSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-fontconfiguration.html#cfn-quicksight-theme-fontconfiguration-fontsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontSize
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.FontSize, BaseFunction>? FontSize { get; set; }
            /// <summary>
            /// FontDecoration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-fontconfiguration.html#cfn-quicksight-theme-fontconfiguration-fontdecoration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FontDecoration { get; set; }
        }

        public class FontSize : Humidifier.Base.BaseSubResource, IHaveAbsolute
        {
            /// <summary>
            /// Absolute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-fontsize.html#cfn-quicksight-theme-fontsize-absolute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Absolute { get; set; }
        }

        public class FontWeight : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-fontweight.html#cfn-quicksight-theme-fontweight-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class GutterStyle : Humidifier.Base.BaseSubResource, IHaveShow_Boolean
        {
            /// <summary>
            /// Show
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-gutterstyle.html#cfn-quicksight-theme-gutterstyle-show
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Show { get; set; }
        }

        public class MarginStyle : Humidifier.Base.BaseSubResource, IHaveShow_Boolean
        {
            /// <summary>
            /// Show
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-marginstyle.html#cfn-quicksight-theme-marginstyle-show
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Show { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHavePrincipal
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-resourcepermission.html#cfn-quicksight-theme-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-resourcepermission.html#cfn-quicksight-theme-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Principal { get; set; }
        }

        public class SheetBackgroundStyle : Humidifier.Base.BaseSubResource, IHaveGradient, IHaveColor
        {
            /// <summary>
            /// Gradient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-sheetbackgroundstyle.html#cfn-quicksight-theme-sheetbackgroundstyle-gradient
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Gradient { get; set; }
            /// <summary>
            /// Color
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-sheetbackgroundstyle.html#cfn-quicksight-theme-sheetbackgroundstyle-color
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Color { get; set; }
        }

        public class SheetStyle : Humidifier.Base.BaseSubResource, IHaveQuickSightThemeTypesSheetBackgroundStyleBackground, IHaveQuickSightThemeTypesTileLayoutStyleTileLayout, IHaveQuickSightThemeTypesTileStyleTile
        {
            /// <summary>
            /// Background
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-sheetstyle.html#cfn-quicksight-theme-sheetstyle-background
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetBackgroundStyle
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.SheetBackgroundStyle, BaseFunction>? Background { get; set; }
            /// <summary>
            /// TileLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-sheetstyle.html#cfn-quicksight-theme-sheetstyle-tilelayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TileLayoutStyle
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle, BaseFunction>? TileLayout { get; set; }
            /// <summary>
            /// Tile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-sheetstyle.html#cfn-quicksight-theme-sheetstyle-tile
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TileStyle
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.TileStyle, BaseFunction>? Tile { get; set; }
        }

        public class ThemeConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightThemeTypesDataColorPaletteDataColorPalette, IHaveQuickSightThemeTypesUIColorPaletteUIColorPalette, IHaveQuickSightThemeTypesSheetStyleSheet, IHaveQuickSightThemeTypesTypographyTypography
        {
            /// <summary>
            /// DataColorPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeconfiguration.html#cfn-quicksight-theme-themeconfiguration-datacolorpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataColorPalette
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.DataColorPalette, BaseFunction>? DataColorPalette { get; set; }
            /// <summary>
            /// UIColorPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeconfiguration.html#cfn-quicksight-theme-themeconfiguration-uicolorpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UIColorPalette
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.UIColorPalette, BaseFunction>? UIColorPalette { get; set; }
            /// <summary>
            /// Sheet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeconfiguration.html#cfn-quicksight-theme-themeconfiguration-sheet
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetStyle
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.SheetStyle, BaseFunction>? Sheet { get; set; }
            /// <summary>
            /// Typography
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeconfiguration.html#cfn-quicksight-theme-themeconfiguration-typography
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Typography
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.Typography, BaseFunction>? Typography { get; set; }
        }

        public class ThemeError : Humidifier.Base.BaseSubResource, IHaveType, IHaveMessage
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeerror.html#cfn-quicksight-theme-themeerror-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeerror.html#cfn-quicksight-theme-themeerror-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
        }

        public class ThemeVersion : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveListOfQuickSightThemeTypesThemeErrorErrors, IHaveDescription, IHaveCreatedTime, IHaveQuickSightThemeTypesThemeConfigurationConfiguration, IHaveBaseThemeId, IHaveArn, IHaveVersionNumber_Double
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Errors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-errors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ThemeError
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.ThemeTypes.ThemeError>, IReadOnlyList<Union<Humidifier.QuickSight.ThemeTypes.ThemeError, BaseFunction>>, BaseFunction>? Errors { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// CreatedTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-createdtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedTime { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThemeConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// BaseThemeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-basethemeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseThemeId { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// VersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-versionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? VersionNumber { get; set; }
        }

        public class TileLayoutStyle : Humidifier.Base.BaseSubResource, IHaveQuickSightThemeTypesGutterStyleGutter, IHaveQuickSightThemeTypesMarginStyleMargin
        {
            /// <summary>
            /// Gutter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilelayoutstyle.html#cfn-quicksight-theme-tilelayoutstyle-gutter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GutterStyle
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.GutterStyle, BaseFunction>? Gutter { get; set; }
            /// <summary>
            /// Margin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilelayoutstyle.html#cfn-quicksight-theme-tilelayoutstyle-margin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MarginStyle
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.MarginStyle, BaseFunction>? Margin { get; set; }
        }

        public class TileStyle : Humidifier.Base.BaseSubResource, IHaveBorderRadius, IHavePadding, IHaveQuickSightThemeTypesBorderStyleBorder, IHaveBackgroundColor
        {
            /// <summary>
            /// BorderRadius
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilestyle.html#cfn-quicksight-theme-tilestyle-borderradius
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BorderRadius { get; set; }
            /// <summary>
            /// Padding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilestyle.html#cfn-quicksight-theme-tilestyle-padding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Padding { get; set; }
            /// <summary>
            /// Border
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilestyle.html#cfn-quicksight-theme-tilestyle-border
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BorderStyle
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.BorderStyle, BaseFunction>? Border { get; set; }
            /// <summary>
            /// BackgroundColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilestyle.html#cfn-quicksight-theme-tilestyle-backgroundcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BackgroundColor { get; set; }
        }

        public class Typography : Humidifier.Base.BaseSubResource, IHaveQuickSightThemeTypesVisualTitleFontConfigurationVisualTitleFontConfiguration, IHaveQuickSightThemeTypesVisualSubtitleFontConfigurationVisualSubtitleFontConfiguration, IHaveListOfQuickSightThemeTypesFontFontFamilies, IHaveQuickSightThemeTypesFontConfigurationLegendValueFontConfiguration, IHaveQuickSightThemeTypesFontConfigurationAxisTitleFontConfiguration, IHaveQuickSightThemeTypesFontConfigurationAxisLabelFontConfiguration, IHaveQuickSightThemeTypesFontConfigurationLegendTitleFontConfiguration, IHaveQuickSightThemeTypesFontConfigurationDataLabelFontConfiguration
        {
            /// <summary>
            /// VisualTitleFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-typography.html#cfn-quicksight-theme-typography-visualtitlefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualTitleFontConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.VisualTitleFontConfiguration, BaseFunction>? VisualTitleFontConfiguration { get; set; }
            /// <summary>
            /// VisualSubtitleFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-typography.html#cfn-quicksight-theme-typography-visualsubtitlefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VisualSubtitleFontConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.VisualSubtitleFontConfiguration, BaseFunction>? VisualSubtitleFontConfiguration { get; set; }
            /// <summary>
            /// FontFamilies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-typography.html#cfn-quicksight-theme-typography-fontfamilies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Font
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.ThemeTypes.Font>, IReadOnlyList<Union<Humidifier.QuickSight.ThemeTypes.Font, BaseFunction>>, BaseFunction>? FontFamilies { get; set; }
            /// <summary>
            /// LegendValueFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-typography.html#cfn-quicksight-theme-typography-legendvaluefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.FontConfiguration, BaseFunction>? LegendValueFontConfiguration { get; set; }
            /// <summary>
            /// AxisTitleFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-typography.html#cfn-quicksight-theme-typography-axistitlefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.FontConfiguration, BaseFunction>? AxisTitleFontConfiguration { get; set; }
            /// <summary>
            /// AxisLabelFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-typography.html#cfn-quicksight-theme-typography-axislabelfontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.FontConfiguration, BaseFunction>? AxisLabelFontConfiguration { get; set; }
            /// <summary>
            /// LegendTitleFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-typography.html#cfn-quicksight-theme-typography-legendtitlefontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.FontConfiguration, BaseFunction>? LegendTitleFontConfiguration { get; set; }
            /// <summary>
            /// DataLabelFontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-typography.html#cfn-quicksight-theme-typography-datalabelfontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.FontConfiguration, BaseFunction>? DataLabelFontConfiguration { get; set; }
        }

        public class UIColorPalette : Humidifier.Base.BaseSubResource, IHaveWarning, IHaveAccent, IHaveAccentForeground, IHaveSecondaryBackground, IHaveDangerForeground, IHavePrimaryBackground, IHaveDimension, IHaveSecondaryForeground, IHaveWarningForeground, IHaveDimensionForeground, IHavePrimaryForeground, IHaveSuccess, IHaveDanger, IHaveSuccessForeground, IHaveMeasure, IHaveMeasureForeground
        {
            /// <summary>
            /// Warning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-warning
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Warning { get; set; }
            /// <summary>
            /// Accent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-accent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Accent { get; set; }
            /// <summary>
            /// AccentForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-accentforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccentForeground { get; set; }
            /// <summary>
            /// SecondaryBackground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-secondarybackground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecondaryBackground { get; set; }
            /// <summary>
            /// DangerForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-dangerforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DangerForeground { get; set; }
            /// <summary>
            /// PrimaryBackground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-primarybackground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryBackground { get; set; }
            /// <summary>
            /// Dimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-dimension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Dimension { get; set; }
            /// <summary>
            /// SecondaryForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-secondaryforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecondaryForeground { get; set; }
            /// <summary>
            /// WarningForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-warningforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WarningForeground { get; set; }
            /// <summary>
            /// DimensionForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-dimensionforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DimensionForeground { get; set; }
            /// <summary>
            /// PrimaryForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-primaryforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryForeground { get; set; }
            /// <summary>
            /// Success
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-success
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Success { get; set; }
            /// <summary>
            /// Danger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-danger
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Danger { get; set; }
            /// <summary>
            /// SuccessForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-successforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SuccessForeground { get; set; }
            /// <summary>
            /// Measure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-measure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Measure { get; set; }
            /// <summary>
            /// MeasureForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-measureforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MeasureForeground { get; set; }
        }

        public class VisualSubtitleFontConfiguration : Humidifier.Base.BaseSubResource, IHaveTextTransform, IHaveTextAlignment, IHaveQuickSightThemeTypesFontConfigurationFontConfiguration
        {
            /// <summary>
            /// TextTransform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-visualsubtitlefontconfiguration.html#cfn-quicksight-theme-visualsubtitlefontconfiguration-texttransform
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextTransform { get; set; }
            /// <summary>
            /// TextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-visualsubtitlefontconfiguration.html#cfn-quicksight-theme-visualsubtitlefontconfiguration-textalignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextAlignment { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-visualsubtitlefontconfiguration.html#cfn-quicksight-theme-visualsubtitlefontconfiguration-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.FontConfiguration, BaseFunction>? FontConfiguration { get; set; }
        }

        public class VisualTitleFontConfiguration : Humidifier.Base.BaseSubResource, IHaveTextTransform, IHaveTextAlignment, IHaveQuickSightThemeTypesFontConfigurationFontConfiguration
        {
            /// <summary>
            /// TextTransform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-visualtitlefontconfiguration.html#cfn-quicksight-theme-visualtitlefontconfiguration-texttransform
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextTransform { get; set; }
            /// <summary>
            /// TextAlignment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-visualtitlefontconfiguration.html#cfn-quicksight-theme-visualtitlefontconfiguration-textalignment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextAlignment { get; set; }
            /// <summary>
            /// FontConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-visualtitlefontconfiguration.html#cfn-quicksight-theme-visualtitlefontconfiguration-fontconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.ThemeTypes.FontConfiguration, BaseFunction>? FontConfiguration { get; set; }
        }
    }
}