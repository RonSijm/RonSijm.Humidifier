namespace Humidifier.WorkSpacesWeb
{
    using global::System.Collections.Generic;
    using SessionLoggerTypes;

    public class SessionLogger : Humidifier.Base.BaseResource, IHaveTags, IHaveCustomerManagedKey, IHaveStringDictionaryOfAdditionalEncryptionContext, IHaveDisplayName, IHaveWorkSpacesWebSessionLoggerTypesEventFilterEventFilter, IHaveWorkSpacesWebSessionLoggerTypesLogConfigurationLogConfiguration
    {
        public class Attributes
        {
            public static string CreationDate =  "CreationDate" ;
            public static string AssociatedPortalArns =  "AssociatedPortalArns" ;
            public static string SessionLoggerArn =  "SessionLoggerArn" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpacesWeb.SessionLogger; }
        /// <summary>
        /// CustomerManagedKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-sessionlogger.html#cfn-workspacesweb-sessionlogger-customermanagedkey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomerManagedKey { get; set; }
        /// <summary>
        /// AdditionalEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-sessionlogger.html#cfn-workspacesweb-sessionlogger-additionalencryptioncontext
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalEncryptionContext { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-sessionlogger.html#cfn-workspacesweb-sessionlogger-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// EventFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-sessionlogger.html#cfn-workspacesweb-sessionlogger-eventfilter
        /// Required: True
        /// UpdateType: Mutable
        /// Type: EventFilter
        /// </summary>
        [Required]
        public Union<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter, BaseFunction>? EventFilter { get; set; }

        /// <summary>
        /// LogConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-sessionlogger.html#cfn-workspacesweb-sessionlogger-logconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: LogConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration, BaseFunction>? LogConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-sessionlogger.html#cfn-workspacesweb-sessionlogger-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SessionLoggerTypes
    {
        public class EventFilter : Humidifier.Base.BaseSubResource, IHaveAll_Json, IHaveStringListOfInclude
        {
            /// <summary>
            /// All
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-sessionlogger-eventfilter.html#cfn-workspacesweb-sessionlogger-eventfilter-all
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? All { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-sessionlogger-eventfilter.html#cfn-workspacesweb-sessionlogger-eventfilter-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Include { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveWorkSpacesWebSessionLoggerTypesS3LogConfigurationS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-sessionlogger-logconfiguration.html#cfn-workspacesweb-sessionlogger-logconfiguration-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3LogConfiguration
            /// </summary>
            public Union<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration, BaseFunction>? S3 { get; set; }
        }

        public class S3LogConfiguration : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveFolderStructure, IHaveLogFileFormat, IHaveBucketOwner, IHaveKeyPrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-sessionlogger-s3logconfiguration.html#cfn-workspacesweb-sessionlogger-s3logconfiguration-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// FolderStructure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-sessionlogger-s3logconfiguration.html#cfn-workspacesweb-sessionlogger-s3logconfiguration-folderstructure
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FolderStructure { get; set; }
            /// <summary>
            /// LogFileFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-sessionlogger-s3logconfiguration.html#cfn-workspacesweb-sessionlogger-s3logconfiguration-logfileformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogFileFormat { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-sessionlogger-s3logconfiguration.html#cfn-workspacesweb-sessionlogger-s3logconfiguration-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwner { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-sessionlogger-s3logconfiguration.html#cfn-workspacesweb-sessionlogger-s3logconfiguration-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyPrefix { get; set; }
        }
    }
}