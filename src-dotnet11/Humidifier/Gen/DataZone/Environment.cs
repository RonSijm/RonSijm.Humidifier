namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using EnvironmentTypes;

    public class Environment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveProjectIdentifier, IHaveEnvironmentAccountRegion, IHaveListOfDataZoneEnvironmentTypesEnvironmentParameterUserParameters, IHaveDescription, IHaveEnvironmentConfigurationId, IHaveStringListOfGlossaryTerms, IHaveEnvironmentBlueprintIdentifier, IHaveName, IHaveEnvironmentRoleArn, IHaveEnvironmentProfileIdentifier, IHaveDeploymentOrder_Integer, IHaveEnvironmentAccountIdentifier, IHaveDomainIdentifier
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string DomainId =  "DomainId" ;
            public static string EnvironmentProfileId =  "EnvironmentProfileId" ;
            public static string AwsAccountRegion =  "AwsAccountRegion" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ProjectId =  "ProjectId" ;
            public static string AwsAccountId =  "AwsAccountId" ;
            public static string EnvironmentBlueprintId =  "EnvironmentBlueprintId" ;
            public static string Id =  "Id" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Provider =  "Provider" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.Environment; }

        /// <summary>
        /// ProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-projectidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProjectIdentifier { get; set; }
        /// <summary>
        /// EnvironmentAccountRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-environmentaccountregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentAccountRegion { get; set; }
        /// <summary>
        /// UserParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-userparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: EnvironmentParameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter>, IReadOnlyList<Union<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter, BaseFunction>>, BaseFunction>? UserParameters { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EnvironmentConfigurationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-environmentconfigurationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentConfigurationId { get; set; }
        /// <summary>
        /// GlossaryTerms
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-glossaryterms
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GlossaryTerms { get; set; }
        /// <summary>
        /// EnvironmentBlueprintIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-environmentblueprintidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentBlueprintIdentifier { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EnvironmentRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-environmentrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentRoleArn { get; set; }
        /// <summary>
        /// EnvironmentProfileIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-environmentprofileidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentProfileIdentifier { get; set; }
        /// <summary>
        /// DeploymentOrder
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-deploymentorder
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DeploymentOrder { get; set; }
        /// <summary>
        /// EnvironmentAccountIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-environmentaccountidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentAccountIdentifier { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-environment.html#cfn-datazone-environment-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
    }

    namespace EnvironmentTypes
    {
        public class EnvironmentParameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-environment-environmentparameter.html#cfn-datazone-environment-environmentparameter-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-environment-environmentparameter.html#cfn-datazone-environment-environmentparameter-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}