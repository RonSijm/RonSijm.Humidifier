namespace Humidifier.SSMContacts
{
    using global::System.Collections.Generic;
    using PlanTypes;

    public class Plan : Humidifier.Base.BaseResource, IHaveStringListOfRotationIds, IHaveListOfSSMContactsPlanTypesStageStages, IHaveContactId
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SSMContacts.Plan; }
        /// <summary>
        /// RotationIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-plan.html#cfn-ssmcontacts-plan-rotationids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RotationIds { get; set; }
        /// <summary>
        /// Stages
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-plan.html#cfn-ssmcontacts-plan-stages
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Stage
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSMContacts.PlanTypes.Stage>, IReadOnlyList<Union<Humidifier.SSMContacts.PlanTypes.Stage, BaseFunction>>, BaseFunction>? Stages { get; set; }

        /// <summary>
        /// ContactId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-plan.html#cfn-ssmcontacts-plan-contactid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ContactId { get; set; }
    }

    namespace PlanTypes
    {
        public class ChannelTargetInfo : Humidifier.Base.BaseSubResource, IHaveRetryIntervalInMinutes_Integer, IHaveChannelId
        {
            /// <summary>
            /// RetryIntervalInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-plan-channeltargetinfo.html#cfn-ssmcontacts-plan-channeltargetinfo-retryintervalinminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetryIntervalInMinutes { get; set; }
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-plan-channeltargetinfo.html#cfn-ssmcontacts-plan-channeltargetinfo-channelid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-plan-contacttargetinfo.html#cfn-ssmcontacts-plan-contacttargetinfo-contactid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContactId { get; set; }
            /// <summary>
            /// IsEssential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-plan-contacttargetinfo.html#cfn-ssmcontacts-plan-contacttargetinfo-isessential
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEssential { get; set; }
        }

        public class Stage : Humidifier.Base.BaseSubResource, IHaveDurationInMinutes_Integer, IHaveListOfSSMContactsPlanTypesTargetsTargets
        {
            /// <summary>
            /// DurationInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-plan-stage.html#cfn-ssmcontacts-plan-stage-durationinminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationInMinutes { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-plan-stage.html#cfn-ssmcontacts-plan-stage-targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Targets
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSMContacts.PlanTypes.Targets>, IReadOnlyList<Union<Humidifier.SSMContacts.PlanTypes.Targets, BaseFunction>>, BaseFunction>? Targets { get; set; }
        }

        public class Targets : Humidifier.Base.BaseSubResource, IHaveSSMContactsPlanTypesChannelTargetInfoChannelTargetInfo, IHaveSSMContactsPlanTypesContactTargetInfoContactTargetInfo
        {
            /// <summary>
            /// ChannelTargetInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-plan-targets.html#cfn-ssmcontacts-plan-targets-channeltargetinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChannelTargetInfo
            /// </summary>
            public Union<Humidifier.SSMContacts.PlanTypes.ChannelTargetInfo, BaseFunction>? ChannelTargetInfo { get; set; }
            /// <summary>
            /// ContactTargetInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-plan-targets.html#cfn-ssmcontacts-plan-targets-contacttargetinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContactTargetInfo
            /// </summary>
            public Union<Humidifier.SSMContacts.PlanTypes.ContactTargetInfo, BaseFunction>? ContactTargetInfo { get; set; }
        }
    }
}