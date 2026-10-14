namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using WorkspaceTypes;

    public class Workspace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKmsKeyId, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string WorkspaceArn =  "WorkspaceArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.Workspace; }
        /// <summary>
        /// WorkspaceDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-workspace.html#cfn-iotsitewise-workspace-workspacedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic WorkspaceDescription { get; set; }

        [Ignore]
        public dynamic Description { get => WorkspaceDescription; set => WorkspaceDescription = value; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-workspace.html#cfn-iotsitewise-workspace-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }

        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-workspace.html#cfn-iotsitewise-workspace-encryptionconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        [Required]
        public Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration EncryptionConfiguration { get; set; }
        public dynamic WorkspaceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-workspace.html#cfn-iotsitewise-workspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace WorkspaceTypes
    {
        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveEncryptionType
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-workspace-encryptionconfiguration.html#cfn-iotsitewise-workspace-encryptionconfiguration-encryptiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionType { get; set; }
        }
    }
}