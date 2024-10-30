namespace Humidifier.Glue
{
    using System.Collections.Generic;
    using UsageProfileTypes;

    public class UsageProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public dynamic Description { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-usageprofile.html#cfn-glue-usageprofile-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProfileConfiguration
        /// </summary>
        public Humidifier.Glue.UsageProfileTypes.ProfileConfiguration Configuration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-usageprofile.html#cfn-glue-usageprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace UsageProfileTypes
    {
        public class ConfigurationObject : Humidifier.Base.BaseSubResource, IHaveDefaultValue, IHaveMaxValue, IHaveMinValue, IHaveAllowedValues
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-configurationobject.html#cfn-glue-usageprofile-configurationobject-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultValue { get; set; }
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-configurationobject.html#cfn-glue-usageprofile-configurationobject-allowedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedValues { get; set; }
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-configurationobject.html#cfn-glue-usageprofile-configurationobject-minvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-configurationobject.html#cfn-glue-usageprofile-configurationobject-maxvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaxValue { get; set; }
        }

        public class ProfileConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// JobConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-profileconfiguration.html#cfn-glue-usageprofile-profileconfiguration-jobconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ConfigurationObject
            /// </summary>
            public Dictionary<string, Humidifier.Glue.UsageProfileTypes.ConfigurationObject> JobConfiguration { get; set; }
            /// <summary>
            /// SessionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-usageprofile-profileconfiguration.html#cfn-glue-usageprofile-profileconfiguration-sessionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: ConfigurationObject
            /// </summary>
            public Dictionary<string, Humidifier.Glue.UsageProfileTypes.ConfigurationObject> SessionConfiguration { get; set; }
        }
    }
}