namespace Humidifier.AmplifyUIBuilder
{
    using System.Collections.Generic;
    using ThemeTypes;

    public class Theme : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveAppId, IHaveEnvironmentName
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
        public dynamic AppId { get; set; }
        /// <summary>
        /// EnvironmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-theme.html#cfn-amplifyuibuilder-theme-environmentname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EnvironmentName { get; set; }
        /// <summary>
        /// Values
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-theme.html#cfn-amplifyuibuilder-theme-values
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ThemeValues
        /// </summary>
        public List<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> Values { get; set; }
        /// <summary>
        /// Overrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-theme.html#cfn-amplifyuibuilder-theme-overrides
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ThemeValues
        /// </summary>
        public List<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> Overrides { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplifyuibuilder-theme.html#cfn-amplifyuibuilder-theme-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ThemeTypes
    {
        public class ThemeValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-theme-themevalue.html#cfn-amplifyuibuilder-theme-themevalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Children
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-theme-themevalue.html#cfn-amplifyuibuilder-theme-themevalue-children
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ThemeValues
            /// </summary>
            public List<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> Children { get; set; }
        }

        public class ThemeValues : Humidifier.Base.BaseSubResource, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-theme-themevalues.html#cfn-amplifyuibuilder-theme-themevalues-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThemeValue
            /// </summary>
            public Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplifyuibuilder-theme-themevalues.html#cfn-amplifyuibuilder-theme-themevalues-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}