namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using AppInstanceUserTypes;

    public class AppInstanceUser : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveMetadata
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
        public dynamic AppInstanceUserId { get; set; }
        /// <summary>
        /// ExpirationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstanceuser.html#cfn-chime-appinstanceuser-expirationsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExpirationSettings
        /// </summary>
        public Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings ExpirationSettings { get; set; }
        /// <summary>
        /// Metadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstanceuser.html#cfn-chime-appinstanceuser-metadata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Metadata { get; set; }

        /// <summary>
        /// AppInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstanceuser.html#cfn-chime-appinstanceuser-appinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AppInstanceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstanceuser.html#cfn-chime-appinstanceuser-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AppInstanceUserTypes
    {
        public class ExpirationSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExpirationCriterion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstanceuser-expirationsettings.html#cfn-chime-appinstanceuser-expirationsettings-expirationcriterion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExpirationCriterion { get; set; }
            /// <summary>
            /// ExpirationDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstanceuser-expirationsettings.html#cfn-chime-appinstanceuser-expirationsettings-expirationdays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ExpirationDays { get; set; }
        }
    }
}