namespace Humidifier.PI
{
    using global::System.Collections.Generic;

    public class PerfReports : Humidifier.Base.BaseResource, IHaveTags, IHaveIdentifier, IHaveEndTime, IHaveServiceType, IHaveStartTime
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
        public Union<string, BaseFunction>? Identifier { get; set; }

        /// <summary>
        /// EndTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pi-perfreports.html#cfn-pi-perfreports-endtime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndTime { get; set; }

        /// <summary>
        /// ServiceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pi-perfreports.html#cfn-pi-perfreports-servicetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceType { get; set; }

        /// <summary>
        /// StartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pi-perfreports.html#cfn-pi-perfreports-starttime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StartTime { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pi-perfreports.html#cfn-pi-perfreports-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}