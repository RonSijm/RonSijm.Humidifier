namespace Humidifier.RolesAnywhere
{
    using global::System.Collections.Generic;
    using TrustAnchorTypes;

    public class TrustAnchor : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfRolesAnywhereTrustAnchorTypesNotificationSettingNotificationSettings, IHaveEnabled_Boolean, IHaveRolesAnywhereTrustAnchorTypesSourceSource, IHaveName
    {
        public class Attributes
        {
            public static string TrustAnchorArn =  "TrustAnchorArn" ;
            public static string TrustAnchorId =  "TrustAnchorId" ;
        }

        public override string AWSTypeName { get => AWS.RolesAnywhere.TrustAnchor; }
        /// <summary>
        /// NotificationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-trustanchor.html#cfn-rolesanywhere-trustanchor-notificationsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NotificationSetting
        /// </summary>
        public Union<IReadOnlyList<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting>, IReadOnlyList<Union<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting, BaseFunction>>, BaseFunction>? NotificationSettings { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-trustanchor.html#cfn-rolesanywhere-trustanchor-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enabled { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-trustanchor.html#cfn-rolesanywhere-trustanchor-source
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Source
        /// </summary>
        [Required]
        public Union<Humidifier.RolesAnywhere.TrustAnchorTypes.Source, BaseFunction>? Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rolesanywhere-trustanchor.html#cfn-rolesanywhere-trustanchor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TrustAnchorTypes
    {
        public class NotificationSetting : Humidifier.Base.BaseSubResource, IHaveChannel, IHaveEnabled_Boolean, IHaveEvent, IHaveThreshold_Double
        {
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-trustanchor-notificationsetting.html#cfn-rolesanywhere-trustanchor-notificationsetting-channel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Channel { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-trustanchor-notificationsetting.html#cfn-rolesanywhere-trustanchor-notificationsetting-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Event
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-trustanchor-notificationsetting.html#cfn-rolesanywhere-trustanchor-notificationsetting-event
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Event { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-trustanchor-notificationsetting.html#cfn-rolesanywhere-trustanchor-notificationsetting-threshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Threshold { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource, IHaveSourceType, IHaveRolesAnywhereTrustAnchorTypesSourceDataSourceData
        {
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-trustanchor-source.html#cfn-rolesanywhere-trustanchor-source-sourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceType { get; set; }
            /// <summary>
            /// SourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-trustanchor-source.html#cfn-rolesanywhere-trustanchor-source-sourcedata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SourceData
            /// </summary>
            public Union<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData, BaseFunction>? SourceData { get; set; }
        }

        public class SourceData : Humidifier.Base.BaseSubResource, IHaveAcmPcaArn, IHaveX509CertificateData
        {
            /// <summary>
            /// AcmPcaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-trustanchor-sourcedata.html#cfn-rolesanywhere-trustanchor-sourcedata-acmpcaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AcmPcaArn { get; set; }
            /// <summary>
            /// X509CertificateData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rolesanywhere-trustanchor-sourcedata.html#cfn-rolesanywhere-trustanchor-sourcedata-x509certificatedata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? X509CertificateData { get; set; }
        }
    }
}