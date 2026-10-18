namespace Humidifier.MediaConvert
{
    using global::System.Collections.Generic;
    using JobTemplateTypes;

    public class JobTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveCategory, IHaveDescription, IHaveMediaConvertJobTemplateTypesAccelerationSettingsAccelerationSettings, IHavePriority_Integer, IHaveSettingsJson_Json, IHaveStatusUpdateInterval, IHaveQueue, IHaveListOfMediaConvertJobTemplateTypesHopDestinationHopDestinations, IHaveTags_Json, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.MediaConvert.JobTemplate; }
        /// <summary>
        /// Category
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-jobtemplate.html#cfn-mediaconvert-jobtemplate-category
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Category { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-jobtemplate.html#cfn-mediaconvert-jobtemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AccelerationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-jobtemplate.html#cfn-mediaconvert-jobtemplate-accelerationsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccelerationSettings
        /// </summary>
        public Union<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings, BaseFunction>? AccelerationSettings { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-jobtemplate.html#cfn-mediaconvert-jobtemplate-priority
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Priority { get; set; }

        /// <summary>
        /// SettingsJson
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-jobtemplate.html#cfn-mediaconvert-jobtemplate-settingsjson
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? SettingsJson { get; set; }
        /// <summary>
        /// StatusUpdateInterval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-jobtemplate.html#cfn-mediaconvert-jobtemplate-statusupdateinterval
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StatusUpdateInterval { get; set; }
        /// <summary>
        /// Queue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-jobtemplate.html#cfn-mediaconvert-jobtemplate-queue
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Queue { get; set; }
        /// <summary>
        /// HopDestinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-jobtemplate.html#cfn-mediaconvert-jobtemplate-hopdestinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HopDestination
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaConvert.JobTemplateTypes.HopDestination>, IReadOnlyList<Union<Humidifier.MediaConvert.JobTemplateTypes.HopDestination, BaseFunction>>, BaseFunction>? HopDestinations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconvert-jobtemplate.html#cfn-mediaconvert-jobtemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace JobTemplateTypes
    {
        public class AccelerationSettings : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-jobtemplate-accelerationsettings.html#cfn-mediaconvert-jobtemplate-accelerationsettings-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class HopDestination : Humidifier.Base.BaseSubResource, IHaveWaitMinutes_Integer, IHavePriority_Integer, IHaveQueue
        {
            /// <summary>
            /// WaitMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-jobtemplate-hopdestination.html#cfn-mediaconvert-jobtemplate-hopdestination-waitminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WaitMinutes { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-jobtemplate-hopdestination.html#cfn-mediaconvert-jobtemplate-hopdestination-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// Queue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-jobtemplate-hopdestination.html#cfn-mediaconvert-jobtemplate-hopdestination-queue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Queue { get; set; }
        }
    }
}