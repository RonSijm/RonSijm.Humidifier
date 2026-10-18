namespace Humidifier.AmplifyUIBuilder
{
    using global::System.Collections.Generic;
    using ThemeTypes;

    public class Theme : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAppId, IHaveEnvironmentName, IHaveListOfAmplifyUIBuilderThemeTypesThemeValuesValues, IHaveListOfAmplifyUIBuilderThemeTypesThemeValuesOverrides, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.AmplifyUIBuilder.Theme; }
        /// <summary>
        /// AppId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-theme.html#cfn-amplifyuibuilder-theme-appid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AppId { get; set; }
        /// <summary>
        /// EnvironmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-theme.html#cfn-amplifyuibuilder-theme-environmentname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentName { get; set; }
        /// <summary>
        /// Values
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-theme.html#cfn-amplifyuibuilder-theme-values
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ThemeValues
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues, BaseFunction>>, BaseFunction>? Values { get; set; }
        /// <summary>
        /// Overrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-theme.html#cfn-amplifyuibuilder-theme-overrides
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ThemeValues
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues, BaseFunction>>, BaseFunction>? Overrides { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-theme.html#cfn-amplifyuibuilder-theme-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ThemeTypes
    {
        public class ThemeValue : Humidifier.Base.BaseSubResource, IHaveValue, IHaveListOfAmplifyUIBuilderThemeTypesThemeValuesChildren
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-theme-themevalue.html#cfn-amplifyuibuilder-theme-themevalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Children
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-theme-themevalue.html#cfn-amplifyuibuilder-theme-themevalue-children
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ThemeValues
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues>, IReadOnlyList<Union<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues, BaseFunction>>, BaseFunction>? Children { get; set; }
        }

        public class ThemeValues : Humidifier.Base.BaseSubResource, IHaveAmplifyUIBuilderThemeTypesThemeValueValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-theme-themevalues.html#cfn-amplifyuibuilder-theme-themevalues-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThemeValue
            /// </summary>
            public Union<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-theme-themevalues.html#cfn-amplifyuibuilder-theme-themevalues-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}