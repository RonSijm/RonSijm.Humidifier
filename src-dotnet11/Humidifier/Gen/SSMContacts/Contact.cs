namespace Humidifier.SSMContacts
{
    using global::System.Collections.Generic;
    using ContactTypes;

    public class Contact : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveAlias, IHaveDisplayName, IHaveListOfSSMContactsContactTypesStagePlan
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
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-alias
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Alias { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// Plan
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-plan
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Stage
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSMContacts.ContactTypes.Stage>, IReadOnlyList<Union<Humidifier.SSMContacts.ContactTypes.Stage, BaseFunction>>, BaseFunction>? Plan { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ContactTypes
    {
        public class ChannelTargetInfo : Humidifier.Base.BaseSubResource, IHaveRetryIntervalInMinutes_Integer, IHaveChannelId
        {
            /// <summary>
            /// RetryIntervalInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-channeltargetinfo.html#cfn-ssmcontacts-contact-channeltargetinfo-retryintervalinminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetryIntervalInMinutes { get; set; }
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-channeltargetinfo.html#cfn-ssmcontacts-contact-channeltargetinfo-channelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelId { get; set; }
        }

        public class ContactTargetInfo : Humidifier.Base.BaseSubResource, IHaveContactId, IHaveIsEssential_Boolean
        {
            /// <summary>
            /// ContactId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-contacttargetinfo.html#cfn-ssmcontacts-contact-contacttargetinfo-contactid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContactId { get; set; }
            /// <summary>
            /// IsEssential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-contacttargetinfo.html#cfn-ssmcontacts-contact-contacttargetinfo-isessential
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEssential { get; set; }
        }

        public class Stage : Humidifier.Base.BaseSubResource, IHaveDurationInMinutes_Integer, IHaveStringListOfRotationIds, IHaveListOfSSMContactsContactTypesTargetsTargets
        {
            /// <summary>
            /// DurationInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-stage.html#cfn-ssmcontacts-contact-stage-durationinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationInMinutes { get; set; }
            /// <summary>
            /// RotationIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-stage.html#cfn-ssmcontacts-contact-stage-rotationids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RotationIds { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-stage.html#cfn-ssmcontacts-contact-stage-targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Targets
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSMContacts.ContactTypes.Targets>, IReadOnlyList<Union<Humidifier.SSMContacts.ContactTypes.Targets, BaseFunction>>, BaseFunction>? Targets { get; set; }
        }

        public class Targets : Humidifier.Base.BaseSubResource, IHaveSSMContactsContactTypesChannelTargetInfoChannelTargetInfo, IHaveSSMContactsContactTypesContactTargetInfoContactTargetInfo
        {
            /// <summary>
            /// ChannelTargetInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-targets.html#cfn-ssmcontacts-contact-targets-channeltargetinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChannelTargetInfo
            /// </summary>
            public Union<Humidifier.SSMContacts.ContactTypes.ChannelTargetInfo, BaseFunction>? ChannelTargetInfo { get; set; }
            /// <summary>
            /// ContactTargetInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-contact-targets.html#cfn-ssmcontacts-contact-targets-contacttargetinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContactTargetInfo
            /// </summary>
            public Union<Humidifier.SSMContacts.ContactTypes.ContactTargetInfo, BaseFunction>? ContactTargetInfo { get; set; }
        }
    }
}