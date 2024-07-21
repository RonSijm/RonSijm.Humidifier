namespace Humidifier.QuickSight
{
    using System.Collections.Generic;
    using ThemeTypes;

    public class Theme : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Type =  "Type" ;
            public static string Version =  "Version" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::QuickSight::Theme";
            }
        }

        /// <summary>
        /// ThemeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-themeid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ThemeId { get; set; }
        /// <summary>
        /// VersionDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-versiondescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VersionDescription { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ThemeConfiguration
        /// </summary>
        public ThemeConfiguration Configuration { get; set; }
        /// <summary>
        /// BaseThemeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-basethemeid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BaseThemeId { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<ResourcePermission> Permissions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-theme.html#cfn-quicksight-theme-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace ThemeTypes
    {
        public class BorderStyle
        {
            /// <summary>
            /// Show
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-borderstyle.html#cfn-quicksight-theme-borderstyle-show
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Show { get; set; }
        }

        public class DataColorPalette
        {
            /// <summary>
            /// EmptyFillColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-datacolorpalette.html#cfn-quicksight-theme-datacolorpalette-emptyfillcolor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmptyFillColor { get; set; }
            /// <summary>
            /// Colors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-datacolorpalette.html#cfn-quicksight-theme-datacolorpalette-colors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Colors { get; set; }
            /// <summary>
            /// MinMaxGradient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-datacolorpalette.html#cfn-quicksight-theme-datacolorpalette-minmaxgradient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MinMaxGradient { get; set; }
        }

        public class Font
        {
            /// <summary>
            /// FontFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-font.html#cfn-quicksight-theme-font-fontfamily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FontFamily { get; set; }
        }

        public class GutterStyle
        {
            /// <summary>
            /// Show
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-gutterstyle.html#cfn-quicksight-theme-gutterstyle-show
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Show { get; set; }
        }

        public class MarginStyle
        {
            /// <summary>
            /// Show
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-marginstyle.html#cfn-quicksight-theme-marginstyle-show
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Show { get; set; }
        }

        public class ResourcePermission
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-resourcepermission.html#cfn-quicksight-theme-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-resourcepermission.html#cfn-quicksight-theme-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Principal { get; set; }
        }

        public class SheetStyle
        {
            /// <summary>
            /// TileLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-sheetstyle.html#cfn-quicksight-theme-sheetstyle-tilelayout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TileLayoutStyle
            /// </summary>
            public TileLayoutStyle TileLayout { get; set; }
            /// <summary>
            /// Tile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-sheetstyle.html#cfn-quicksight-theme-sheetstyle-tile
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TileStyle
            /// </summary>
            public TileStyle Tile { get; set; }
        }

        public class ThemeConfiguration
        {
            /// <summary>
            /// DataColorPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeconfiguration.html#cfn-quicksight-theme-themeconfiguration-datacolorpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataColorPalette
            /// </summary>
            public DataColorPalette DataColorPalette { get; set; }
            /// <summary>
            /// UIColorPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeconfiguration.html#cfn-quicksight-theme-themeconfiguration-uicolorpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UIColorPalette
            /// </summary>
            public UIColorPalette UIColorPalette { get; set; }
            /// <summary>
            /// Sheet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeconfiguration.html#cfn-quicksight-theme-themeconfiguration-sheet
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SheetStyle
            /// </summary>
            public SheetStyle Sheet { get; set; }
            /// <summary>
            /// Typography
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeconfiguration.html#cfn-quicksight-theme-themeconfiguration-typography
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Typography
            /// </summary>
            public Typography Typography { get; set; }
        }

        public class ThemeError
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeerror.html#cfn-quicksight-theme-themeerror-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeerror.html#cfn-quicksight-theme-themeerror-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
        }

        public class ThemeVersion
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Errors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-errors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ThemeError
            /// </summary>
            public List<ThemeError> Errors { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// CreatedTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-createdtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedTime { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThemeConfiguration
            /// </summary>
            public ThemeConfiguration Configuration { get; set; }
            /// <summary>
            /// BaseThemeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-basethemeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseThemeId { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// VersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html#cfn-quicksight-theme-themeversion-versionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic VersionNumber { get; set; }
        }

        public class TileLayoutStyle
        {
            /// <summary>
            /// Gutter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilelayoutstyle.html#cfn-quicksight-theme-tilelayoutstyle-gutter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GutterStyle
            /// </summary>
            public GutterStyle Gutter { get; set; }
            /// <summary>
            /// Margin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilelayoutstyle.html#cfn-quicksight-theme-tilelayoutstyle-margin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MarginStyle
            /// </summary>
            public MarginStyle Margin { get; set; }
        }

        public class TileStyle
        {
            /// <summary>
            /// Border
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-tilestyle.html#cfn-quicksight-theme-tilestyle-border
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BorderStyle
            /// </summary>
            public BorderStyle Border { get; set; }
        }

        public class Typography
        {
            /// <summary>
            /// FontFamilies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-typography.html#cfn-quicksight-theme-typography-fontfamilies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Font
            /// </summary>
            public List<Font> FontFamilies { get; set; }
        }

        public class UIColorPalette
        {
            /// <summary>
            /// Warning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-warning
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Warning { get; set; }
            /// <summary>
            /// Accent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-accent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Accent { get; set; }
            /// <summary>
            /// AccentForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-accentforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccentForeground { get; set; }
            /// <summary>
            /// SecondaryBackground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-secondarybackground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecondaryBackground { get; set; }
            /// <summary>
            /// DangerForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-dangerforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DangerForeground { get; set; }
            /// <summary>
            /// PrimaryBackground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-primarybackground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryBackground { get; set; }
            /// <summary>
            /// Dimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-dimension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Dimension { get; set; }
            /// <summary>
            /// SecondaryForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-secondaryforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecondaryForeground { get; set; }
            /// <summary>
            /// WarningForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-warningforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WarningForeground { get; set; }
            /// <summary>
            /// DimensionForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-dimensionforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DimensionForeground { get; set; }
            /// <summary>
            /// PrimaryForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-primaryforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryForeground { get; set; }
            /// <summary>
            /// Success
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-success
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Success { get; set; }
            /// <summary>
            /// Danger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-danger
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Danger { get; set; }
            /// <summary>
            /// SuccessForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-successforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SuccessForeground { get; set; }
            /// <summary>
            /// Measure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-measure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Measure { get; set; }
            /// <summary>
            /// MeasureForeground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html#cfn-quicksight-theme-uicolorpalette-measureforeground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MeasureForeground { get; set; }
        }
    }
}