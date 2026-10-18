namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using SecurityProfileTypes;

    public class SecurityProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveTagListOfAllowedAccessControlTags, IHaveListOfConnectSecurityProfileTypesApplicationApplications, IHaveAllowedAccessControlHierarchyGroupId, IHaveInstanceArn, IHaveConnectSecurityProfileTypesGranularAccessControlConfigurationGranularAccessControlConfiguration, IHaveStringListOfPermissions, IHaveSecurityProfileName, IHaveListOfConnectSecurityProfileTypesFlowModuleAllowedFlowModules, IHaveStringListOfTagRestrictedResources, IHaveStringListOfHierarchyRestrictedResources
    {
        public class Attributes
        {
            public static string SecurityProfileArn =  "SecurityProfileArn" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string LastModifiedRegion =  "LastModifiedRegion" ;
        }

        public override string AWSTypeName { get => AWS.Connect.SecurityProfile; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AllowedAccessControlTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-allowedaccesscontroltags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? AllowedAccessControlTags { get; set; }
        /// <summary>
        /// Applications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-applications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Application
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.SecurityProfileTypes.Application>, IReadOnlyList<Union<Humidifier.Connect.SecurityProfileTypes.Application, BaseFunction>>, BaseFunction>? Applications { get; set; }
        /// <summary>
        /// AllowedAccessControlHierarchyGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-allowedaccesscontrolhierarchygroupid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AllowedAccessControlHierarchyGroupId { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// GranularAccessControlConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-granularaccesscontrolconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GranularAccessControlConfiguration
        /// </summary>
        public Union<Humidifier.Connect.SecurityProfileTypes.GranularAccessControlConfiguration, BaseFunction>? GranularAccessControlConfiguration { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Permissions { get; set; }
        public Union<string, BaseFunction>? SecurityProfileName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AllowedFlowModules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-allowedflowmodules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FlowModule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.SecurityProfileTypes.FlowModule>, IReadOnlyList<Union<Humidifier.Connect.SecurityProfileTypes.FlowModule, BaseFunction>>, BaseFunction>? AllowedFlowModules { get; set; }
        /// <summary>
        /// TagRestrictedResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-tagrestrictedresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TagRestrictedResources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// HierarchyRestrictedResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-hierarchyrestrictedresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HierarchyRestrictedResources { get; set; }
    }

    namespace SecurityProfileTypes
    {
        public class Application : Humidifier.Base.BaseSubResource, IHaveType, IHaveStringListOfApplicationPermissions, IHaveNamespace_
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-application.html#cfn-connect-securityprofile-application-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ApplicationPermissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-application.html#cfn-connect-securityprofile-application-applicationpermissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ApplicationPermissions { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-application.html#cfn-connect-securityprofile-application-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class DataTableAccessControlConfiguration : Humidifier.Base.BaseSubResource, IHaveConnectSecurityProfileTypesPrimaryAttributeAccessControlConfigurationItemPrimaryAttributeAccessControlConfiguration
        {
            /// <summary>
            /// PrimaryAttributeAccessControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-datatableaccesscontrolconfiguration.html#cfn-connect-securityprofile-datatableaccesscontrolconfiguration-primaryattributeaccesscontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrimaryAttributeAccessControlConfigurationItem
            /// </summary>
            public Union<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem, BaseFunction>? PrimaryAttributeAccessControlConfiguration { get; set; }
        }

        public class FlowModule : Humidifier.Base.BaseSubResource, IHaveType, IHaveFlowModuleId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-flowmodule.html#cfn-connect-securityprofile-flowmodule-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// FlowModuleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-flowmodule.html#cfn-connect-securityprofile-flowmodule-flowmoduleid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowModuleId { get; set; }
        }

        public class GranularAccessControlConfiguration : Humidifier.Base.BaseSubResource, IHaveConnectSecurityProfileTypesDataTableAccessControlConfigurationDataTableAccessControlConfiguration
        {
            /// <summary>
            /// DataTableAccessControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-granularaccesscontrolconfiguration.html#cfn-connect-securityprofile-granularaccesscontrolconfiguration-datatableaccesscontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataTableAccessControlConfiguration
            /// </summary>
            public Union<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration, BaseFunction>? DataTableAccessControlConfiguration { get; set; }
        }

        public class PrimaryAttributeAccessControlConfigurationItem : Humidifier.Base.BaseSubResource, IHaveListOfConnectSecurityProfileTypesPrimaryAttributeValuePrimaryAttributeValues
        {
            /// <summary>
            /// PrimaryAttributeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-primaryattributeaccesscontrolconfigurationitem.html#cfn-connect-securityprofile-primaryattributeaccesscontrolconfigurationitem-primaryattributevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrimaryAttributeValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeValue>, IReadOnlyList<Union<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeValue, BaseFunction>>, BaseFunction>? PrimaryAttributeValues { get; set; }
        }

        public class PrimaryAttributeValue : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveAttributeName, IHaveAccessType
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-primaryattributevalue.html#cfn-connect-securityprofile-primaryattributevalue-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-primaryattributevalue.html#cfn-connect-securityprofile-primaryattributevalue-attributename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
            /// <summary>
            /// AccessType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-primaryattributevalue.html#cfn-connect-securityprofile-primaryattributevalue-accesstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessType { get; set; }
        }
    }
}