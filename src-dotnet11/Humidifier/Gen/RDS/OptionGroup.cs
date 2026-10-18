namespace Humidifier.RDS
{
    using global::System.Collections.Generic;
    using OptionGroupTypes;

    public class OptionGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveOptionGroupDescription, IHaveOptionGroupName, IHaveListOfRDSOptionGroupTypesOptionConfigurationOptionConfigurations, IHaveMajorEngineVersion, IHaveEngineName, IHaveDescription
    {
        public override string AWSTypeName { get => AWS.RDS.OptionGroup; }

        /// <summary>
        /// OptionGroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-optiongroupdescription
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OptionGroupDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => OptionGroupDescription; set => OptionGroupDescription = value; }
        public Union<string, BaseFunction>? OptionGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OptionConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-optionconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: OptionConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.RDS.OptionGroupTypes.OptionConfiguration>, IReadOnlyList<Union<Humidifier.RDS.OptionGroupTypes.OptionConfiguration, BaseFunction>>, BaseFunction>? OptionConfigurations { get; set; }

        /// <summary>
        /// MajorEngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-majorengineversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MajorEngineVersion { get; set; }

        /// <summary>
        /// EngineName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-enginename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EngineName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace OptionGroupTypes
    {
        public class OptionConfiguration : Humidifier.Base.BaseSubResource, IHaveOptionVersion, IHaveStringListOfVpcSecurityGroupMemberships, IHaveListOfRDSOptionGroupTypesOptionSettingOptionSettings, IHavePort_Integer, IHaveOptionName, IHaveStringListOfDBSecurityGroupMemberships
        {
            /// <summary>
            /// OptionVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfiguration.html#cfn-rds-optiongroup-optionconfiguration-optionversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OptionVersion { get; set; }
            /// <summary>
            /// VpcSecurityGroupMemberships
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfiguration.html#cfn-rds-optiongroup-optionconfiguration-vpcsecuritygroupmemberships
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSecurityGroupMemberships { get; set; }
            /// <summary>
            /// OptionSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfiguration.html#cfn-rds-optiongroup-optionconfiguration-optionsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OptionSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RDS.OptionGroupTypes.OptionSetting>, IReadOnlyList<Union<Humidifier.RDS.OptionGroupTypes.OptionSetting, BaseFunction>>, BaseFunction>? OptionSettings { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfiguration.html#cfn-rds-optiongroup-optionconfiguration-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// OptionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfiguration.html#cfn-rds-optiongroup-optionconfiguration-optionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OptionName { get; set; }
            /// <summary>
            /// DBSecurityGroupMemberships
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfiguration.html#cfn-rds-optiongroup-optionconfiguration-dbsecuritygroupmemberships
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DBSecurityGroupMemberships { get; set; }
        }

        public class OptionSetting : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionsetting.html#cfn-rds-optiongroup-optionsetting-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionsetting.html#cfn-rds-optiongroup-optionsetting-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}