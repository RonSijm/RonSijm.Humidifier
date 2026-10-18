namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using ProjectProfileTypes;

    public class ProjectProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStatus, IHaveListOfDataZoneProjectProfileTypesEnvironmentConfigurationEnvironmentConfigurations, IHaveDescription, IHaveAllowCustomProjectResourceTags_Boolean, IHaveListOfDataZoneProjectProfileTypesResourceTagParameterProjectResourceTags, IHaveUseDefaultConfigurations_Boolean, IHaveDomainUnitIdentifier, IHaveName, IHaveDomainIdentifier, IHaveProjectResourceTagsDescription
    {
        public class Attributes
        {
            public static string DomainUnitId =  "DomainUnitId" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string DomainId =  "DomainId" ;
            public static string Identifier =  "Identifier" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.ProjectProfile; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectprofile.html#cfn-datazone-projectprofile-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// EnvironmentConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectprofile.html#cfn-datazone-projectprofile-environmentconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EnvironmentConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration>, IReadOnlyList<Union<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration, BaseFunction>>, BaseFunction>? EnvironmentConfigurations { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectprofile.html#cfn-datazone-projectprofile-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AllowCustomProjectResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectprofile.html#cfn-datazone-projectprofile-allowcustomprojectresourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AllowCustomProjectResourceTags { get; set; }
        /// <summary>
        /// ProjectResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectprofile.html#cfn-datazone-projectprofile-projectresourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceTagParameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter>, IReadOnlyList<Union<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter, BaseFunction>>, BaseFunction>? ProjectResourceTags { get; set; }
        /// <summary>
        /// UseDefaultConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectprofile.html#cfn-datazone-projectprofile-usedefaultconfigurations
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UseDefaultConfigurations { get; set; }
        /// <summary>
        /// DomainUnitIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectprofile.html#cfn-datazone-projectprofile-domainunitidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainUnitIdentifier { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectprofile.html#cfn-datazone-projectprofile-domainidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
        /// <summary>
        /// ProjectResourceTagsDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-projectprofile.html#cfn-datazone-projectprofile-projectresourcetagsdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectResourceTagsDescription { get; set; }
    }

    namespace ProjectProfileTypes
    {
        public class AwsAccount : Humidifier.Base.BaseSubResource, IHaveAwsAccountId
        {
            /// <summary>
            /// AwsAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-awsaccount.html#cfn-datazone-projectprofile-awsaccount-awsaccountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsAccountId { get; set; }
        }

        public class EnvironmentConfiguration : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveEnvironmentConfigurationId, IHaveDataZoneProjectProfileTypesRegionAwsRegion, IHaveDataZoneProjectProfileTypesAwsAccountAwsAccount, IHaveDeploymentMode, IHaveEnvironmentBlueprintId, IHaveDataZoneProjectProfileTypesEnvironmentConfigurationParametersDetailsConfigurationParameters, IHaveDeploymentOrder_Double, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfiguration.html#cfn-datazone-projectprofile-environmentconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// EnvironmentConfigurationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfiguration.html#cfn-datazone-projectprofile-environmentconfiguration-environmentconfigurationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnvironmentConfigurationId { get; set; }
            /// <summary>
            /// AwsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfiguration.html#cfn-datazone-projectprofile-environmentconfiguration-awsregion
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Region
            /// </summary>
            public Union<Humidifier.DataZone.ProjectProfileTypes.Region, BaseFunction>? AwsRegion { get; set; }
            /// <summary>
            /// AwsAccount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfiguration.html#cfn-datazone-projectprofile-environmentconfiguration-awsaccount
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsAccount
            /// </summary>
            public Union<Humidifier.DataZone.ProjectProfileTypes.AwsAccount, BaseFunction>? AwsAccount { get; set; }
            /// <summary>
            /// DeploymentMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfiguration.html#cfn-datazone-projectprofile-environmentconfiguration-deploymentmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeploymentMode { get; set; }
            /// <summary>
            /// EnvironmentBlueprintId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfiguration.html#cfn-datazone-projectprofile-environmentconfiguration-environmentblueprintid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnvironmentBlueprintId { get; set; }
            /// <summary>
            /// ConfigurationParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfiguration.html#cfn-datazone-projectprofile-environmentconfiguration-configurationparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EnvironmentConfigurationParametersDetails
            /// </summary>
            public Union<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfigurationParametersDetails, BaseFunction>? ConfigurationParameters { get; set; }
            /// <summary>
            /// DeploymentOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfiguration.html#cfn-datazone-projectprofile-environmentconfiguration-deploymentorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DeploymentOrder { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfiguration.html#cfn-datazone-projectprofile-environmentconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class EnvironmentConfigurationParameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveIsEditable_Boolean, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfigurationparameter.html#cfn-datazone-projectprofile-environmentconfigurationparameter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// IsEditable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfigurationparameter.html#cfn-datazone-projectprofile-environmentconfigurationparameter-iseditable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEditable { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfigurationparameter.html#cfn-datazone-projectprofile-environmentconfigurationparameter-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class EnvironmentConfigurationParametersDetails : Humidifier.Base.BaseSubResource, IHaveListOfDataZoneProjectProfileTypesEnvironmentConfigurationParameterParameterOverrides, IHaveListOfDataZoneProjectProfileTypesEnvironmentConfigurationParameterResolvedParameters, IHaveSsmPath
        {
            /// <summary>
            /// ParameterOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfigurationparametersdetails.html#cfn-datazone-projectprofile-environmentconfigurationparametersdetails-parameteroverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EnvironmentConfigurationParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfigurationParameter>, IReadOnlyList<Union<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfigurationParameter, BaseFunction>>, BaseFunction>? ParameterOverrides { get; set; }
            /// <summary>
            /// ResolvedParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfigurationparametersdetails.html#cfn-datazone-projectprofile-environmentconfigurationparametersdetails-resolvedparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EnvironmentConfigurationParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfigurationParameter>, IReadOnlyList<Union<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfigurationParameter, BaseFunction>>, BaseFunction>? ResolvedParameters { get; set; }
            /// <summary>
            /// SsmPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-environmentconfigurationparametersdetails.html#cfn-datazone-projectprofile-environmentconfigurationparametersdetails-ssmpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SsmPath { get; set; }
        }

        public class Region : Humidifier.Base.BaseSubResource, IHaveRegionName
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-region.html#cfn-datazone-projectprofile-region-regionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
        }

        public class ResourceTagParameter : Humidifier.Base.BaseSubResource, IHaveIsValueEditable_Boolean, IHaveValue, IHaveKey
        {
            /// <summary>
            /// IsValueEditable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-resourcetagparameter.html#cfn-datazone-projectprofile-resourcetagparameter-isvalueeditable
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsValueEditable { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-resourcetagparameter.html#cfn-datazone-projectprofile-resourcetagparameter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-projectprofile-resourcetagparameter.html#cfn-datazone-projectprofile-resourcetagparameter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}