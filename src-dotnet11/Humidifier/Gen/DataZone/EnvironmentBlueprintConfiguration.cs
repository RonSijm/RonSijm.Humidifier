namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using EnvironmentBlueprintConfigurationTypes;

    public class EnvironmentBlueprintConfiguration : Humidifier.Base.BaseResource, IHaveListOfDataZoneEnvironmentBlueprintConfigurationTypesRegionalParameterRegionalParameters, IHaveStringDictionaryOfGlobalParameters, IHaveProvisioningRoleArn, IHaveListOfDataZoneEnvironmentBlueprintConfigurationTypesProvisioningConfigurationProvisioningConfigurations, IHaveStringListOfEnabledRegions, IHaveEnvironmentBlueprintIdentifier, IHaveDomainIdentifier, IHaveEnvironmentRolePermissionBoundary, IHaveManageAccessRoleArn
    {
        public class Attributes
        {
            public static string DomainId =  "DomainId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string EnvironmentBlueprintId =  "EnvironmentBlueprintId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.EnvironmentBlueprintConfiguration; }
        /// <summary>
        /// RegionalParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentblueprintconfiguration.html#cfn-datazone-environmentblueprintconfiguration-regionalparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RegionalParameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter>, IReadOnlyList<Union<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter, BaseFunction>>, BaseFunction>? RegionalParameters { get; set; }
        /// <summary>
        /// GlobalParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentblueprintconfiguration.html#cfn-datazone-environmentblueprintconfiguration-globalparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? GlobalParameters { get; set; }
        /// <summary>
        /// ProvisioningRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentblueprintconfiguration.html#cfn-datazone-environmentblueprintconfiguration-provisioningrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProvisioningRoleArn { get; set; }
        /// <summary>
        /// ProvisioningConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentblueprintconfiguration.html#cfn-datazone-environmentblueprintconfiguration-provisioningconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ProvisioningConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.ProvisioningConfiguration>, IReadOnlyList<Union<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.ProvisioningConfiguration, BaseFunction>>, BaseFunction>? ProvisioningConfigurations { get; set; }

        /// <summary>
        /// EnabledRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentblueprintconfiguration.html#cfn-datazone-environmentblueprintconfiguration-enabledregions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledRegions { get; set; }

        /// <summary>
        /// EnvironmentBlueprintIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentblueprintconfiguration.html#cfn-datazone-environmentblueprintconfiguration-environmentblueprintidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EnvironmentBlueprintIdentifier { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentblueprintconfiguration.html#cfn-datazone-environmentblueprintconfiguration-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
        /// <summary>
        /// EnvironmentRolePermissionBoundary
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentblueprintconfiguration.html#cfn-datazone-environmentblueprintconfiguration-environmentrolepermissionboundary
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentRolePermissionBoundary { get; set; }
        /// <summary>
        /// ManageAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environmentblueprintconfiguration.html#cfn-datazone-environmentblueprintconfiguration-manageaccessrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ManageAccessRoleArn { get; set; }
    }

    namespace EnvironmentBlueprintConfigurationTypes
    {
        public class LakeFormationConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfLocationRegistrationExcludeS3Locations, IHaveLocationRegistrationRole
        {
            /// <summary>
            /// LocationRegistrationExcludeS3Locations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-environmentblueprintconfiguration-lakeformationconfiguration.html#cfn-datazone-environmentblueprintconfiguration-lakeformationconfiguration-locationregistrationexcludes3locations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LocationRegistrationExcludeS3Locations { get; set; }
            /// <summary>
            /// LocationRegistrationRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-environmentblueprintconfiguration-lakeformationconfiguration.html#cfn-datazone-environmentblueprintconfiguration-lakeformationconfiguration-locationregistrationrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocationRegistrationRole { get; set; }
        }

        public class ProvisioningConfiguration : Humidifier.Base.BaseSubResource, IHaveDataZoneEnvironmentBlueprintConfigurationTypesLakeFormationConfigurationLakeFormationConfiguration
        {
            /// <summary>
            /// LakeFormationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-environmentblueprintconfiguration-provisioningconfiguration.html#cfn-datazone-environmentblueprintconfiguration-provisioningconfiguration-lakeformationconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LakeFormationConfiguration
            /// </summary>
            public Union<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration, BaseFunction>? LakeFormationConfiguration { get; set; }
        }

        public class RegionalParameter : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfParameters, IHaveRegion
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-environmentblueprintconfiguration-regionalparameter.html#cfn-datazone-environmentblueprintconfiguration-regionalparameter-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-environmentblueprintconfiguration-regionalparameter.html#cfn-datazone-environmentblueprintconfiguration-regionalparameter-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }
    }
}