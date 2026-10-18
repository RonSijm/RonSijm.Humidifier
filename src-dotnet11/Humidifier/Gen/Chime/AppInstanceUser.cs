namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using AppInstanceUserTypes;

    public class AppInstanceUser : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAppInstanceUserId, IHaveChimeAppInstanceUserTypesExpirationSettingsExpirationSettings, IHaveMetadata, IHaveAppInstanceArn, IHaveName
    {
        public class Attributes
        {
            public static string AppInstanceUserArn =  "AppInstanceUserArn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.AppInstanceUser; }

        /// <summary>
        /// AppInstanceUserId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstanceuser.html#cfn-chime-appinstanceuser-appinstanceuserid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AppInstanceUserId { get; set; }
        /// <summary>
        /// ExpirationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstanceuser.html#cfn-chime-appinstanceuser-expirationsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExpirationSettings
        /// </summary>
        public Union<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings, BaseFunction>? ExpirationSettings { get; set; }
        /// <summary>
        /// Metadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstanceuser.html#cfn-chime-appinstanceuser-metadata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Metadata { get; set; }

        /// <summary>
        /// AppInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstanceuser.html#cfn-chime-appinstanceuser-appinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AppInstanceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstanceuser.html#cfn-chime-appinstanceuser-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AppInstanceUserTypes
    {
        public class ExpirationSettings : Humidifier.Base.BaseSubResource, IHaveExpirationCriterion, IHaveExpirationDays_Integer
        {
            /// <summary>
            /// ExpirationCriterion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstanceuser-expirationsettings.html#cfn-chime-appinstanceuser-expirationsettings-expirationcriterion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpirationCriterion { get; set; }
            /// <summary>
            /// ExpirationDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstanceuser-expirationsettings.html#cfn-chime-appinstanceuser-expirationsettings-expirationdays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExpirationDays { get; set; }
        }
    }
}