namespace Humidifier.SSMQuickSetup
{
    using System.Collections.Generic;
    using ConfigurationManagerTypes;

    public class ConfigurationManager : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
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
        public dynamic Description { get; set; }

        /// <summary>
        /// ConfigurationDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmquicksetup-configurationmanager.html#cfn-ssmquicksetup-configurationmanager-configurationdefinitions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ConfigurationDefinition
        /// </summary>
        [Required]
        public List<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> ConfigurationDefinitions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmquicksetup-configurationmanager.html#cfn-ssmquicksetup-configurationmanager-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfigurationManagerTypes
    {
        public class ConfigurationDefinition : Humidifier.Base.BaseSubResource, IHaveType, IHaveid
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-parameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Parameters { get; set; }
            /// <summary>
            /// LocalDeploymentExecutionRoleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-localdeploymentexecutionrolename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalDeploymentExecutionRoleName { get; set; }
            /// <summary>
            /// TypeVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-typeversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TypeVersion { get; set; }
            /// <summary>
            /// LocalDeploymentAdministrationRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-localdeploymentadministrationrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalDeploymentAdministrationRoleArn { get; set; }
            /// <summary>
            /// id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-configurationdefinition.html#cfn-ssmquicksetup-configurationmanager-configurationdefinition-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic id { get; set; }
        }

        public class StatusSummary : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveLastUpdatedAt, IHaveStatusMessage
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-statussummary.html#cfn-ssmquicksetup-configurationmanager-statussummary-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// LastUpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-statussummary.html#cfn-ssmquicksetup-configurationmanager-statussummary-lastupdatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastUpdatedAt { get; set; }
            /// <summary>
            /// StatusType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-statussummary.html#cfn-ssmquicksetup-configurationmanager-statussummary-statustype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusType { get; set; }
            /// <summary>
            /// StatusDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-statussummary.html#cfn-ssmquicksetup-configurationmanager-statussummary-statusdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> StatusDetails { get; set; }
            /// <summary>
            /// StatusMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmquicksetup-configurationmanager-statussummary.html#cfn-ssmquicksetup-configurationmanager-statussummary-statusmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusMessage { get; set; }
        }
    }
}