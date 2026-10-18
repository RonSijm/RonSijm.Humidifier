namespace Humidifier.StepFunctions
{
    using global::System.Collections.Generic;
    using ActivityTypes;

    public class Activity : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStepFunctionsActivityTypesEncryptionConfigurationEncryptionConfiguration, IHaveListOfStepFunctionsActivityTypesTagsEntryTags, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.StepFunctions.Activity; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-activity.html#cfn-stepfunctions-activity-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-activity.html#cfn-stepfunctions-activity-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsEntry
        /// </summary>
        public Union<IReadOnlyList<Humidifier.StepFunctions.ActivityTypes.TagsEntry>, IReadOnlyList<Union<Humidifier.StepFunctions.ActivityTypes.TagsEntry, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ActivityTypes
    {
        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveKmsKeyId, IHaveKmsDataKeyReusePeriodSeconds_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-activity-encryptionconfiguration.html#cfn-stepfunctions-activity-encryptionconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-activity-encryptionconfiguration.html#cfn-stepfunctions-activity-encryptionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// KmsDataKeyReusePeriodSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-activity-encryptionconfiguration.html#cfn-stepfunctions-activity-encryptionconfiguration-kmsdatakeyreuseperiodseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? KmsDataKeyReusePeriodSeconds { get; set; }
        }

        public class TagsEntry : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-activity-tagsentry.html#cfn-stepfunctions-activity-tagsentry-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-activity-tagsentry.html#cfn-stepfunctions-activity-tagsentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}