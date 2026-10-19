namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using BrandTypes;

    public class Brand : Humidifier.Base.BaseResource, IHaveTags, IHaveQuickSightBrandTypesBrandDefinitionBrandDefinition, IHaveBrandId
    {
        public class Attributes
        {
            public static string VersionId =  "VersionId" ;
            public static string BrandStatus =  "BrandStatus" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string AwsAccountId =  "AwsAccountId" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Arn =  "Arn" ;
            public static string VersionStatus =  "VersionStatus" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Brand; }
        /// <summary>
        /// BrandDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-brand.html#cfn-quicksight-brand-branddefinition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BrandDefinition
        /// </summary>
        public Union<Humidifier.QuickSight.BrandTypes.BrandDefinition, BaseFunction>? BrandDefinition { get; set; }

        /// <summary>
        /// BrandId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-brand.html#cfn-quicksight-brand-brandid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BrandId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-brand.html#cfn-quicksight-brand-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace BrandTypes
    {
        public class ApplicationTheme : Humidifier.Base.BaseSubResource, IHaveQuickSightBrandTypesBrandColorPaletteBrandColorPalette, IHaveQuickSightBrandTypesBrandElementStyleBrandElementStyle
        {
            /// <summary>
            /// BrandColorPalette
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-applicationtheme.html#cfn-quicksight-brand-applicationtheme-brandcolorpalette
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BrandColorPalette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.BrandColorPalette, BaseFunction>? BrandColorPalette { get; set; }
            /// <summary>
            /// BrandElementStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-applicationtheme.html#cfn-quicksight-brand-applicationtheme-brandelementstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BrandElementStyle
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.BrandElementStyle, BaseFunction>? BrandElementStyle { get; set; }
        }

        public class BrandColorPalette : Humidifier.Base.BaseSubResource, IHaveQuickSightBrandTypesPaletteSecondary, IHaveQuickSightBrandTypesPaletteWarning, IHaveQuickSightBrandTypesPaletteAccent, IHaveQuickSightBrandTypesPalettePrimary, IHaveQuickSightBrandTypesPaletteDanger, IHaveQuickSightBrandTypesPaletteMeasure, IHaveQuickSightBrandTypesPaletteDimension, IHaveQuickSightBrandTypesPaletteInfo, IHaveQuickSightBrandTypesPaletteSuccess
        {
            /// <summary>
            /// Secondary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-brandcolorpalette.html#cfn-quicksight-brand-brandcolorpalette-secondary
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Palette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.Palette, BaseFunction>? Secondary { get; set; }
            /// <summary>
            /// Warning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-brandcolorpalette.html#cfn-quicksight-brand-brandcolorpalette-warning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Palette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.Palette, BaseFunction>? Warning { get; set; }
            /// <summary>
            /// Accent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-brandcolorpalette.html#cfn-quicksight-brand-brandcolorpalette-accent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Palette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.Palette, BaseFunction>? Accent { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-brandcolorpalette.html#cfn-quicksight-brand-brandcolorpalette-primary
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Palette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.Palette, BaseFunction>? Primary { get; set; }
            /// <summary>
            /// Danger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-brandcolorpalette.html#cfn-quicksight-brand-brandcolorpalette-danger
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Palette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.Palette, BaseFunction>? Danger { get; set; }
            /// <summary>
            /// Measure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-brandcolorpalette.html#cfn-quicksight-brand-brandcolorpalette-measure
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Palette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.Palette, BaseFunction>? Measure { get; set; }
            /// <summary>
            /// Dimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-brandcolorpalette.html#cfn-quicksight-brand-brandcolorpalette-dimension
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Palette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.Palette, BaseFunction>? Dimension { get; set; }
            /// <summary>
            /// Info
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-brandcolorpalette.html#cfn-quicksight-brand-brandcolorpalette-info
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Palette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.Palette, BaseFunction>? Info { get; set; }
            /// <summary>
            /// Success
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-brandcolorpalette.html#cfn-quicksight-brand-brandcolorpalette-success
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Palette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.Palette, BaseFunction>? Success { get; set; }
        }

        public class BrandDefinition : Humidifier.Base.BaseSubResource, IHaveBrandName, IHaveDescription, IHaveQuickSightBrandTypesApplicationThemeApplicationTheme
        {
            /// <summary>
            /// BrandName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-branddefinition.html#cfn-quicksight-brand-branddefinition-brandname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BrandName { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-branddefinition.html#cfn-quicksight-brand-branddefinition-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ApplicationTheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-branddefinition.html#cfn-quicksight-brand-branddefinition-applicationtheme
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationTheme
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.ApplicationTheme, BaseFunction>? ApplicationTheme { get; set; }
        }

        public class BrandElementStyle : Humidifier.Base.BaseSubResource, IHaveQuickSightBrandTypesNavbarStyleNavbarStyle
        {
            /// <summary>
            /// NavbarStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-brandelementstyle.html#cfn-quicksight-brand-brandelementstyle-navbarstyle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NavbarStyle
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.NavbarStyle, BaseFunction>? NavbarStyle { get; set; }
        }

        public class NavbarStyle : Humidifier.Base.BaseSubResource, IHaveQuickSightBrandTypesPaletteGlobalNavbar, IHaveQuickSightBrandTypesPaletteContextualNavbar
        {
            /// <summary>
            /// GlobalNavbar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-navbarstyle.html#cfn-quicksight-brand-navbarstyle-globalnavbar
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Palette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.Palette, BaseFunction>? GlobalNavbar { get; set; }
            /// <summary>
            /// ContextualNavbar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-navbarstyle.html#cfn-quicksight-brand-navbarstyle-contextualnavbar
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Palette
            /// </summary>
            public Union<Humidifier.QuickSight.BrandTypes.Palette, BaseFunction>? ContextualNavbar { get; set; }
        }

        public class Palette : Humidifier.Base.BaseSubResource, IHaveBackground, IHaveForeground
        {
            /// <summary>
            /// Background
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-palette.html#cfn-quicksight-brand-palette-background
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Background { get; set; }
            /// <summary>
            /// Foreground
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-brand-palette.html#cfn-quicksight-brand-palette-foreground
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Foreground { get; set; }
        }
    }
}