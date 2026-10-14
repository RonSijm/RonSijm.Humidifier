namespace Humidifier.PI
{
    using global::System.Collections.Generic;

    public class PerfReports : Humidifier.Base.BaseResource, IHaveTags, IHaveStartTime, IHaveIdentifier, IHaveEndTime, IHaveServiceType
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AnalysisReportId =  "AnalysisReportId" ;
            public static string CreateTime =  "CreateTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.PI.PerfReports; }

        /// <summary>
        /// Identifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pi-perfreports.html#cfn-pi-perfreports-identifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Identifier { get; set; }

        /// <summary>
        /// EndTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pi-perfreports.html#cfn-pi-perfreports-endtime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EndTime { get; set; }

        /// <summary>
        /// ServiceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pi-perfreports.html#cfn-pi-perfreports-servicetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceType { get; set; }

        /// <summary>
        /// StartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pi-perfreports.html#cfn-pi-perfreports-starttime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StartTime { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pi-perfreports.html#cfn-pi-perfreports-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}