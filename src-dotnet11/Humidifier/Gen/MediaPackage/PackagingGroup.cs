namespace Humidifier.MediaPackage
{
    using global::System.Collections.Generic;
    using PackagingGroupTypes;

    public class PackagingGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveMediaPackagePackagingGroupTypesAuthorizationAuthorization, IHaveId, IHaveMediaPackagePackagingGroupTypesLogConfigurationEgressAccessLogs
    {
        public class Attributes
        {
            public static string DomainName =  "DomainName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaPackage.PackagingGroup; }
        /// <summary>
        /// Authorization
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packaginggroup.html#cfn-mediapackage-packaginggroup-authorization
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Authorization
        /// </summary>
        public Union<Humidifier.MediaPackage.PackagingGroupTypes.Authorization, BaseFunction>? Authorization { get; set; }

        /// <summary>
        /// Id
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packaginggroup.html#cfn-mediapackage-packaginggroup-id
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Id { get; set; }
        /// <summary>
        /// EgressAccessLogs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packaginggroup.html#cfn-mediapackage-packaginggroup-egressaccesslogs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfiguration
        /// </summary>
        public Union<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration, BaseFunction>? EgressAccessLogs { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packaginggroup.html#cfn-mediapackage-packaginggroup-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PackagingGroupTypes
    {
        public class Authorization : Humidifier.Base.BaseSubResource, IHaveSecretsRoleArn, IHaveCdnIdentifierSecret
        {
            /// <summary>
            /// SecretsRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packaginggroup-authorization.html#cfn-mediapackage-packaginggroup-authorization-secretsrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsRoleArn { get; set; }
            /// <summary>
            /// CdnIdentifierSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packaginggroup-authorization.html#cfn-mediapackage-packaginggroup-authorization-cdnidentifiersecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CdnIdentifierSecret { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroupName
        {
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packaginggroup-logconfiguration.html#cfn-mediapackage-packaginggroup-logconfiguration-loggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
        }
    }
}