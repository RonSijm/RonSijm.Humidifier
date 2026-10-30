namespace Humidifier.MGN
{
    using global::System.Collections.Generic;
    using WaveTypes;

    public class Wave : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveName
    {
        public class Attributes
        {
            public static string IsArchived =  "IsArchived" ;
            public static string WaveAggregatedStatus =  "WaveAggregatedStatus" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string LastModifiedDateTime =  "LastModifiedDateTime" ;
            public static string WaveID =  "WaveID" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MGN.Wave; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-wave.html#cfn-mgn-wave-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-wave.html#cfn-mgn-wave-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace WaveTypes
    {
        public class WaveAggregatedStatus : Humidifier.Base.BaseSubResource, IHaveProgressStatus, IHaveTotalApplications_Integer, IHaveHealthStatus
        {
            /// <summary>
            /// ProgressStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-wave-waveaggregatedstatus.html#cfn-mgn-wave-waveaggregatedstatus-progressstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProgressStatus { get; set; }
            /// <summary>
            /// TotalApplications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-wave-waveaggregatedstatus.html#cfn-mgn-wave-waveaggregatedstatus-totalapplications
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TotalApplications { get; set; }
            /// <summary>
            /// HealthStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-wave-waveaggregatedstatus.html#cfn-mgn-wave-waveaggregatedstatus-healthstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HealthStatus { get; set; }
        }
    }
}