namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using KnowledgeBaseTypes;

    public class KnowledgeBase : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveAwsAccountId, IHaveKnowledgeBaseId, IHaveDataSourceArn
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
        public dynamic DataSourceArn { get; set; }
        /// <summary>
        /// AccessControlConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-accesscontrolconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessControlConfiguration
        /// </summary>
        public Humidifier.QuickSight.KnowledgeBaseTypes.AccessControlConfiguration AccessControlConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// KnowledgeBaseConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-knowledgebaseconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: KnowledgeBaseConfiguration
        /// </summary>
        [Required]
        public Humidifier.QuickSight.KnowledgeBaseTypes.KnowledgeBaseConfiguration KnowledgeBaseConfiguration { get; set; }
        /// <summary>
        /// IsEmailNotificationOptedForIngestionFailures
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-isemailnotificationoptedforingestionfailures
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IsEmailNotificationOptedForIngestionFailures { get; set; }
        /// <summary>
        /// MediaExtractionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-mediaextractionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MediaExtractionConfiguration
        /// </summary>
        public Humidifier.QuickSight.KnowledgeBaseTypes.MediaExtractionConfiguration MediaExtractionConfiguration { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<Humidifier.QuickSight.KnowledgeBaseTypes.ResourcePermission> Permissions { get; set; }

        /// <summary>
        /// KnowledgeBaseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-knowledgebaseid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic KnowledgeBaseId { get; set; }
        /// <summary>
        /// PrimaryOwnerArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-primaryownerarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PrimaryOwnerArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-knowledgebase.html#cfn-quicksight-knowledgebase-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace KnowledgeBaseTypes
    {
        public class AccessControlConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IsACLEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-accesscontrolconfiguration.html#cfn-quicksight-knowledgebase-accesscontrolconfiguration-isaclenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsACLEnabled { get; set; }
        }

        public class AudioExtractionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AudioExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-audioextractionconfiguration.html#cfn-quicksight-knowledgebase-audioextractionconfiguration-audioextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioExtractionStatus { get; set; }
        }

        public class ImageExtractionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImageExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-imageextractionconfiguration.html#cfn-quicksight-knowledgebase-imageextractionconfiguration-imageextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageExtractionStatus { get; set; }
        }

        public class KbTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveTemplate
        {
            /// <summary>
            /// Template
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-kbtemplateconfiguration.html#cfn-quicksight-knowledgebase-kbtemplateconfiguration-template
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Template { get; set; }
        }

        public class KnowledgeBaseConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-knowledgebaseconfiguration.html#cfn-quicksight-knowledgebase-knowledgebaseconfiguration-templateconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KbTemplateConfiguration
            /// </summary>
            public Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration TemplateConfiguration { get; set; }
        }

        public class MediaExtractionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VideoExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-mediaextractionconfiguration.html#cfn-quicksight-knowledgebase-mediaextractionconfiguration-videoextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoExtractionConfiguration
            /// </summary>
            public Humidifier.QuickSight.KnowledgeBaseTypes.VideoExtractionConfiguration VideoExtractionConfiguration { get; set; }
            /// <summary>
            /// AudioExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-mediaextractionconfiguration.html#cfn-quicksight-knowledgebase-mediaextractionconfiguration-audioextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioExtractionConfiguration
            /// </summary>
            public Humidifier.QuickSight.KnowledgeBaseTypes.AudioExtractionConfiguration AudioExtractionConfiguration { get; set; }
            /// <summary>
            /// ImageExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-mediaextractionconfiguration.html#cfn-quicksight-knowledgebase-mediaextractionconfiguration-imageextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageExtractionConfiguration
            /// </summary>
            public Humidifier.QuickSight.KnowledgeBaseTypes.ImageExtractionConfiguration ImageExtractionConfiguration { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHavePrincipal, IHaveActions, IHaveResource
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-resourcepermission.html#cfn-quicksight-knowledgebase-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-resourcepermission.html#cfn-quicksight-knowledgebase-resourcepermission-resource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Resource { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-resourcepermission.html#cfn-quicksight-knowledgebase-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Principal { get; set; }
        }

        public class VideoExtractionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VideoExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-videoextractionconfiguration.html#cfn-quicksight-knowledgebase-videoextractionconfiguration-videoextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VideoExtractionStatus { get; set; }
            /// <summary>
            /// VideoExtractionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-knowledgebase-videoextractionconfiguration.html#cfn-quicksight-knowledgebase-videoextractionconfiguration-videoextractiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VideoExtractionType { get; set; }
        }
    }
}