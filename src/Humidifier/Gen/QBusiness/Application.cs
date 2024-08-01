namespace Humidifier.QBusiness
{
    using System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string IdentityCenterApplicationArn =  "IdentityCenterApplicationArn" ;
            public static string ApplicationArn =  "ApplicationArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ApplicationId =  "ApplicationId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.QBusiness.Application; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// IdentityCenterInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-identitycenterinstancearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityCenterInstanceArn { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public ApplicationTypes.EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// QAppsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-qappsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QAppsConfiguration
        /// </summary>
        public ApplicationTypes.QAppsConfiguration QAppsConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// AttachmentsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-application.html#cfn-qbusiness-application-attachmentsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AttachmentsConfiguration
        /// </summary>
        public ApplicationTypes.AttachmentsConfiguration AttachmentsConfiguration { get; set; }
    }

    namespace ApplicationTypes
    {
        public class AttachmentsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AttachmentsControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-application-attachmentsconfiguration.html#cfn-qbusiness-application-attachmentsconfiguration-attachmentscontrolmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttachmentsControlMode { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-application-encryptionconfiguration.html#cfn-qbusiness-application-encryptionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
        }

        public class QAppsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QAppsControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-application-qappsconfiguration.html#cfn-qbusiness-application-qappsconfiguration-qappscontrolmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QAppsControlMode { get; set; }
        }
    }
}