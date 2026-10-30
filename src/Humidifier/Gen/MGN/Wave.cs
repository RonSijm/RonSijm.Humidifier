namespace Humidifier.MGN
{
    using global::System.Collections.Generic;
    using WaveTypes;

    public class Wave : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public dynamic Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-wave.html#cfn-mgn-wave-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace WaveTypes
    {
        public class WaveAggregatedStatus : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProgressStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-wave-waveaggregatedstatus.html#cfn-mgn-wave-waveaggregatedstatus-progressstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProgressStatus { get; set; }
            /// <summary>
            /// TotalApplications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-wave-waveaggregatedstatus.html#cfn-mgn-wave-waveaggregatedstatus-totalapplications
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TotalApplications { get; set; }
            /// <summary>
            /// HealthStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-wave-waveaggregatedstatus.html#cfn-mgn-wave-waveaggregatedstatus-healthstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HealthStatus { get; set; }
        }
    }
}