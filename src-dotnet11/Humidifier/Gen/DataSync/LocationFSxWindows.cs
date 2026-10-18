namespace Humidifier.DataSync
{
    using global::System.Collections.Generic;
    using LocationFSxWindowsTypes;

    public class LocationFSxWindows : Humidifier.Base.BaseResource, IHaveTags, IHaveUser, IHaveDataSyncLocationFSxWindowsTypesCmkSecretConfigCmkSecretConfig, IHaveSubdirectory, IHaveFsxFilesystemArn, IHaveDataSyncLocationFSxWindowsTypesCustomSecretConfigCustomSecretConfig, IHaveDomain, IHaveStringListOfSecurityGroupArns, IHavePassword
    {
        public class Attributes
        {
            public static string ManagedSecretConfig =  "ManagedSecretConfig" ;
            public static string LocationUri =  "LocationUri" ;
            public static string LocationArn =  "LocationArn" ;
        }

        public override string AWSTypeName { get => AWS.DataSync.LocationFSxWindows; }

        /// <summary>
        /// User
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxwindows.html#cfn-datasync-locationfsxwindows-user
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? User { get; set; }
        /// <summary>
        /// CmkSecretConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxwindows.html#cfn-datasync-locationfsxwindows-cmksecretconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CmkSecretConfig
        /// </summary>
        public Union<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig, BaseFunction>? CmkSecretConfig { get; set; }
        /// <summary>
        /// Subdirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxwindows.html#cfn-datasync-locationfsxwindows-subdirectory
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Subdirectory { get; set; }
        /// <summary>
        /// FsxFilesystemArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxwindows.html#cfn-datasync-locationfsxwindows-fsxfilesystemarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FsxFilesystemArn { get; set; }
        /// <summary>
        /// CustomSecretConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxwindows.html#cfn-datasync-locationfsxwindows-customsecretconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomSecretConfig
        /// </summary>
        public Union<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig, BaseFunction>? CustomSecretConfig { get; set; }
        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxwindows.html#cfn-datasync-locationfsxwindows-domain
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Domain { get; set; }

        /// <summary>
        /// SecurityGroupArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxwindows.html#cfn-datasync-locationfsxwindows-securitygrouparns
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupArns { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxwindows.html#cfn-datasync-locationfsxwindows-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Password
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxwindows.html#cfn-datasync-locationfsxwindows-password
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Password { get; set; }
    }

    namespace LocationFSxWindowsTypes
    {
        public class CmkSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveKmsKeyArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxwindows-cmksecretconfig.html#cfn-datasync-locationfsxwindows-cmksecretconfig-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxwindows-cmksecretconfig.html#cfn-datasync-locationfsxwindows-cmksecretconfig-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }

        public class CustomSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveSecretAccessRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxwindows-customsecretconfig.html#cfn-datasync-locationfsxwindows-customsecretconfig-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// SecretAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxwindows-customsecretconfig.html#cfn-datasync-locationfsxwindows-customsecretconfig-secretaccessrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretAccessRoleArn { get; set; }
        }

        public class ManagedSecretConfig : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxwindows-managedsecretconfig.html#cfn-datasync-locationfsxwindows-managedsecretconfig-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }
    }
}