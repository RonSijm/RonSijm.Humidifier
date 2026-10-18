namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using KnowledgeBaseTypes;

    public class KnowledgeBase : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDataSourceArn, IHaveQuickSightKnowledgeBaseTypesAccessControlConfigurationAccessControlConfiguration, IHaveDescription, IHaveQuickSightKnowledgeBaseTypesKnowledgeBaseConfigurationKnowledgeBaseConfiguration, IHaveIsEmailNotificationOptedForIngestionFailures_Boolean, IHaveQuickSightKnowledgeBaseTypesMediaExtractionConfigurationMediaExtractionConfiguration, IHaveAwsAccountId, IHaveListOfQuickSightKnowledgeBaseTypesResourcePermissionPermissions, IHaveKnowledgeBaseId, IHavePrimaryOwnerArn, IHaveName
    {
        public class Attributes
        {
            public static string DocumentCount =  "DocumentCount" ;
            public static string Status =  "Status" ;
            public static string Type =  "Type" ;
            public static string KnowledgeBaseSizeBytes =  "KnowledgeBaseSizeBytes" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string KnowledgeBaseArn =  "KnowledgeBaseArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string PrimaryOwnerUsername =  "PrimaryOwnerUsername" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.KnowledgeBase; }

        /// <summary>
        /// DataSourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-datasourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataSourceArn { get; set; }
        /// <summary>
        /// AccessControlConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-accesscontrolconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessControlConfiguration
        /// </summary>
        public Union<Humidifier.QuickSight.KnowledgeBaseTypes.AccessControlConfiguration, BaseFunction>? AccessControlConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// KnowledgeBaseConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-knowledgebaseconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: KnowledgeBaseConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.QuickSight.KnowledgeBaseTypes.KnowledgeBaseConfiguration, BaseFunction>? KnowledgeBaseConfiguration { get; set; }
        /// <summary>
        /// IsEmailNotificationOptedForIngestionFailures
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-isemailnotificationoptedforingestionfailures
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsEmailNotificationOptedForIngestionFailures { get; set; }
        /// <summary>
        /// MediaExtractionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-mediaextractionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MediaExtractionConfiguration
        /// </summary>
        public Union<Humidifier.QuickSight.KnowledgeBaseTypes.MediaExtractionConfiguration, BaseFunction>? MediaExtractionConfiguration { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.KnowledgeBaseTypes.ResourcePermission>, IReadOnlyList<Union<Humidifier.QuickSight.KnowledgeBaseTypes.ResourcePermission, BaseFunction>>, BaseFunction>? Permissions { get; set; }

        /// <summary>
        /// KnowledgeBaseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-knowledgebaseid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KnowledgeBaseId { get; set; }
        /// <summary>
        /// PrimaryOwnerArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-primaryownerarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrimaryOwnerArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace KnowledgeBaseTypes
    {
        public class AccessControlConfiguration : Humidifier.Base.BaseSubResource, IHaveIsACLEnabled_Boolean
        {
            /// <summary>
            /// IsACLEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-accesscontrolconfiguration.html#cfn-quicksight-knowledgebase-accesscontrolconfiguration-isaclenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsACLEnabled { get; set; }
        }

        public class AudioExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveAudioExtractionStatus
        {
            /// <summary>
            /// AudioExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-audioextractionconfiguration.html#cfn-quicksight-knowledgebase-audioextractionconfiguration-audioextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioExtractionStatus { get; set; }
        }

        public class ImageExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveImageExtractionStatus
        {
            /// <summary>
            /// ImageExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-imageextractionconfiguration.html#cfn-quicksight-knowledgebase-imageextractionconfiguration-imageextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageExtractionStatus { get; set; }
        }

        public class KbTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveTemplate_Json
        {
            /// <summary>
            /// Template
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-kbtemplateconfiguration.html#cfn-quicksight-knowledgebase-kbtemplateconfiguration-template
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Template { get; set; }
        }

        public class KnowledgeBaseConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightKnowledgeBaseTypesKbTemplateConfigurationTemplateConfiguration
        {
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-knowledgebaseconfiguration.html#cfn-quicksight-knowledgebase-knowledgebaseconfiguration-templateconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KbTemplateConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration, BaseFunction>? TemplateConfiguration { get; set; }
        }

        public class MediaExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveQuickSightKnowledgeBaseTypesVideoExtractionConfigurationVideoExtractionConfiguration, IHaveQuickSightKnowledgeBaseTypesAudioExtractionConfigurationAudioExtractionConfiguration, IHaveQuickSightKnowledgeBaseTypesImageExtractionConfigurationImageExtractionConfiguration
        {
            /// <summary>
            /// VideoExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-mediaextractionconfiguration.html#cfn-quicksight-knowledgebase-mediaextractionconfiguration-videoextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoExtractionConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.KnowledgeBaseTypes.VideoExtractionConfiguration, BaseFunction>? VideoExtractionConfiguration { get; set; }
            /// <summary>
            /// AudioExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-mediaextractionconfiguration.html#cfn-quicksight-knowledgebase-mediaextractionconfiguration-audioextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioExtractionConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.KnowledgeBaseTypes.AudioExtractionConfiguration, BaseFunction>? AudioExtractionConfiguration { get; set; }
            /// <summary>
            /// ImageExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-mediaextractionconfiguration.html#cfn-quicksight-knowledgebase-mediaextractionconfiguration-imageextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageExtractionConfiguration
            /// </summary>
            public Union<Humidifier.QuickSight.KnowledgeBaseTypes.ImageExtractionConfiguration, BaseFunction>? ImageExtractionConfiguration { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHaveResource, IHavePrincipal
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-resourcepermission.html#cfn-quicksight-knowledgebase-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-resourcepermission.html#cfn-quicksight-knowledgebase-resourcepermission-resource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Resource { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-resourcepermission.html#cfn-quicksight-knowledgebase-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Principal { get; set; }
        }

        public class VideoExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveVideoExtractionStatus, IHaveVideoExtractionType
        {
            /// <summary>
            /// VideoExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-videoextractionconfiguration.html#cfn-quicksight-knowledgebase-videoextractionconfiguration-videoextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoExtractionStatus { get; set; }
            /// <summary>
            /// VideoExtractionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-videoextractionconfiguration.html#cfn-quicksight-knowledgebase-videoextractionconfiguration-videoextractiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoExtractionType { get; set; }
        }
    }
}