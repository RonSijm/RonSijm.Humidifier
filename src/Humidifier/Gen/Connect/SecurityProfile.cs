namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using SecurityProfileTypes;

    public class SecurityProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveInstanceArn, IHavePermissions, IHaveSecurityProfileName
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
        public dynamic Description { get; set; }
        /// <summary>
        /// AllowedAccessControlTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-allowedaccesscontroltags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> AllowedAccessControlTags { get; set; }
        /// <summary>
        /// Applications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-applications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Application
        /// </summary>
        public List<Humidifier.Connect.SecurityProfileTypes.Application> Applications { get; set; }
        /// <summary>
        /// AllowedAccessControlHierarchyGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-allowedaccesscontrolhierarchygroupid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AllowedAccessControlHierarchyGroupId { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// GranularAccessControlConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-granularaccesscontrolconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GranularAccessControlConfiguration
        /// </summary>
        public Humidifier.Connect.SecurityProfileTypes.GranularAccessControlConfiguration GranularAccessControlConfiguration { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Permissions { get; set; }
        public dynamic SecurityProfileName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AllowedFlowModules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-allowedflowmodules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FlowModule
        /// </summary>
        public List<Humidifier.Connect.SecurityProfileTypes.FlowModule> AllowedFlowModules { get; set; }
        /// <summary>
        /// TagRestrictedResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-tagrestrictedresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic TagRestrictedResources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// HierarchyRestrictedResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securityprofile.html#cfn-connect-securityprofile-hierarchyrestrictedresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic HierarchyRestrictedResources { get; set; }
    }

    namespace SecurityProfileTypes
    {
        public class Application : Humidifier.Base.BaseSubResource, IHaveType, IHaveNamespace_
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-application.html#cfn-connect-securityprofile-application-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// ApplicationPermissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-application.html#cfn-connect-securityprofile-application-applicationpermissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ApplicationPermissions { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-application.html#cfn-connect-securityprofile-application-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
        }

        public class DataTableAccessControlConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrimaryAttributeAccessControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-datatableaccesscontrolconfiguration.html#cfn-connect-securityprofile-datatableaccesscontrolconfiguration-primaryattributeaccesscontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrimaryAttributeAccessControlConfigurationItem
            /// </summary>
            public Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem PrimaryAttributeAccessControlConfiguration { get; set; }
        }

        public class FlowModule : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-flowmodule.html#cfn-connect-securityprofile-flowmodule-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// FlowModuleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-flowmodule.html#cfn-connect-securityprofile-flowmodule-flowmoduleid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlowModuleId { get; set; }
        }

        public class GranularAccessControlConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataTableAccessControlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-granularaccesscontrolconfiguration.html#cfn-connect-securityprofile-granularaccesscontrolconfiguration-datatableaccesscontrolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataTableAccessControlConfiguration
            /// </summary>
            public Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration DataTableAccessControlConfiguration { get; set; }
        }

        public class PrimaryAttributeAccessControlConfigurationItem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrimaryAttributeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-primaryattributeaccesscontrolconfigurationitem.html#cfn-connect-securityprofile-primaryattributeaccesscontrolconfigurationitem-primaryattributevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrimaryAttributeValue
            /// </summary>
            public List<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeValue> PrimaryAttributeValues { get; set; }
        }

        public class PrimaryAttributeValue : Humidifier.Base.BaseSubResource, IHaveValues, IHaveAttributeName, IHaveAccessType
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-primaryattributevalue.html#cfn-connect-securityprofile-primaryattributevalue-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-primaryattributevalue.html#cfn-connect-securityprofile-primaryattributevalue-attributename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName { get; set; }
            /// <summary>
            /// AccessType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-securityprofile-primaryattributevalue.html#cfn-connect-securityprofile-primaryattributevalue-accesstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessType { get; set; }
        }
    }
}