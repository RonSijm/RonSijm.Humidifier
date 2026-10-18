namespace Humidifier.SSMQuickSetup
{
    using global::System.Collections.Generic;
    using ConfigurationManagerTypes;

    public class ConfigurationManager : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveListOfSSMQuickSetupConfigurationManagerTypesConfigurationDefinitionConfigurationDefinitions, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string LastModifiedAt =  "LastModifiedAt" ;
            public static string StatusSummaries =  "StatusSummaries" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ManagerArn =  "ManagerArn" ;
        }

        public override string AWSTypeName { get => AWS.SSMQuickSetup.ConfigurationManager; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmquicksetup-configurationmanager.html#cfn-ssmquicksetup-configurationmanager-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ConfigurationDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmquicksetup-configurationmanager.html#cfn-ssmquicksetup-configurationmanager-configurationdefinitions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ConfigurationDefinition
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition>, IReadOnlyList<Union<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition, BaseFunction>>, BaseFunction>? ConfigurationDefinitions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmquicksetup-configurationmanager.html#cfn-ssmquicksetup-configurationmanager-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfigurationManagerTypes
    {
        public class ConfigurationDefinition : Humidifier.Base.BaseSubResource, IHaveType, IHaveStringDictionaryOfParameters, IHaveLocalDeploymentExecutionRoleName, IHaveTypeVersion, IHaveLocalDeploymentAdministrationRoleArn, IHaveid
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-parameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// LocalDeploymentExecutionRoleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-localdeploymentexecutionrolename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalDeploymentExecutionRoleName { get; set; }
            /// <summary>
            /// TypeVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-typeversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TypeVersion { get; set; }
            /// <summary>
            /// LocalDeploymentAdministrationRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-localdeploymentadministrationrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalDeploymentAdministrationRoleArn { get; set; }
            /// <summary>
            /// id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? id { get; set; }
        }

        public class StatusSummary : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveLastUpdatedAt, IHaveStatusType, IHaveStringDictionaryOfStatusDetails, IHaveStatusMessage
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-statussummary.html#cfn-ssmquicksetup-configurationmanager-statussummary-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// LastUpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-statussummary.html#cfn-ssmquicksetup-configurationmanager-statussummary-lastupdatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastUpdatedAt { get; set; }
            /// <summary>
            /// StatusType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-statussummary.html#cfn-ssmquicksetup-configurationmanager-statussummary-statustype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusType { get; set; }
            /// <summary>
            /// StatusDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-statussummary.html#cfn-ssmquicksetup-configurationmanager-statussummary-statusdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? StatusDetails { get; set; }
            /// <summary>
            /// StatusMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-statussummary.html#cfn-ssmquicksetup-configurationmanager-statussummary-statusmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusMessage { get; set; }
        }
    }
}