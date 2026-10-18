namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using WorkspaceTypes;

    public class Workspace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfConnectWorkspaceTypesWorkspacePagePages, IHaveDescription, IHaveInstanceArn, IHaveListOfConnectWorkspaceTypesMediaItemMedia, IHaveTitle, IHaveConnectWorkspaceTypesWorkspaceThemeTheme, IHaveVisibility, IHaveStringListOfAssociations, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.Workspace; }
        /// <summary>
        /// Pages
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-workspace.html#cfn-connect-workspace-pages
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: WorkspacePage
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.WorkspaceTypes.WorkspacePage>, IReadOnlyList<Union<Humidifier.Connect.WorkspaceTypes.WorkspacePage, BaseFunction>>, BaseFunction>? Pages { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-workspace.html#cfn-connect-workspace-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-workspace.html#cfn-connect-workspace-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// Media
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-workspace.html#cfn-connect-workspace-media
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.WorkspaceTypes.MediaItem>, IReadOnlyList<Union<Humidifier.Connect.WorkspaceTypes.MediaItem, BaseFunction>>, BaseFunction>? Media { get; set; }
        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-workspace.html#cfn-connect-workspace-title
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Title { get; set; }
        /// <summary>
        /// Theme
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-workspace.html#cfn-connect-workspace-theme
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WorkspaceTheme
        /// </summary>
        public Union<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme, BaseFunction>? Theme { get; set; }
        /// <summary>
        /// Visibility
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-workspace.html#cfn-connect-workspace-visibility
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Visibility { get; set; }
        /// <summary>
        /// Associations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-workspace.html#cfn-connect-workspace-associations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Associations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-workspace.html#cfn-connect-workspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace WorkspaceTypes
    {
        public class FontFamily : Humidifier.Base.BaseSubResource, IHaveDefault
        {
            /// <summary>
            /// Default
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-fontfamily.html#cfn-connect-workspace-fontfamily-default
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Default { get; set; }
        }

        public class MediaItem : Humidifier.Base.BaseSubResource, IHaveType, IHaveSource
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-mediaitem.html#cfn-connect-workspace-mediaitem-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-mediaitem.html#cfn-connect-workspace-mediaitem-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class PaletteCanvas : Humidifier.Base.BaseSubResource, IHaveContainerBackground, IHaveActiveBackground, IHavePageBackground
        {
            /// <summary>
            /// ContainerBackground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-palettecanvas.html#cfn-connect-workspace-palettecanvas-containerbackground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerBackground { get; set; }
            /// <summary>
            /// ActiveBackground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-palettecanvas.html#cfn-connect-workspace-palettecanvas-activebackground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActiveBackground { get; set; }
            /// <summary>
            /// PageBackground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-palettecanvas.html#cfn-connect-workspace-palettecanvas-pagebackground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PageBackground { get; set; }
        }

        public class PaletteHeader : Humidifier.Base.BaseSubResource, IHaveBackground, IHaveText, IHaveTextHover, IHaveInvertActionsColors_Boolean
        {
            /// <summary>
            /// Background
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-paletteheader.html#cfn-connect-workspace-paletteheader-background
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Background { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-paletteheader.html#cfn-connect-workspace-paletteheader-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
            /// <summary>
            /// TextHover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-paletteheader.html#cfn-connect-workspace-paletteheader-texthover
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextHover { get; set; }
            /// <summary>
            /// InvertActionsColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-paletteheader.html#cfn-connect-workspace-paletteheader-invertactionscolors
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InvertActionsColors { get; set; }
        }

        public class PaletteNavigation : Humidifier.Base.BaseSubResource, IHaveTextBackgroundHover, IHaveBackground, IHaveTextBackgroundActive, IHaveText, IHaveTextHover, IHaveTextActive, IHaveInvertActionsColors_Boolean
        {
            /// <summary>
            /// TextBackgroundHover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-palettenavigation.html#cfn-connect-workspace-palettenavigation-textbackgroundhover
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextBackgroundHover { get; set; }
            /// <summary>
            /// Background
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-palettenavigation.html#cfn-connect-workspace-palettenavigation-background
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Background { get; set; }
            /// <summary>
            /// TextBackgroundActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-palettenavigation.html#cfn-connect-workspace-palettenavigation-textbackgroundactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextBackgroundActive { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-palettenavigation.html#cfn-connect-workspace-palettenavigation-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
            /// <summary>
            /// TextHover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-palettenavigation.html#cfn-connect-workspace-palettenavigation-texthover
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextHover { get; set; }
            /// <summary>
            /// TextActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-palettenavigation.html#cfn-connect-workspace-palettenavigation-textactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextActive { get; set; }
            /// <summary>
            /// InvertActionsColors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-palettenavigation.html#cfn-connect-workspace-palettenavigation-invertactionscolors
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InvertActionsColors { get; set; }
        }

        public class PalettePrimary : Humidifier.Base.BaseSubResource, IHaveActive, IHaveDefault, IHaveContrastText
        {
            /// <summary>
            /// Active
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-paletteprimary.html#cfn-connect-workspace-paletteprimary-active
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Active { get; set; }
            /// <summary>
            /// Default
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-paletteprimary.html#cfn-connect-workspace-paletteprimary-default
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Default { get; set; }
            /// <summary>
            /// ContrastText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-paletteprimary.html#cfn-connect-workspace-paletteprimary-contrasttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContrastText { get; set; }
        }

        public class WorkspacePage : Humidifier.Base.BaseSubResource, IHaveResourceArn, IHavePage, IHaveSlug, IHaveInputData
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacepage.html#cfn-connect-workspace-workspacepage-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceArn { get; set; }
            /// <summary>
            /// Page
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacepage.html#cfn-connect-workspace-workspacepage-page
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Page { get; set; }
            /// <summary>
            /// Slug
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacepage.html#cfn-connect-workspace-workspacepage-slug
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Slug { get; set; }
            /// <summary>
            /// InputData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacepage.html#cfn-connect-workspace-workspacepage-inputdata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputData { get; set; }
        }

        public class WorkspaceTheme : Humidifier.Base.BaseSubResource, IHaveConnectWorkspaceTypesWorkspaceThemeConfigLight, IHaveConnectWorkspaceTypesWorkspaceThemeConfigDark
        {
            /// <summary>
            /// Light
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacetheme.html#cfn-connect-workspace-workspacetheme-light
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WorkspaceThemeConfig
            /// </summary>
            public Union<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig, BaseFunction>? Light { get; set; }
            /// <summary>
            /// Dark
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacetheme.html#cfn-connect-workspace-workspacetheme-dark
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WorkspaceThemeConfig
            /// </summary>
            public Union<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig, BaseFunction>? Dark { get; set; }
        }

        public class WorkspaceThemeConfig : Humidifier.Base.BaseSubResource, IHaveConnectWorkspaceTypesWorkspaceThemePalettePalette, IHaveConnectWorkspaceTypesWorkspaceThemeTypographyTypography
        {
            /// <summary>
            /// Palette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacethemeconfig.html#cfn-connect-workspace-workspacethemeconfig-palette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WorkspaceThemePalette
            /// </summary>
            public Union<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette, BaseFunction>? Palette { get; set; }
            /// <summary>
            /// Typography
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacethemeconfig.html#cfn-connect-workspace-workspacethemeconfig-typography
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WorkspaceThemeTypography
            /// </summary>
            public Union<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography, BaseFunction>? Typography { get; set; }
        }

        public class WorkspaceThemePalette : Humidifier.Base.BaseSubResource, IHaveConnectWorkspaceTypesPaletteNavigationNavigation, IHaveConnectWorkspaceTypesPaletteHeaderHeader, IHaveConnectWorkspaceTypesPaletteCanvasCanvas, IHaveConnectWorkspaceTypesPalettePrimaryPrimary
        {
            /// <summary>
            /// Navigation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacethemepalette.html#cfn-connect-workspace-workspacethemepalette-navigation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaletteNavigation
            /// </summary>
            public Union<Humidifier.Connect.WorkspaceTypes.PaletteNavigation, BaseFunction>? Navigation { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacethemepalette.html#cfn-connect-workspace-workspacethemepalette-header
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaletteHeader
            /// </summary>
            public Union<Humidifier.Connect.WorkspaceTypes.PaletteHeader, BaseFunction>? Header { get; set; }
            /// <summary>
            /// Canvas
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacethemepalette.html#cfn-connect-workspace-workspacethemepalette-canvas
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaletteCanvas
            /// </summary>
            public Union<Humidifier.Connect.WorkspaceTypes.PaletteCanvas, BaseFunction>? Canvas { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacethemepalette.html#cfn-connect-workspace-workspacethemepalette-primary
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PalettePrimary
            /// </summary>
            public Union<Humidifier.Connect.WorkspaceTypes.PalettePrimary, BaseFunction>? Primary { get; set; }
        }

        public class WorkspaceThemeTypography : Humidifier.Base.BaseSubResource, IHaveConnectWorkspaceTypesFontFamilyFontFamily
        {
            /// <summary>
            /// FontFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-workspace-workspacethemetypography.html#cfn-connect-workspace-workspacethemetypography-fontfamily
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FontFamily
            /// </summary>
            public Union<Humidifier.Connect.WorkspaceTypes.FontFamily, BaseFunction>? FontFamily { get; set; }
        }
    }
}