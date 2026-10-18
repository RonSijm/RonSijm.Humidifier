namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using UsageProfileTypes;

    public class UsageProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveGlueUsageProfileTypesProfileConfigurationConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string CreatedOn =  "CreatedOn" ;
        }

        public override string AWSTypeName { get => AWS.Glue.UsageProfile; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-usageprofile.html#cfn-glue-usageprofile-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-usageprofile.html#cfn-glue-usageprofile-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProfileConfiguration
        /// </summary>
        public Union<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-usageprofile.html#cfn-glue-usageprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace UsageProfileTypes
    {
        public class ConfigurationObject : Humidifier.Base.BaseSubResource, IHaveMinValue, IHaveDefaultValue, IHaveStringListOfAllowedValues, IHaveMaxValue
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-configurationobject.html#cfn-glue-usageprofile-configurationobject-minvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-configurationobject.html#cfn-glue-usageprofile-configurationobject-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-configurationobject.html#cfn-glue-usageprofile-configurationobject-allowedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedValues { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-configurationobject.html#cfn-glue-usageprofile-configurationobject-maxvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxValue { get; set; }
        }

        public class ProfileConfiguration : Humidifier.Base.BaseSubResource, IHaveMapOfGlueUsageProfileTypesConfigurationObjectJobConfiguration, IHaveMapOfGlueUsageProfileTypesConfigurationObjectSessionConfiguration
        {
            /// <summary>
            /// JobConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-profileconfiguration.html#cfn-glue-usageprofile-profileconfiguration-jobconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ConfigurationObject
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.Glue.UsageProfileTypes.ConfigurationObject>, IReadOnlyDictionary<string, Union<Humidifier.Glue.UsageProfileTypes.ConfigurationObject, BaseFunction>>, BaseFunction>? JobConfiguration { get; set; }
            /// <summary>
            /// SessionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-profileconfiguration.html#cfn-glue-usageprofile-profileconfiguration-sessionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ConfigurationObject
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.Glue.UsageProfileTypes.ConfigurationObject>, IReadOnlyDictionary<string, Union<Humidifier.Glue.UsageProfileTypes.ConfigurationObject, BaseFunction>>, BaseFunction>? SessionConfiguration { get; set; }
        }
    }
}