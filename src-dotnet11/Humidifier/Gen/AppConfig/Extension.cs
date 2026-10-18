namespace Humidifier.AppConfig
{
    using global::System.Collections.Generic;
    using ExtensionTypes;

    public class Extension : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveMapOfAppConfigExtensionTypesParameterParameters, IHaveActions_Json, IHaveLatestVersionNumber_Integer, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string VersionNumber =  "VersionNumber" ;
        }

        public override string AWSTypeName { get => AWS.AppConfig.Extension; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-extension.html#cfn-appconfig-extension-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-extension.html#cfn-appconfig-extension-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: Parameter
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.AppConfig.ExtensionTypes.Parameter>, IReadOnlyDictionary<string, Union<Humidifier.AppConfig.ExtensionTypes.Parameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-extension.html#cfn-appconfig-extension-actions
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? Actions { get; set; }
        /// <summary>
        /// LatestVersionNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-extension.html#cfn-appconfig-extension-latestversionnumber
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? LatestVersionNumber { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-extension.html#cfn-appconfig-extension-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ExtensionTypes
    {
        public class Parameter : Humidifier.Base.BaseSubResource, IHaveDynamic_Boolean, IHaveDescription, IHaveRequired_Boolean
        {
            /// <summary>
            /// Dynamic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-extension-parameter.html#cfn-appconfig-extension-parameter-dynamic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Dynamic { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-extension-parameter.html#cfn-appconfig-extension-parameter-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-extension-parameter.html#cfn-appconfig-extension-parameter-required
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
        }
    }
}