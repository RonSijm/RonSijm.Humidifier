namespace Humidifier.SSMContacts
{
    using System.Collections.Generic;
    using ContactTypes;

    public class Contact : Humidifier.Base.BaseResource, IHaveType, IHaveDisplayName, IHaveAlias
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SSMContacts.Contact; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }

        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-alias
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Alias { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// Plan
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-plan
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Stage
        /// </summary>
        public List<Humidifier.SSMContacts.ContactTypes.Stage> Plan { get; set; }
    }

    namespace ContactTypes
    {
        public class ChannelTargetInfo : Humidifier.Base.BaseSubResource, IHaveChannelId
        {
            /// <summary>
            /// RetryIntervalInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-channeltargetinfo.html#cfn-ssmcontacts-contact-channeltargetinfo-retryintervalinminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RetryIntervalInMinutes { get; set; }
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-channeltargetinfo.html#cfn-ssmcontacts-contact-channeltargetinfo-channelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelId { get; set; }
        }

        public class ContactTargetInfo : Humidifier.Base.BaseSubResource, IHaveContactId
        {
            /// <summary>
            /// ContactId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-contacttargetinfo.html#cfn-ssmcontacts-contact-contacttargetinfo-contactid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContactId { get; set; }
            /// <summary>
            /// IsEssential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-contacttargetinfo.html#cfn-ssmcontacts-contact-contacttargetinfo-isessential
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsEssential { get; set; }
        }

        public class Stage : Humidifier.Base.BaseSubResource, IHaveDurationInMinutes
        {
            /// <summary>
            /// DurationInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-stage.html#cfn-ssmcontacts-contact-stage-durationinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInMinutes { get; set; }
            /// <summary>
            /// RotationIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-stage.html#cfn-ssmcontacts-contact-stage-rotationids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic RotationIds { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-stage.html#cfn-ssmcontacts-contact-stage-targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Targets
            /// </summary>
            public List<Humidifier.SSMContacts.ContactTypes.Targets> Targets { get; set; }
        }

        public class Targets : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChannelTargetInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-targets.html#cfn-ssmcontacts-contact-targets-channeltargetinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChannelTargetInfo
            /// </summary>
            public Humidifier.SSMContacts.ContactTypes.ChannelTargetInfo ChannelTargetInfo { get; set; }
            /// <summary>
            /// ContactTargetInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-targets.html#cfn-ssmcontacts-contact-targets-contacttargetinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContactTargetInfo
            /// </summary>
            public Humidifier.SSMContacts.ContactTypes.ContactTargetInfo ContactTargetInfo { get; set; }
        }
    }
}